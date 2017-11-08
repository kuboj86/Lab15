using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15CountriesLst
{
    class CountriesTextFile
    {
        static readonly string FILENAME = "countries.txt";

        //private string countryName;

        //public string CountryName
        //{
        //    get { return CountryName; }
        //    set { CountryName = value; }
        //}

        //public CountriesTextFile(string countryName)
        //{
        //    this.countryName = countryName;
        //}

        //ArrayList countries = readFromFile(FILENAME);

        public static ArrayList readFromFile()
        {
            StreamReader inputFile;
            try
            {
                inputFile = new StreamReader(FILENAME);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Error accessing file.  Please check file permissions.");
                Console.WriteLine($"Detailed Info: {e.Message}");
                return null;
            }
            ArrayList countries = new ArrayList();
            while (true)
            {
                string line = inputFile.ReadLine();
                if (line == null || line == "")
                {
                    break;
                }
                //CountriesTextFile s = new CountriesTextFile();
                countries.Add(line);
            }
            inputFile.Close();
            //Console.WriteLine(countries.Count);
            return countries;

        }

        public static void addToFile(ArrayList countries)
        {
            StreamWriter outFile;
            try
            {
                outFile = new StreamWriter(FILENAME);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Error accessing file.  Please check file permissions.");
                Console.WriteLine($"Detailed Info: {e.Message}");
                return;
            }
            foreach (var country in countries)
            {
                outFile.WriteLine(country);
            }
            outFile.Close();
            return;
        }
    }
}
