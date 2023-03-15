using Core.Entities;
using System;
using Utilities.Enums;

Square kvadrat = new(6);
Rectangular duzbucaqli = new(8, 7);
Figure[] fiqurlar= new Figure[] {kvadrat, duzbucaqli};
foreach(var fiqur in fiqurlar)
{
    fiqur.CalcArea();
}
Console.WriteLine("\n==============" +
    "\n1.Square" +
    "\n2.Restangular" +
    "\n3.Quit"+
    "\n==============");
Console.Write("Please, choose a number:");
int input=int.Parse(Console.ReadLine());
switch(input)
{
    case 1: Console.WriteLine("Answer:"+kvadrat.CalcArea()); break;
    case 2: Console.WriteLine("Answer:"+duzbucaqli.CalcArea());break;
    case 3: Environment.Exit(0); break;
    default: Console.WriteLine("Invalid Input"); break;
}