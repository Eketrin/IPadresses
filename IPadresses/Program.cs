using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace IPadresses
{
    class Program
    {
        static bool IsIP(string input)
        {
            string pattern2 = @"^\d\d?\d?\.\d\d?\d?\.\d\d?\d?\.\d\d?\d?$";
            if (Regex.IsMatch(input, pattern2))
            {
                foreach (var item in input.Split('.')) //251
                {
                    if (int.TryParse(item, out int result) && result >= 0 && result <= 255)
                    {
                        
                    }
                    else return false;
                }
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            string[] values = { "251.5.65.88", "1.1.1.1", "256.1.0.3", "235.33.22.1", 
                "125+145+65+5", "0.0.0.0", "0/0/0/0", "255.255.255.255"};

            foreach (var item in values)
            {
                if (IsIP(item))
                {
                    Console.WriteLine($"{item} Да");
                }
                else
                {
                    Console.WriteLine($"{item} Нет");
                }
            }

            Console.ReadLine();
        }
    }
}
