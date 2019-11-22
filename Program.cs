/**
 * ######################################################
 * ##    Programming Assignment #11                    ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: November 17 2019              ##
 * ##    Purpose: Demonstrate usage of arrays          ##
 * ######################################################
 */
using System;
using static System.Console;

namespace Temperatures
{
    class Program
    {
        // Declare array as class-level variable, per specifiction
        private static double[] temperaturesArray = new double[7];
        private static double averageTemperature;
        private static double highestTemperature;
        static void Main(string[] args)
        {
            Write(GenerateHeader());
            for (int i = 0; i < 7; i++)
            {
                string label = string.Format("Enter temperature {0}: ", i + 1);
                temperaturesArray[i] = ReadTemperature(label);
            }
            AverageForEach();
            AverageFor();
            FindHighestTemperature();
            FindTempsBelowGiven();
            ReadLine();
        }

        private static string GenerateHeader()
        {
            string result = string.Format("\tWeekly Temperature Report\n");
            result += string.Format("\tMatthew Obert\n");
            result += string.Format("\tNovember 17 2019\n");
            result += string.Format("Enter 7 Temperatures\n");
            result += string.Format("************************************\n");
            return result;
        }

        private static double ReadTemperature(string label)
        {
            string userInput;
            double number;
            Write("{0}", label);
            userInput = ReadLine();
            while (double.TryParse(userInput, out number) == false)
            {
                // Invalid Input
                Write("Incorrect value\n{0}", label);
                userInput = ReadLine();
            }
            return number;
        }
        private static void AverageForEach()
        {
            double total = 0;
            WriteLine("Display Temperature For Each Loop");
            foreach (double temperature in temperaturesArray)
            {
                WriteLine("\t{0}", temperature);
                total += temperature;
            }
            averageTemperature = total / temperaturesArray.Length;
            WriteLine("Average temperature is {0:n1}", averageTemperature);
            WriteLine("************************************\n");
        }
        private static void AverageFor()
        {
            double total = 0;
            WriteLine("Display Temperature For Loop");
            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                WriteLine("{0}", temperaturesArray[i]);
                total += temperaturesArray[i];
            }
            averageTemperature = total / temperaturesArray.Length;
            WriteLine("Average temperature is {0:n1}", averageTemperature);
            WriteLine("************************************\n");
        }
        private static void FindHighestTemperature()
        {
            double highestTemperature = 0;
            foreach (double temperature in temperaturesArray)
            {
                if (temperature > highestTemperature)
                {
                    highestTemperature = temperature;
                }
            }
            WriteLine("Highest Temperature is {0}", highestTemperature);
            WriteLine("************************************\n");
        }

        private static void FindTempsBelowGiven()
        {
            string label = "Find temperatures lower than: ";
            double temperatureThreshold = ReadTemperature(label);
            int counter = 0;
            foreach (double temp in temperaturesArray)
            {
                if (temp < temperatureThreshold)
                {
                    counter++;
                }
            }
            WriteLine("There are {0} days lower than {1}", counter, temperatureThreshold);
            WriteLine("************************************\n");
        }

    }
}
