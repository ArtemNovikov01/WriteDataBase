using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    public class GenerateDate
    {
        public static List<TablOne> GenerateTableOne(int count, int min, int max) 
        {
            Random random = new Random();
            
            var list = new List<TablOne>();

            for(int i =0; i < count; i++)
            {
                TablOne tablOne = new TablOne();
                tablOne.num = random.Next(min, max);
                list.Add(tablOne);
            }

            return list;

        }

        public static List<TablTwo> GenerateTableTwo(int count, int min, int max)
        {
            Random random = new Random();

            var list = new List<TablTwo>();

            for (int i = 0; i < count; i++)
            {
                TablTwo tablOne = new TablTwo();
                tablOne.num = random.Next(min, max);
                list.Add(tablOne);
            }

            return list;

        }

        public static List<TablThree> GenerateTableThree(int count, int min, int max)
        {
            Random random = new Random();

            var list = new List<TablThree>();

            for (int i = 0; i < count; i++)
            {
                TablThree tablOne = new TablThree();
                tablOne.num = random.Next(min, max);
                list.Add(tablOne);
            }

            return list;

        }
    }
}
