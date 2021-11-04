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

    public Subject(string[] args)
    {
        number = args[0];
        major = args[1];
        id = args[2];
        group = args[3];
        name = args[4];
        division = args[5];
        grade = args[6];
        unit = args[7];
        time = args[8];
        classroom = args[9];
        professor = args[10];
        language = args[11];
    }
}
