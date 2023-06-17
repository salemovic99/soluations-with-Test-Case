using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soluations
{

    internal class Program
    {
        public static string date_format(string date)
        {
            // write your code here
            string year = date.Substring(0, 4);
            string month = date.Length  > 8 ? date.Substring(5, 2) : date.Substring(5,1);
            string day = date.Length > 8 ? date.Substring(8, 2) : date.Substring(7, 1);

            string FormatTwo = date.Replace('/', '-');
            string FormatThree = month + "/" + day + "/" + year;

            return date + "|"  + FormatTwo + "|" + FormatThree;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(date_format("2020/11/28"));
            Console.ReadKey();
        }
    }
}
