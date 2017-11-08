using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15CountriesLst
{
    class CountriesApp
    {
        
        static void Main(string[] args)
        {
            ArrayList countries = CountriesTextFile.readFromFile();
            foreach (var country in countries)
            {
                Console.WriteLine(country);   
            }

            ArrayList newCountries = new ArrayList {};
            CountriesTextFile.addToFile(newCountries);

            countries = CountriesTextFile.readFromFile();
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
