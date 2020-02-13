using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._3
{
    static class Validator
    {
        /// <summary>
        /// Verifies that it is only getting back an interger from the User. 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static double DoubleFromUser(string prompt)
        {
            while (true)
            {
                string input = GetStringFromUser(prompt);
                bool done = double.TryParse(input, out double output);
                if (!done)
                {
                    Console.WriteLine("ERROR: Must be a number");
                }
                else
                {
                    return output;
                }
            }
        }

        /// <summary>
        /// Extends DoubleFromUser to allow for only a range of values.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static double DoubleFromUser(string prompt, double minValue, double maxValue)
        {
            while (true)
            {
                var output = DoubleFromUser(prompt);
                if (output < minValue)
                {
                    Console.WriteLine("ERROR: Value too low");
                }
                else if (output > maxValue)
                {
                    Console.WriteLine("ERROR: Value too high");
                }
                else
                {
                    return output;
                }
            }
        }

        /// <summary>
        /// Verifies that it is only getting back an interger from the User. 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static int IntFromUser(string prompt)
        {
            while (true)
            {
                string input = GetStringFromUser(prompt);
                bool done = int.TryParse(input, out int output);
                if (!done)
                {
                    Console.WriteLine("ERROR: Must be interger");
                }
                else
                {
                    return output;
                }
            }
        }

        /// <summary>
        /// Extends IntFromUser to allow for only a range of values.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int IntFromUser(string prompt, int minValue, int maxValue)
        {
            while (true)
            {
                var output = IntFromUser(prompt);
                if (output < minValue)
                {
                    Console.WriteLine("ERROR: Value too low");
                }
                else if (output > maxValue)
                {
                    Console.WriteLine("ERROR: Value too high");
                }
                else
                {
                    return output;
                }
                
            }
        }

        
        /// <summary>
        /// Prompts the user on the same line and asks for input in the console. 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static string GetStringFromUser(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

    }
}
