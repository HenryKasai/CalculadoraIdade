﻿using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nascimento = new DateTime(2004, 4, 12, 00, 00, 00);
            DateTime agora = DateTime.Today;
            TimeSpan diasdecorridos = agora - nascimento;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Eu nasci em {nascimento.ToShortDateString()} e já vivi {diasdecorridos.Days} dias.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Agora vamos descobrir quantos dias você já viveu.");
            Console.WriteLine("Insira sua data de nascimento conforma o modelo exposto: ano, mês, dia.");
            
            string nascimentousuáriostring = Console.ReadLine();
            DateTime nascimentousuário = Convert.ToDateTime(nascimentousuáriostring);
            TimeSpan diasdecorridosusuário = agora - nascimentousuário;     

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Você nasceu em {nascimentousuário.ToShortDateString()} e já viveu {diasdecorridosusuário.Days} dias");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();


        }
    }
}
