﻿// See https://aka.ms/new-console-template for more information

using Singleton;

Mechanic m1 = Mechanic.GetInstance();
Mechanic m2 = Mechanic.GetInstance();
Mechanic m3 = Mechanic.GetInstance();

if (m1 == m2 && m2 == m3)
{
    Console.WriteLine("Same instance\n");
}
m1.CheckProblem("dent on the door");
m1.Repair("door");

m2.CheckProblem("dent on the hood");
m2.Repair("hood");

m3.CheckProblem("jammed threshold");
m3.Repair("threshold");