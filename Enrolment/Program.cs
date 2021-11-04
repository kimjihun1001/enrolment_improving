using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PrintView printview = new PrintView();
        printview.BringTextFile();
        printview.PrintMainScreen();
    }
}


