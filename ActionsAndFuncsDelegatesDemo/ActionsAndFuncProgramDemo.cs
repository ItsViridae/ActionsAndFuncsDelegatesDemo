using System;
using System.Reflection;
using System.Xml.Serialization;

namespace ActionsAndFuncsDelegatesDemo
{
    class ActionsAndFuncProgramDemo
    {
        static void Main(string[] args)
        {
            #region actionDriver
            Console.WriteLine("\nAction Section:");
            Console.WriteLine("-----------------------------------");
            var action = new Action<string>(Display);
            action("Using an Action to display a String");
            action("Action allows us to call void method types");
            action("They do NOT have a return call");
            action("Hey I'm Scott, This is a string");
            #endregion

            #region funcMultiplierDriver
            Console.WriteLine("\nFunc Section:");
            var func = new Func<int, double>(MultiplyByOnePointFive);
            Console.WriteLine($"Display Value:       Display Type:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{func(1)}               {func(1).GetType()}");
            Console.WriteLine($"{func(2)}               {func(2).GetType()}");
            Console.WriteLine($"{func(4)}               {func(4).GetType()}");
            Console.WriteLine($"{func(5)}               {func(5).GetType()}");
            #endregion


            #region FuncConverterDriver
            Console.WriteLine("\nConvert Section (my demo):");
            Console.WriteLine($"Display Value:       Display Type:");
            Console.WriteLine("------------------------------------");
            var convert = new Func<int, string>(ConvertIntToString);
            Console.WriteLine($"{convert(1)}            {convert(1).GetType()}");
            Console.WriteLine($"{convert(2)}            {convert(2).GetType()}");
            Console.WriteLine($"{convert(4)}            {convert(4).GetType()}");
            Console.WriteLine($"{convert(5)}            {convert(5).GetType()}");
            Console.Read();
            #endregion

        }

        #region actionDisplayMethod
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        #endregion

        #region funcMultiplierMethod
        static double MultiplyByOnePointFive(int numberToMultiply)
        {
            return (double)(numberToMultiply * 1.5);
        }
        #endregion

        #region FuncConverterMethod
        static string ConvertIntToString(int numToConvert)
        {
            return (string)numToConvert.ToString();
        }
        #endregion
    }
}
