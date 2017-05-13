using System;
using PHMFizzTest.Core.Services;
using System.Configuration;

namespace PHMFizzTest.App
{
    public class FizzBuzzApp
    {
        //Get Fizz/Buzz based on multiples of 3/5.
        static void Main(string[] args)
        {
            //Read input from app.config
            string input = ConfigurationManager.AppSettings[Helpers.Helpers.INPUTNUMBER].ToString();
            string output;
            if (ValidateInput(input))
            {
                //Call Fizz Buzz Service 
                IFizzBuzzService fizzBuzzService = new FizzBuzzService();
                output = fizzBuzzService.Process(Convert.ToInt16(input));                
            }
            else 
                output = Helpers.Helpers.ERRORINPUT;

            Console.WriteLine(output);
            Console.WriteLine(Helpers.Helpers.PRESSKEY);
            Console.ReadLine();
        }

        //Validate the input to integer number
        public static bool ValidateInput(string input)
        {           
            bool isValid;
            int s;
            return isValid = int.TryParse(input, out s);
            
        }
    }
}
