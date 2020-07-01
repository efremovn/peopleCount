using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("PLease press enter to increase amount by one and anything else" +
                    " + enter if you want to finish counting");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} are inside the bus. Press enter to close the program", counter);
            Console.Read();

        }
    }
}
