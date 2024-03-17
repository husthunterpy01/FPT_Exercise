using Ex13.Service;
using System;

class Program
{
    static void Main(String[] args)
    {
        EmployeeManager e = new EmployeeManager();
        e.ProgramMenu();
        Console.ReadKey();
    }
}