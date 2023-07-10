using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    public class Discrimenator
    {
        public static List<List<MainTable>> discrimenator(List<MainTable> list, int parts)
        {
            int listSize = list.Count;
            int partSize = (int)Math.Ceiling((double)listSize / parts);

            List<List<MainTable>> splitList = new();
            int index = 0;

            while (index < listSize)
            {
                splitList.Add(list.GetRange(index, Math.Min(partSize, listSize - index)));
                index += partSize;
            }

            return splitList;
        }
    }
}
