using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    public class GenerateMilions
    {
        public static List<MainTable> GenerateRows(int count)
        {
            Random rnd = new Random();

            List<MainTable> mainTabls = new List<MainTable>();
            for (int i = 0; i < count; i++)
            {
                int tablOne = rnd.Next(1, 50);
                int tablTwo = rnd.Next(1, 50);
                int tablThree = rnd.Next(1, 50);

                MainTable mainTabl = new MainTable();

                mainTabl.Id = i + 1;

                mainTabl.TableOneId = tablOne;
                mainTabl.TableTwoId = tablTwo;
                mainTabl.TableThreeId = tablThree;

                mainTabl.numOne = GenerateNums.GenerateDec();
                mainTabl.numTwo = GenerateNums.GenerateDec();
                mainTabl.numThree = GenerateNums.GenerateDec();
                mainTabl.numFour = GenerateNums.GenerateDec();

                mainTabl.date = GenerateNums.GenerateDate();

                mainTabls.Add(mainTabl);

                if (i % 100000 == 1)
                {
                    Console.WriteLine($"Было создано {i} строк");
                }
            }
            return mainTabls;
        }

        public static List<MainTable> GenerateForUppdate(int count)
        {
            Random rnd = new Random();

            List<MainTable> mainTabls = new List<MainTable>();
            for (int i = 0; i < count; i++)
            {
                int tablOne = rnd.Next(1, 50);
                int tablTwo = rnd.Next(1, 50);
                int tablThree = rnd.Next(1, 50);

                MainTable mainTabl = new MainTable();

                mainTabl.TableOneId = tablOne;
                mainTabl.TableTwoId = tablTwo;
                mainTabl.TableThreeId = tablThree;

                mainTabl.numOne = GenerateNums.GenerateDec();
                mainTabl.numTwo = GenerateNums.GenerateDec();
                mainTabl.numThree = GenerateNums.GenerateDec();
                mainTabl.numFour = GenerateNums.GenerateDec();

                mainTabl.date = GenerateNums.GenerateDate();

                mainTabls.Add(mainTabl);

                if (i % 100000 == 1)
                {
                    Console.WriteLine($"Было создано {i} строк");
                }
            }
            return mainTabls;
        }
    }
}
