using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class MainTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int TableOneId { get; set; }
        public int TableTwoId { get; set; }
        public int TableThreeId { get; set; }
        public decimal numOne { get; set; }
        public decimal numTwo { get; set; }
        public decimal numThree { get; set; }
        public decimal numFour { get; set; }
        public Int64 date { get; set; }
        [ForeignKey("TableOneId")]
        public TablOne tablOne { get; set; }
        [ForeignKey("TableTwoId")]
        public TablTwo tablTwo { get;set; }
        [ForeignKey("TableThreeId")]
        public TablThree tablThree { get;set; }
    }
}
