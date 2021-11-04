using System;
using System.Collections.Generic;
using System.IO;

public class Function : MenuControl
{
    // 객체를 담아둘 리스트 생성 
    public static List<Subject> subjectList = new List<Subject>();
    // 수강신청한 목록을 담아둘 리스트 생성 
    public List<Subject> enrolmentList = new List<Subject>();
    // 관심 과목 추가한 목록을 담아둘 리스트 생성 
    public static List<Subject> interestList = new List<Subject>();

    // 텍스트 가져오기
    public void BringTextFile()
    {
        try
        {
            string text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "timetable.txt");
            string[] subjectTextList = text.Split('\n');

            // 텍스트 파일에서 가져온 텍스트를 객체에 집어넣고 객체 리스트에 넣기 
            for (int i = 1; i < 21; i++)
            {
                DisassembleSubjects(subjectTextList[i]);
            }
        }
        catch (SystemException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    // 한 줄씩 분리한 텍스트를 받아서 객체로 만들고 리스트에 넣는 메쏘드 
    public void DisassembleSubjects(string subject)
    {
        string[] fields = subject.Split('/');
        Subject oneSubject = new Subject(fields);
        subjectList.Add(oneSubject);
    }

    // 수강신청된 과목의 총 학점 계산 함수
    public double SumTotalUnit()
    {
        double unitTotal = 0;
        for (int i = 0; i < enrolmentList.Count; i++)
        {
            unitTotal += double.Parse(enrolmentList[i].Unit);
        }
        return unitTotal;
    }

    // 관심 과목 추가된 과목의 총 학점 계산 함수
    public double SumTotalInterestUnit()
    {
        double unitTotal = 0;
        for (int i = 0; i < interestList.Count; i++)
        {
            unitTotal += double.Parse(interestList[i].Unit);
        }
        return unitTotal;
    }

    // 해당 과목의 요일, 시간을 가져오는 함수 
    public List<double> GetTime(Subject args)
    {
        List<double> dayAndTime = new List<double>();
        // 요일, 시간, 요일, 시간 
        string[] timeSplit1 = args.Time.Split(' ');
        // 홀수번째에서 요일 가져오고, 짝수번째에서 시간 가져오기 
        for (int i = 0; i < timeSplit1.Length; i++)
        {
            switch (timeSplit1[i])
            {
                case "월":
                    dayAndTime.Add(0);
                    break;
                case "화":
                    dayAndTime.Add(1);
                    break;
                case "수":
                    dayAndTime.Add(2);
                    break;
                case "목":
                    dayAndTime.Add(3);
                    break;
                case "금":
                    dayAndTime.Add(4);
                    break;
                default:
                    break;
            }

            i++;
            string[] timeSplit2 = timeSplit1[i].Split('~');
            string[] timeSplit3 = timeSplit2[0].Split(':');
            string[] timeSplit4 = timeSplit2[1].Split(':');

            for (int j = 0; j < 2; j++)
            {
                if (timeSplit3[j] == "00")
                {
                    timeSplit3[j] = "0";
                }
                else if (timeSplit3[j] == "30")
                {
                    timeSplit3[j] = "0.5";
                }
                else { }

                if (timeSplit4[j] == "00")
                {
                    timeSplit4[j] = "0";
                }
                else if (timeSplit4[j] == "30")
                {
                    timeSplit4[j] = "0.5";
                }
                else { }
            }
            double startTime = int.Parse(timeSplit3[0]) + double.Parse(timeSplit3[1]);
            double endTime = int.Parse(timeSplit4[0]) + double.Parse(timeSplit4[1]);
            dayAndTime.Add(startTime);
            dayAndTime.Add(endTime);
        }

        // 요일, 시작시간, 끝시간, ... 
        return dayAndTime;
    }

    // 두 과목의 수업 시간이 겹치는지 비교하는 함수
    public bool CheckTime(Subject args, Subject args2)
    {
        bool isOverlapped = false;
        for (int i = 0; i < GetTime(args).Count; i += 3)
        {
            for (int j = 0; j < GetTime(args2).Count; j += 3)
            {
                if (GetTime(args)[i] == GetTime(args2)[j])
                {
                    // 겹치면 아웃 
                    if ((GetTime(args)[i + 2] > GetTime(args2)[j + 1]) && (GetTime(args)[i + 1] < GetTime(args2)[j + 2]))
                    {
                        isOverlapped = true;
                    }
                    else { }
                }
                else { }
            }
        }

        return isOverlapped;
    }

    // 과목 리스트 출력 함수
    public void PrintList(List<Subject> subjects)
    {
        int row = 12;
        Console.SetCursorPosition(0, row);
        Console.Write("No.");
        Console.SetCursorPosition(5, row);
        Console.Write("개설학과전공");
        Console.SetCursorPosition(23, row);
        Console.Write("학수번호");
        Console.SetCursorPosition(33, row);
        Console.Write("분반");
        Console.SetCursorPosition(38, row);
        Console.Write("교과목명");
        Console.SetCursorPosition(61, row);
        Console.Write("이수구분");
        Console.SetCursorPosition(71, row);
        Console.Write("학년");
        Console.SetCursorPosition(75, row);
        Console.Write("학점");
        Console.SetCursorPosition(81, row);
        Console.Write("요일 및 강의시간");
        Console.SetCursorPosition(126, row);
        Console.Write("강의실");
        Console.SetCursorPosition(142, row);
        Console.Write("교수명");
        Console.SetCursorPosition(166, row);
        Console.Write("강의언어");
        Console.SetCursorPosition(176, row);
        Console.Write("수강");
        Console.SetCursorPosition(182, row);
        Console.WriteLine("관심");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        for (int i = 0; i < subjects.Count; i++)
        {
            row = i + 14;
            Console.SetCursorPosition(0, row);
            Console.Write(subjects[i].Number);
            Console.SetCursorPosition(5, row);
            Console.Write(subjects[i].Major);
            Console.SetCursorPosition(23, row);
            Console.Write(subjects[i].Id);
            Console.SetCursorPosition(33, row);
            Console.Write(subjects[i].Group);
            Console.SetCursorPosition(38, row);
            Console.Write(subjects[i].Name);
            Console.SetCursorPosition(61, row);
            Console.Write(subjects[i].Division);
            Console.SetCursorPosition(71, row);
            Console.Write(subjects[i].Grade);
            Console.SetCursorPosition(75, row);
            Console.Write(subjects[i].Unit);
            Console.SetCursorPosition(81, row);
            Console.Write(subjects[i].Time);
            Console.SetCursorPosition(126, row);
            Console.Write(subjects[i].Classroom);
            Console.SetCursorPosition(142, row);
            Console.Write(subjects[i].Professor);
            Console.SetCursorPosition(166, row);
            Console.Write(subjects[i].Language);
            Console.SetCursorPosition(176, row);
            Console.Write(subjects[i].Enrolment);
            Console.SetCursorPosition(182, row);
            Console.WriteLine(subjects[i].Interest);
        }
    }

    // 계속할 지 묻는 탈출 함수
    // 강제로 이전화면으로 돌아가도록 하지 말고, 그냥 다시 현재 화면을 업데이트하고 사용자가 해당 기능을 계속 사용할 수 있도록 하는 게 나을 듯.
    public void Escape()
    {
        Console.WriteLine();
        Console.WriteLine("ESC를 눌러 이전화면으로 돌아가세요.");
        while (Console.ReadKey().Key != ConsoleKey.Escape) { }
    }

    // 검색 리스트에서 원하는 과목 관심추가하는 기능
    public void AddToInterestList(bool isinterestDone, List<Subject> searchedList)
    {
        while (!isinterestDone)
        {
            Console.Write("관심 과목으로 추가하고 싶은 과목의 번호(NO.)를 눌러주세요: ");
            bool interestSuccess = true;
            bool isNewinputValid = false;
            string newinput = ReadString();
            if (newinput == "\0")
            {
                break;
            }

            for (int i = 0; i < searchedList.Count; i++)
            {
                if (searchedList[i].Number == newinput)
                {
                    // 검색 결과 내에 입력한 값이 있는데 오류가 발생한 경우이기 때문에 true로 바꿔준다 
                    isNewinputValid = true;

                    if (SumTotalInterestUnit() + double.Parse(searchedList[i].Unit) > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("21학점을 초과합니다. 다시 입력해보세요. ");
                        interestSuccess = false;
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < interestList.Count; j++)
                        {
                            if (searchedList[i].Id == interestList[j].Id)
                            {
                                Console.WriteLine();
                                Console.WriteLine("해당 학수번호의 과목은 이미 관심 과목에 추가되어있습니다. 다시 입력해보세요: ");
                                interestSuccess = false;
                                break;
                            }
                            else if (CheckTime(searchedList[i], interestList[j]))
                            {
                                Console.WriteLine();
                                Console.WriteLine("기존 관심 과목과 시간이 겹칩니다. 다시 입력해보세요. ");
                                interestSuccess = false;
                                break;
                            }
                            else { }
                        }
                    }

                    if (interestSuccess == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("해당 과목을 관심 과목으로 추가했습니다.");
                        for (int j = 0; j < subjectList.Count; j++)
                        {
                            if (searchedList[i].Number == subjectList[j].Number)
                            {
                                subjectList[j].Interest = "O";
                                interestList.Add(subjectList[j]);
                                break;
                            }
                            else { }
                        }
                        isinterestDone = true;
                        break;
                    }
                    else { }
                }
                else { }
            }

            if (isNewinputValid == false)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과에 해당 번호의 과목이 없습니다. 다시 입력해보세요. ");
            }
            else if (interestSuccess == true)
            {
                // 나중에 여기서도 ESC / Enter 동시에 입력받을 수 있게 하면 좋을 듯.
                // 지금은 Enter키만 동작함.
                Console.WriteLine("Enter를 눌러 검색화면으로 돌아가세요.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
        }
    }

// 검색 리스트에서 원하는 과목 수강신청하는 기능
public void AddToEnrollmentList(bool isEnrolmentDone, List<Subject> searchedList)
    {
        while (!isEnrolmentDone)
        {
            Console.Write("수강신청하고 싶은 과목의 번호(NO.)를 눌러주세요: ");
            bool enrolSuccess = true;
            bool isNewinputValid = false;
            string newinput = ReadString();
            if (newinput == "\0")
            {
                break;
            }

            for (int i = 0; i < searchedList.Count; i++)
            {
                if (searchedList[i].Number == newinput)
                {
                    // 검색 결과 내에 입력한 값이 있는데 오류가 발생한 경우이기 때문에 true로 바꿔준다 
                    isNewinputValid = true;

                    if (SumTotalUnit() + double.Parse(searchedList[i].Unit) > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("21학점을 초과합니다. 다시 입력해보세요. ");
                        enrolSuccess = false;
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < enrolmentList.Count; j++)
                        {
                            if (searchedList[i].Id == enrolmentList[j].Id)
                            {
                                Console.WriteLine();
                                Console.WriteLine("해당 학수번호의 과목은 이미 수강 신청되어있습니다. 다시 입력해보세요. ");
                                enrolSuccess = false;
                                break;
                            }
                            else if (CheckTime(searchedList[i], enrolmentList[j]))
                            {
                                Console.WriteLine();
                                Console.WriteLine("기존 신청 과목과 시간이 겹칩니다. 다시 입력해보세요. ");
                                enrolSuccess = false;
                                break;
                            }
                            else { }
                        }
                    }

                    if (enrolSuccess == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("해당 과목을 수강 신청했습니다.");
                        // 검색 리스트의 번호와 같은 과목 리스트의 수강 신청 여부를 업데이트하고 수강 신청 리스트에 추가 
                        for (int j = 0; j < subjectList.Count; j++)
                        {
                            if (searchedList[i].Number == subjectList[j].Number)
                            {
                                subjectList[j].Enrolment = "O";
                                enrolmentList.Add(subjectList[j]);
                                break;
                            }
                            else { }
                        }
                        isEnrolmentDone = true;
                        break;
                    }
                    else { }
                }
                else { }
            }

            if (isNewinputValid == false)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과에 해당 번호의 과목이 없습니다. 다시 입력해보세요. ");
            }
            else if (enrolSuccess == true)
            {
                // 나중에 여기서도 ESC / Enter 동시에 입력받을 수 있게 하면 좋을 듯.
                // 지금은 Enter키만 동작함.
                Console.WriteLine("Enter를 눌러 검색화면으로 돌아가세요.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
        }
    }
}
