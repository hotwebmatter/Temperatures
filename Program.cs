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
    }
}
