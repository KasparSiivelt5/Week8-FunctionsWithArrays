using System;

namespace FunctionswithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string RandomColor = PickRandomColor(colors);
            DisplayRandomColor(colors);           
        }
        private static int GenerateRandomNumberForArray(string[] someArray)
        {
           Random rnd
        }

        
        
        private static void DisplayRandomColor(string[] somearray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, somearray.Length);
            return somearray[RandomIndex];
            Console.WriteLine(somearray[RandomIndex]);
        }    
    
    }
}
