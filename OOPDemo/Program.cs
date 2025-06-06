﻿using System;
using System.Collections.Generic;
using OOPDemo.Models;

class Program
{
    static void Main()
    {
        // test for inheritance
        List<Machine> machines = new List<Machine>
        {
            new Laptop()
        };

        foreach (var machine in machines)
        {
            machine.ShowInfo();
            machine.Start();
        }

        // test for interface
        var col1 = new List<IPrintable> { new OfficePrinter(), new AllInOne() };
        var col2 = new List<IScannable> { new AllInOne(), new ScannerOnly() };
        var col3 = new List<IFaxable> { new AllInOne(), new ScannerOnly() };

        foreach (var p in col1) p.Print();
        foreach (var s in col2) s.Scan();
        foreach (var f in col3) f.Fax();

        // === Homework: Полиморфизъм и капсулация ===
        Console.WriteLine("\n--- Homework: Class Hierarchy ---");

        List<BaseMachine> testMachines = new List<BaseMachine>
        {
            new AdvancedMachine { Model = "A100" },
            new UltraMachine { Model = "U200" }
        };

        foreach (var machine in testMachines)
        {
            Console.WriteLine(machine.Model);
            machine.ShowInfo();
        }
    }
}

