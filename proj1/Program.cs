﻿namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Operação Desejada");
        string operation = Console.ReadLine();
        Console.WriteLine("Primeira entrada");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segunda entrada");
        int n2 = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Resultado: {n1+n2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {n1-n2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {n1*n2}");
                break;
            case "/":
                Console.WriteLine($"Resultado: {n1/n2}");
                break;
            default:
                Console.WriteLine("null");
                break;
        }
        
    }
    }
}
//Versao v2.0