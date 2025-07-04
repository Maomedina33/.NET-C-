using System;

CalculatorService calculator = new CalculatorService();

Console.WriteLine("Adition:"+ calculator.Add(5,3) );
Console.WriteLine("Subtraction:" + calculator.Subtract(5, 3));
Console.WriteLine("Multiplication:" + calculator.Multiply(5, 3));
Console.WriteLine("Division:" + calculator.Divide(5, 3));
