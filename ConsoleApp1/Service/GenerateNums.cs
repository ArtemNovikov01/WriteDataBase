using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    public class GenerateNums
    {
        public static decimal GenerateDec()
        {
            Random random = new Random();
            decimal decimalValue = random.Next(1000000) / 1000000m;
            decimal roundedValue = Math.Round(decimalValue*9999999, 6);
            return roundedValue;
        }

        public static Int64 GenerateDate() 
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("yyyy-MM-dd");
            string dateConv = date.Replace("-", "");
            Int64 dateInt = (Int64)int.Parse(dateConv);

            return dateInt;
        }
    }
}
