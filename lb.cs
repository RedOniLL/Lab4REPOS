using System;


namespace Lab3
{
    public static class lb
    {
        public static void Task1()
        {
            try
            {
                Console.WriteLine("Enter a string of characters from 0 to 9:");
                string input = Console.ReadLine();


                int number = int.Parse(input);



                Console.WriteLine($"Entered number: {number}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The entered number is outside the range of the int type.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unknown error occurred: {ex.Message}");
            }

        }

        public static void Task2()
        {
            try
            {
                Console.WriteLine("Enter a string of characters from 0 to 9:");
                string input = Console.ReadLine();


                int number = Convert.ToInt32(input, 2);



                Console.WriteLine($"Entered number: {number}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The entered number is outside the range of the int type.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unknown error occurred: {ex.Message}");
            }

        }

        public static void Task4()
        {
            try
            {
                Console.WriteLine("Enter a mathematical expression (for example, 3*2*1*4):");
                string input = Console.ReadLine();

               
                string[] tokens = input.Split('*');

               
                int result = 1;

                
                foreach (string token in tokens)
                {
                    
                    result *= int.Parse(token);
                }

                Console.WriteLine($"Result of the expression: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: The entered data cannot be converted to an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unknown error occurred: {ex.Message}");
            }
        }
    }
}
