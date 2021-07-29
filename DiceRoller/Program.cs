using System;
using System.Collections.Generic;
using DiceRoller.Model;

namespace DiceRoller
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<Die> dice = new();
            int sumValue = 0;
            int diceNumber = ValidateInput("Digite a quantidade de dados que deseja rolar: ");

            for (int i = 0; i < diceNumber; i++)
            {
                dice.Add(new Die(ValidateInput($"Digite a quantidade de lados do {i + 1}º dado: ")));
            }
            Console.WriteLine("---------- Resultados ----------");
            foreach (var die in dice)
            {
                Console.WriteLine($"Quantidade de lados: {die.GetSides()} \nNúmero rolado: {die.Roll()} \n----------------------");
                sumValue += die.RolledNumber;
            }
            Console.WriteLine($"A soma de todos os números rolados é de: {sumValue}");
        }

        static int ValidateInput(string message, bool canClear = false)
        {
            int value;
            try
            {
                if (canClear)
                    Console.Clear();
                Console.Write(message);
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                value = ValidateInput(message, true);
            }
            return value;
        }
    }
}
