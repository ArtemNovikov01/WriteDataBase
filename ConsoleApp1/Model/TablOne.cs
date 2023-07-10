using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class TablOne
    { 
        public int Id { get; set; }
        public int num { get; set; }
        public int MainTablId { get; set; }
        public List<MainTable> MainTabl { get; set; }

    }
}
