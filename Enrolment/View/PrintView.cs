using System;
using System.Collections.Generic;
using System.IO;

public class PrintView : Function
{
    // 콘솔 클리어 & 타이틀
    public void PrintTitle()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("██████╗  ██████╗ ██████╗  ██╗    ███████╗███╗   ██╗██████╗  ██████╗ ██╗     ███╗   ███╗███████╗███╗   ██╗████████╗");
        Console.WriteLine("╚════██╗██╔═████╗╚════██╗███║    ██╔════╝████╗  ██║██╔══██╗██╔═══██╗██║     ████╗ ████║██╔════╝████╗  ██║╚══██╔══╝");
        Console.WriteLine(" █████╔╝██║██╔██║ █████╔╝╚██║    █████╗  ██╔██╗ ██║██████╔╝██║   ██║██║     ██╔████╔██║█████╗  ██╔██╗ ██║   ██║   ");
        Console.WriteLine("██╔═══╝ ████╔╝██║██╔═══╝  ██║    ██╔══╝  ██║╚██╗██║██╔══██╗██║   ██║██║     ██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║   ");
        Console.WriteLine("███████╗╚██████╔╝███████╗ ██║    ███████╗██║ ╚████║██║  ██║╚██████╔╝███████╗██║ ╚═╝ ██║███████╗██║ ╚████║   ██║   ");
        Console.WriteLine("╚══════╝ ╚═════╝ ╚══════╝ ╚═╝    ╚══════╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝   ");
        Console.WriteLine("-----------------------------------------------------------------------------------------------뒤로가기:ESC--------");
        Console.WriteLine();
    }

    // 메인 화면 
    public void PrintMainScreen()
    {
        while (true)
        {
            PrintTitle();
            Console.WriteLine("1. 수강신청");
            Console.WriteLine("2. 관심과목");
            Console.WriteLine("3. 나의 시간표");
            Console.WriteLine("4. 종료");
            Console.WriteLine();
            Console.Write("원하시는 메뉴의 숫자를 입력해주세요: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PrintScreen_1();
                    break;
                case "2":
                    PrintScreen_2();
                    break;
                case "3":
                    PrintScreen_3();
                    break;
                case "4":
                    // 창을 꺼야 함
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    Console.Write("잘못된 값을 입력했습니다. 다시 입력하세요: ");
                    break;
            }
        }

    }

    // 1번 화면: 수강 신청 
    public void PrintScreen_1()
    {
        while (true)
        {
            PrintTitle();
            Console.WriteLine("1. 수강 강의 추가");
            Console.WriteLine("2. 수강 강의 삭제");
            Console.WriteLine("3. 수강 강의 조회");
            Console.WriteLine("4. 전체 강의 목록");
            Console.WriteLine("5. 강의 검색");
            Console.WriteLine("6. 처음 화면으로 돌아가기");
            Console.WriteLine("7. 종료");
            Console.WriteLine();
            Console.Write("원하시는 메뉴의 숫자를 입력해주세요: ");

            string input = ReadString();

            if (input == "\0")
            {
                break;
            }

            switch (input)
            {
                case "1":
                    PrintScreen_1_1();
                    break;
                case "2":
                    PrintScreen_1_2();
                    break;
                case "3":
                    PrintScreen_1_3();
                    break;
                case "4":
                    PrintScreen_1_4();
                    break;
                case "5":
                    PrintScreen_1_5();
                    break;
                case "6":
                    PrintMainScreen();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    Console.Write("잘못된 값을 입력했습니다. 다시 입력하세요: ");
                    break;
            }
        }

    }

    // 1-1 화면: 수강 강의 추가 
    public void PrintScreen_1_1()
    {
        while (true)
        {
            PrintTitle();
            Console.WriteLine("1. 개설 학과 전공으로 검색하여 수강 신청");
            Console.WriteLine("2. 학수 번호로 검색하여 수강 신청");
            Console.WriteLine("3. 교과목 명으로 검색하여 수강 신청");
            Console.WriteLine("4. 강의 대상 학년으로 검색하여 수강 신청");
            Console.WriteLine("5. 교수명으로 검색하여 수강 신청");
            Console.WriteLine("6. 관심과목으로 검색하여 수강 신청");
            Console.WriteLine("7. 처음 화면으로 돌아가기");
            Console.WriteLine("8. 종료");
            Console.WriteLine();
            Console.Write("원하시는 메뉴의 숫자를 입력해주세요: ");

            string input = ReadString();

            if (input == "\0")
            {
                break;
            }

            switch (input)
            {
                case "1":
                    PrintScreen_1_1_1();
                    break;
                case "2":
                    PrintScreen_1_1_2();
                    break;
                case "3":
                    PrintScreen_1_1_3();
                    break;
                case "4":
                    PrintScreen_1_1_4();
                    break;
                case "5":
                    PrintScreen_1_1_5();
                    break;
                case "6":
                    PrintScreen_1_1_6();
                    break;
                case "7":
                    PrintMainScreen();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    Console.Write("잘못된 값을 입력했습니다. 다시 입력하세요: ");
                    break;
            }
        }
    }

    // 1-1-1 화면: 개설 학과 전공으로 검색하여 수강 신청 
    public void PrintScreen_1_1_1()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("개설 학과 전공으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Major.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isEnrolmentDone = true;
            if (isThereSearchResult == true)
            {
                isEnrolmentDone = false;
            }
            AddToEnrollmentList(isEnrolmentDone, searchedList);
        }
    }

    // 1-1-2 화면: 학수 번호 
    public void PrintScreen_1_1_2()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("학수 번호로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Id.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isEnrolmentDone = true;
            if (isThereSearchResult == true)
            {
                isEnrolmentDone = false;
            }
            AddToEnrollmentList(isEnrolmentDone, searchedList);
        }
    }

    // 1-1-3 화면: 교과목 명 
    public void PrintScreen_1_1_3()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("교과목 명으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Name.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isEnrolmentDone = true;
            if (isThereSearchResult == true)
            {
                isEnrolmentDone = false;
            }
            AddToEnrollmentList(isEnrolmentDone, searchedList);
        }
    }

    // 1-1-4 화면: 강의 대상 학년 
    public void PrintScreen_1_1_4()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("강의 대상 학년으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Grade.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isEnrolmentDone = true;
            if (isThereSearchResult == true)
            {
                isEnrolmentDone = false;
            }
            AddToEnrollmentList(isEnrolmentDone, searchedList);
        }
    }

    // 1-1-5 화면: 교수명 
    public void PrintScreen_1_1_5()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("교수명으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Professor.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isEnrolmentDone = true;
            if (isThereSearchResult == true)
            {
                isEnrolmentDone = false;
            }
            AddToEnrollmentList(isEnrolmentDone, searchedList);
        }
    }

    // 1-1-6 화면: 관심 과목 
    public void PrintScreen_1_1_6()
    {
        while (true)
        {
            PrintTitle();
            PrintList(interestList);
            AddToEnrollmentList(true, interestList);
            Escape();
            break;
        }
    }


    // 1-2 화면: 수강 강의 삭제 
    public void PrintScreen_1_2()
    {
        while (true)
        {
            PrintTitle();

            PrintList(enrolmentList);

            Console.WriteLine();
            Console.WriteLine("내가 수강 신청한 총 학점: " + SumTotalUnit());
            Console.WriteLine();
            Console.Write("삭제하길 원하는 강의의 번호(No.)를 입력하세요: ");

            string input = ReadString();

            if (input == "\0")
            {
                break;
            }

            bool isInputValid = false;
            for (int i = 0; i < enrolmentList.Count; i++)
            {
                if (input == enrolmentList[i].Number)
                {
                    Console.WriteLine("해당 과목이 삭제되었습니다.");
                    for (int j = 0; j < subjectList.Count; j++)
                    {
                        if (enrolmentList[i].Number == subjectList[j].Number)
                        {
                            subjectList[j].Enrolment = "";
                            enrolmentList.RemoveAt(i);
                            break;
                        }
                        else { }
                    }
                    isInputValid = true;
                    break;
                }
                else { }
            }

            if (isInputValid == false)
            {
                Console.WriteLine();
                Console.WriteLine("수강 신청 목록 중에 입력하신 번호에 해당하는 과목이 없습니다. Enter 키를 눌러 다시 입력하세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else { }
        }
    }

    // 1-3 화면: 수강 강의 조회 
    public void PrintScreen_1_3()
    {
        PrintTitle();

        PrintList(enrolmentList);

        Console.WriteLine();
        Console.WriteLine("내가 수강 신청한 총 학점: " + SumTotalUnit());
        Console.WriteLine("수강 과목 리스트를 텍스트 파일로 내보내려면 Y를 누르세요");
        ExportToTextFile();
        Escape();
    }

    // 1-4 화면: 전체 강의 목록
    public void PrintScreen_1_4()
    {
        PrintTitle();

        PrintList(subjectList);

        Escape();
    }

    // 1-5 화면: 강의 검색 
    public void PrintScreen_1_5()
    {
        while (true)
        {
            PrintTitle();
            Console.WriteLine("1. 개설 학과 전공으로 검색");
            Console.WriteLine("2. 학수 번호로 검색");
            Console.WriteLine("3. 교과목 명으로 검색");
            Console.WriteLine("4. 강의 대상 학년으로 검색");
            Console.WriteLine("5. 교수명으로 검색");
            Console.WriteLine("6. 처음 화면으로 돌아가기");
            Console.WriteLine("7. 종료");
            Console.WriteLine();
            Console.Write("원하시는 메뉴의 숫자를 입력해주세요: ");

            string input = ReadString();

            if (input == "\0")
            {
                break;
            }

            switch (input)
            {
                case "1":
                    PrintScreen_1_5_1();
                    break;
                case "2":
                    PrintScreen_1_5_2();
                    break;
                case "3":
                    PrintScreen_1_5_3();
                    break;
                case "4":
                    PrintScreen_1_5_4();
                    break;
                case "5":
                    PrintScreen_1_5_5();
                    break;
                case "6":
                    PrintMainScreen();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    Console.Write("잘못된 값을 입력했습니다. 다시 입력하세요: ");
                    break;
            }
        }
    }

    // 1-5-1
    public void PrintScreen_1_5_1()
    {
        PrintTitle();
        Console.Write("개설 학과 전공으로 검색: ");

        List<Subject> searchedList = new List<Subject>();

        bool isThereSearchResult = false;
        while (!isThereSearchResult)
        {
            string input = ReadString();

            if (input == "\0")
            {
                break;
            }
            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Major.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine("검색 결과가 없습니다. 다시 검색해보세요: ");
            }
            else
            {
                PrintList(searchedList);
            }
        }
        Escape();
    }

    // 1-5-2
    public void PrintScreen_1_5_2()
    {
        PrintTitle();
        Console.Write("학수 번호로 검색: ");

        List<Subject> searchedList = new List<Subject>();

        bool isThereSearchResult = false;
        while (!isThereSearchResult)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Id.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine("검색 결과가 없습니다. 다시 검색해보세요: ");
            }
            else
            {
                PrintList(searchedList);
            }
        }
        Escape();
    }

    // 1-5-3
    public void PrintScreen_1_5_3()
    {
        PrintTitle();
        Console.Write("교과목 명으로 검색: ");

        List<Subject> searchedList = new List<Subject>();

        bool isThereSearchResult = false;
        while (!isThereSearchResult)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Name.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine("검색 결과가 없습니다. 다시 검색해보세요: ");
            }
            else
            {
                PrintList(searchedList);
            }
        }
        Escape();
    }

    // 1-5-4
    public void PrintScreen_1_5_4()
    {
        PrintTitle();
        Console.Write("강의 대상 학년으로 검색: ");

        List<Subject> searchedList = new List<Subject>();

        bool isThereSearchResult = false;
        while (!isThereSearchResult)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Grade.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine("검색 결과가 없습니다. 다시 검색해보세요: ");
            }
            else
            {
                PrintList(searchedList);
            }
        }
        Escape();
    }

    // 1-5-5
    public void PrintScreen_1_5_5()
    {
        PrintTitle();
        Console.Write("교수명으로 검색: ");

        List<Subject> searchedList = new List<Subject>();

        bool isThereSearchResult = false;
        while (!isThereSearchResult)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Professor.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine("검색 결과가 없습니다. 다시 검색해보세요: ");
            }
            else
            {
                PrintList(searchedList);
            }
        }
        Escape();
    }






    // 2번 화면: 관심 과목
    public void PrintScreen_2()
    {
        while (true)
        {
            PrintTitle();
            Console.WriteLine("1. 관심 과목 추가");
            Console.WriteLine("2. 관심 과목 삭제");
            Console.WriteLine("3. 관심 과목 조회");
            Console.WriteLine("4. 전체 강의 목록");
            Console.WriteLine("5. 강의 검색");
            Console.WriteLine("6. 처음 화면으로 돌아가기");
            Console.WriteLine("7. 종료");
            Console.WriteLine();
            Console.Write("원하시는 메뉴의 숫자를 입력해주세요: ");

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            switch (input)
            {
                case "1":
                    PrintScreen_2_1();
                    break;
                case "2":
                    PrintScreen_2_2();
                    break;
                case "3":
                    PrintScreen_2_3();
                    break;
                case "4":
                    PrintScreen_2_4();
                    break;
                case "5":
                    PrintScreen_1_5();
                    break;
                case "6":
                    PrintMainScreen();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("잘못된 값을 입력했습니다. 다시 입력하세요. ");
                    break;
            }
        }

    }

    // 2-1 화면: 관심 과목 추가 
    public void PrintScreen_2_1()
    {
        while (true)
        {
            PrintTitle();
            Console.WriteLine("1. 개설 학과 전공으로 검색하여 관심 과목 추가");
            Console.WriteLine("2. 학수 번호로 검색하여 관심 과목 추가");
            Console.WriteLine("3. 교과목 명으로 검색하여 관심 과목 추가");
            Console.WriteLine("4. 강의 대상 학년으로 검색하여 관심 과목 추가");
            Console.WriteLine("5. 교수명으로 검색하여 관심 과목 추가");
            Console.WriteLine("6. 처음 화면으로 돌아가기");
            Console.WriteLine("7. 종료");
            Console.WriteLine();
            Console.Write("원하시는 메뉴의 숫자를 입력해주세요: ");

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            switch (input)
            {
                case "1":
                    PrintScreen_2_1_1();
                    break;
                case "2":
                    PrintScreen_2_1_2();
                    break;
                case "3":
                    PrintScreen_2_1_3();
                    break;
                case "4":
                    PrintScreen_2_1_4();
                    break;
                case "5":
                    PrintScreen_2_1_5();
                    break;
                case "6":
                    PrintMainScreen();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("잘못된 값을 입력했습니다. 다시 입력하세요. ");
                    break;
            }
        }
    }

    // 2-1-1 화면: 개설 학과 전공으로 검색하여 관심 과목 추가
    public void PrintScreen_2_1_1()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("개설 학과 전공으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Major.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isinterestDone = true;
            if (isThereSearchResult == true)
            {
                isinterestDone = false;
            }
            AddToInterestList(isinterestDone, searchedList);
        }
    }

    // 2-1-2 화면: 학수 번호 
    public void PrintScreen_2_1_2()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("학수번호로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Id.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isinterestDone = true;
            if (isThereSearchResult == true)
            {
                isinterestDone = false;
            }
            AddToInterestList(isinterestDone, searchedList);
        }
    }

    // 2-1-3 화면: 교과목 명 
    public void PrintScreen_2_1_3()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("교과목 명으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Name.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isinterestDone = true;
            if (isThereSearchResult == true)
            {
                isinterestDone = false;
            }
            AddToInterestList(isinterestDone, searchedList);
        }
    }

    // 2-1-4 화면: 강의 대상 학년 
    public void PrintScreen_2_1_4()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("강의 대상 학년으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Grade.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isinterestDone = true;
            if (isThereSearchResult == true)
            {
                isinterestDone = false;
            }
            AddToInterestList(isinterestDone, searchedList);
        }
    }

    // 2-1-5 화면: 교수명 
    public void PrintScreen_2_1_5()
    {
        while (true)
        {
            bool isThereSearchResult = false;
            PrintTitle();
            Console.Write("교수명으로 검색: ");

            List<Subject> searchedList = new List<Subject>();

            string input = ReadString();
            if (input == "\0")
            {
                break;
            }

            for (int i = 0; i < 20; i++)
            {
                if (subjectList[i].Professor.Contains(input))
                {
                    searchedList.Add(subjectList[i]);
                    isThereSearchResult = true;
                }
                else { }
            }

            if (isThereSearchResult != true)
            {
                Console.WriteLine();
                Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else
            {
                Console.WriteLine();
                PrintList(searchedList);
            }

            bool isinterestDone = true;
            if (isThereSearchResult == true)
            {
                isinterestDone = false;
            }
            AddToInterestList(isinterestDone, searchedList);
        }
    }


    // 2-2 화면: 수강 강의 삭제 
    public void PrintScreen_2_2()
    {
        while (true)
        {
            PrintTitle();

            PrintList(interestList);

            Console.WriteLine();
            Console.WriteLine("내가 관심 과목으로 추가한 총 학점: " + SumTotalUnit());
            Console.WriteLine();
            Console.Write("삭제하길 원하는 강의의 번호(No.)를 입력하세요: ");

            string input = ReadString();

            if (input == "\0")
            {
                break;
            }

            bool isInputValid = false;
            for (int i = 0; i < interestList.Count; i++)
            {
                if (input == interestList[i].Number)
                {
                    Console.WriteLine("해당 과목이 삭제되었습니다.");
                    for (int j = 0; j < subjectList.Count; j++)
                    {
                        if (interestList[i].Number == subjectList[j].Number)
                        {
                            subjectList[j].Interest = "";
                            interestList.RemoveAt(i);
                            break;
                        }
                        else { }
                    }
                    isInputValid = true;
                    break;
                }
                else { }
            }

            if (isInputValid == false)
            {
                Console.WriteLine();
                Console.WriteLine("관심 과목 목록 중에 입력하신 번호에 해당하는 과목이 없습니다. Enter 키를 눌러 다시 입력하세요. ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            else { }
        }
    }

    // 2-3 화면: 수강 강의 조회 
    public void PrintScreen_2_3()
    {
        PrintTitle();

        PrintList(interestList);

        Console.WriteLine();
        Console.WriteLine("내가 수강 신청한 총 학점: " + SumTotalInterestUnit());

        Escape();
    }

    // 2-4 화면: 전체 강의 목록
    public void PrintScreen_2_4()
    {
        PrintTitle();

        PrintList(subjectList);

        Escape();
    }


    // 3번 화면: 나의 시간표 
    public void PrintScreen_3()
    {
        PrintTitle();

        int column = 0;
        int row = 0;
        Console.SetCursorPosition(30, 10);
        Console.Write("월");
        Console.SetCursorPosition(60, 10);
        Console.Write("화");
        Console.SetCursorPosition(90, 10);
        Console.Write("수");
        Console.SetCursorPosition(120, 10);
        Console.Write("목");
        Console.SetCursorPosition(150, 10);
        Console.Write("금");

        Console.SetCursorPosition(5, 11);
        Console.WriteLine("9:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 13);
        Console.WriteLine("9:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 15);
        Console.WriteLine("10:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 17);
        Console.WriteLine("10:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 19);
        Console.WriteLine("11:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 21);
        Console.WriteLine("11:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 23);
        Console.WriteLine("12:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 25);
        Console.WriteLine("12:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 27);
        Console.WriteLine("13:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 29);
        Console.WriteLine("13:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 31);
        Console.WriteLine("14:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 33);
        Console.WriteLine("14:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 35);
        Console.WriteLine("15:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 37);
        Console.WriteLine("15:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 39);
        Console.WriteLine("16:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 41);
        Console.WriteLine("16:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 43);
        Console.WriteLine("17:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 45);
        Console.WriteLine("17:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 47);
        Console.WriteLine("18:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 49);
        Console.WriteLine("18:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.SetCursorPosition(5, 51);
        Console.WriteLine("19:00");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.SetCursorPosition(5, 53);
        Console.WriteLine("19:30");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");

        for (int i = 0; i < enrolmentList.Count; i++)
        {
            for (int j = 0; j < GetTime(enrolmentList[i]).Count; j += 3)
            {
                switch (GetTime(enrolmentList[i])[j])
                {
                    case 0:
                        column = 20;
                        break;
                    case 1:
                        column = 50;
                        break;
                    case 2:
                        column = 80;
                        break;
                    case 3:
                        column = 110;
                        break;
                    case 4:
                        column = 140;
                        break;
                }

                double startTime = GetTime(enrolmentList[i])[j + 1];
                double endTime = GetTime(enrolmentList[i])[j + 2];

                while (startTime != endTime)
                {
                    switch (startTime)
                    {
                        case 9:
                            row = 11;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 9.5:
                            row = 13;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 10:
                            row = 15;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 10.5:
                            row = 17;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 11:
                            row = 19;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 11.5:
                            row = 21;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 12:
                            row = 23;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 12.5:
                            row = 25;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 13:
                            row = 27;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 13.5:
                            row = 29;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 14:
                            row = 31;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 14.5:
                            row = 33;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 15:
                            row = 35;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 15.5:
                            row = 37;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 16:
                            row = 39;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 16.5:
                            row = 41;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 17:
                            row = 43;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 17.5:
                            row = 45;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 18:
                            row = 47;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 18.5:
                            row = 49;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 19:
                            row = 51;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        case 19.5:
                            row = 53;
                            Console.SetCursorPosition(column, row);
                            Console.WriteLine(enrolmentList[i].Name);
                            break;
                        default:
                            break;
                    }
                    startTime += 0.5;
                }

            }
        }

        Console.SetCursorPosition(0, 55);
        Console.WriteLine("뒤로 돌아가려면 ESC를 누르세요.");
        while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        PrintMainScreen();
    }
}

