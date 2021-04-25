using System;
using System.Linq;

namespace ArrayProgram
{
    class ArrayProgram
    {
        static void Main(string[] args)
        {
         
                int[] array = new int[] { 7, 3, 3, 2, 9, 4, 1 };
                var uniqueArrayElements = array.Distinct().ToArray();
                Console.WriteLine(String.Join(",", array));
                Console.WriteLine("\n\nEnter a number  to find out how many number are above and below the input number in the above array:");
            try
            {
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                int above = 0;
                int below = 0;
                foreach (int number in uniqueArrayElements)
                {
                    if (number > inputNumber)
                        above++;
                    else if (number < inputNumber)
                        below++;
                }
                Console.WriteLine("Above: {0}\nBelow: {1}", above, below);

            }
            catch(Exception e)
            {
                Console.WriteLine("ErrorMessage{0}\n", e.Message);
              

         
            }

        
                Console.ReadLine();


            }
        }
    }

