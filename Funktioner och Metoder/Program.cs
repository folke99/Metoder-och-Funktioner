using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktioner_och_Metoder
{
    class Program
    {
        // Övning 1
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Write the temprature in degrees celsius");
            int celsius = int.Parse(Console.ReadLine());
            int farenheit = convert(celsius);        
            Console.WriteLine("That is: " + farenheit + " degrees farenheit");
            Console.ReadKey();
        }

        public static int convert(int celsius)
        {
            return (celsius / 5) * 9 +  32;
        }
        */
        //Övning 2
        /*
        static void Main(string[] args)
        {
            Console.Write("Write te radius of the cirkel(cm): ");
            double radius = double.Parse(Console.ReadLine());
            double areaAnswer = area(radius);
            double circutAnswer = circut(radius);
            Console.WriteLine("Area: " +  Math.Round(areaAnswer, 2) + "cm^2 \n" + "Circut: " + Math.Round(circutAnswer, 2) + "cm");
            Console.ReadKey();
        }

        public static double area(double radius)
        {
            return (radius * radius) * Math.PI;
        }

        public static double circut(double radius)
        {
            return (radius * 2) * Math.PI;
        }
        */
        //Övning 3
        /*
        static void Main(string[] args)
        {
            Console.Write("Number of dice: ");
            int numberOfDice = int.Parse(Console.ReadLine());
            int toatalResult = diceValue(numberOfDice);
            Console.WriteLine("Result: " + toatalResult);
            Console.ReadKey();
        }

        public static int diceValue(int numberOfDice)
        {
            Random rnd = new Random();
            int[] randomNumbers = new int[numberOfDice];
            int total = 0;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(1,7);
                total = total + randomNumbers[i];
            }
            return total;
        }
        */
        //Övning 4
        /*
        static void Main (string[] args)
        {
            Console.Write("Number of dice: ");
            int numberOfDice = int.Parse(Console.ReadLine());
            Console.Write("Number of sides: ");
            int sidesOnDice = int.Parse(Console.ReadLine());
            int toatalResult = diceValue(numberOfDice, sidesOnDice);
            Console.WriteLine("Result: " + toatalResult);
            Console.ReadKey();
        }
       
        public static int diceValue(int numberOfDice)
        {
            Random rnd = new Random();
            int total = 0;
            for (int i = 0; i < numberOfDice; i++)
                total += rnd.Next(1, 7);          
            return total;
        }

        public static int diceValue(int numberOfDice, int sidesOnDice)
        {
            Random rnd = new Random();
            int total = 0;
            for (int i = 0; i < numberOfDice; i++)
                total += rnd.Next(1, sidesOnDice + 1);
            return total;
        }
        */
        //Övning 5
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Write like this: 1T6");
            string dice = Console.ReadLine();
            string toatalResult = DiceValue(dice);
            Console.WriteLine("Result: " + toatalResult);
            Console.ReadKey();
        }

        public static int DiceValue(int numberOfDice)
        {
            Random rnd = new Random();
            int total = 0;
            for (int i = 0; i < numberOfDice; i++)
                total += rnd.Next(1, 7);
            return total;
        }

        public static int DiceValue(int numberOfDice, int sidesOnDice)
        {
            Random rnd = new Random();
            int total = 0;
            for (int i = 0; i < numberOfDice; i++)
                total += rnd.Next(1, sidesOnDice + 1);
            return total;
        }

        public static string DiceValue(string dice)
        {
            string[] nbrDiceAndSides = dice.Split('T');
            int nbrOfDice = int.Parse(nbrDiceAndSides[0]);
            int typeOfDie = int.Parse(nbrDiceAndSides[1]);
            Random rnd = new Random();
            int total = 0;
            for (int i = 0; i < nbrOfDice; i++)
                total += rnd.Next(1, typeOfDie + 1);
            return total.ToString();
        }
        */
    }
}
