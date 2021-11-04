using System;
using System.Collections.Generic;

public class Subject
{
    private string number;
    private string major;
    private string id;
    private string group;
    private string name;
    private string division;
    private string grade;
    private string unit;
    private string time;
    private string classroom;
    private string professor;
    private string language;
    private string enrolment;
    private string interest;

    public string Number
    {
        get; set;
    }
    public string Major
    {
        get; set;
    }
    public string Id
    {
        get; set;
    }
    public string Group
    {
        get; set;
    }
    public string Name
    {
        get; set;
    }
    public string Division
    {
        get; set;
    }
    public string Grade
    {
        get; set;
    }
    public string Unit
    {
        get; set;
    }
    public string Time
    {
        get; set;
    }
    public string Classroom
    {
        get; set;
    }
    public string Professor
    {
        get; set;
    }
    public string Language
    {
        get; set;
    }
    public string Enrolment
    {
        get; set;
    }
    public string Interest
    {
        get; set;
    }

    //private field여도 이렇게 매개변수로 받아서 설정할 수 있지 않나..?
    //아하, get/set 사용하려고 property 사용했으니까 소문자가 아니라 대문자로 해야함!!!
    // ex) number -> Number
    public Subject(string[] args)
    {
        Number = args[0];
        Major = args[1];
        Id = args[2];
        Group = args[3];
        Name = args[4];
        Division = args[5];
        Grade = args[6];
        Unit = args[7];
        Time = args[8];
        Classroom = args[9];
        Professor = args[10];
        Language = args[11];
    }
}
