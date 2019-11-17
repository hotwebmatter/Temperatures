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
                ReadTemperatures(i);
            }
            AverageForEach();
            AverageFor();
            FindHighestTemperature();
            FindTempsBelowGiven();
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

        private static void ReadTemperatures(int index)
        {
            string userInput;
            double number;
            Write("Enter temperature {0}: ", index + 1);
            userInput = ReadLine();
            while (double.TryParse(userInput, out number) == false)
            {
                // Invalid Input
                Write("Incorrect value\nEnter temperature {0}: ", index + 1);
                userInput = ReadLine();
            }
            temperaturesArray[index] = number;
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
            WriteLine("Average temperature is {0}", total / temperaturesArray.Length);
            WriteLine("************************************\n");
        }
        private static void AverageFor()
        {
            WriteLine("Display Temperature For Loop");
        }
        private static void FindHighestTemperature()
        {
            WriteLine("Highest Temperature is {0}", highestTemperature);
        }

        private static void FindTempsBelowGiven()
        {
            WriteLine("Display Temperature For Each Loop");
        }

    }
}
