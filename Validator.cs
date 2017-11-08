using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15CountriesLst
{
    class Validator
    {
        static int GetNumber(string message)
        {
            //validate input is int
            while (true)
            {
                Console.WriteLine(message);
                int selection;

                string input = Console.ReadLine();

                if (int.TryParse(input, out selection))
                {

                    if (selection < 1 || selection > 3)
                    {
                        Console.WriteLine("Please eter a valid option.");
                    }
                    else
                    {
                        return selection;
                    }
                }
            }
        }
    }
}
