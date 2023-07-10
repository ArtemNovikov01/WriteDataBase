using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.BulkExtensions;

namespace ConsoleApp1.Service
{
    public class CreateThread
    {
        public static void Run(int count)
        {
            int EqualParts = count / 10000;
            int CountIteration = count / 100000;

            List<MainTable> list = GenerateMilions.GenerateRows(count);

            List<List<MainTable>> mainTabls = Discrimenator.discrimenator(list, EqualParts);


            for (int i = 0; i < CountIteration; i++)
            {
                Console.WriteLine($"Итерация №{i}");
                var tasks = new Task[10];

                for (int j = 0; j < 10; j++)
                {

                    tasks[j] = Initialization.initialization(mainTabls[j + (i * 10)], j + 1);

                }

                Task.WaitAll(tasks);

            }
        }

        //public static async Task Update(int count, int countGenerData) 
        //{
        //    Random random = new Random();
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        Console.WriteLine("Обновление данных было начато");

        //        List<MainTable> mainTablsNew = GenerateMilions.GenerateForUppdate(count);
        //        List<MainTable> mainTabls = new();

        //        for (int i = 0;i < count; i++)
        //        {   

        //            int Id = random.Next(1, countGenerData);
        //            var mainRow = new MainTable();

        //            mainRow.Id = Id;

        //            mainRow.TableOneId = mainTablsNew[i].TableOneId;
        //            mainRow.TableTwoId = mainTablsNew[i].TableTwoId;
        //            mainRow.TableThreeId = mainTablsNew[i].TableThreeId;

        //            mainRow.numOne = mainTablsNew[i].numOne;
        //            mainRow.numTwo = mainTablsNew[i].numTwo;
        //            mainRow.numThree = mainTablsNew[i].numThree;
        //            mainRow.numFour = mainTablsNew[i].numFour;

        //            mainRow.date = mainTablsNew[i].date;

        //            mainTabls.Add(mainRow);

        //            Console.WriteLine($"Было обновлено {i} строк из{count}");
        //        }

        //        var bulkConfig = new BulkConfig { BulkCopyTimeout = 100000000 };

        //        await db.BulkUpdateAsync(mainTabls, bulkConfig);

        //        await db.SaveChangesAsync();
        //        stopwatch.Stop();
        //        Console.WriteLine($"Обновление завершенно, заняло времени {stopwatch.Elapsed}");
        //    }
        //    Task.WaitAll();
        //}

        public static void update(int count)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                Random random = new Random();

                List<MainTable> rows = read(count);
                foreach (var row in rows)
                {
                    int index1 = random.Next(1,50);
                    int index2 = random.Next(1, 50);
                    int index3 = random.Next(1, 50);

                    row.TableOneId = index1;
                    row.TableTwoId = index2;
                    row.TableThreeId = index3;

                    row.numOne += 1;
                    row.numTwo += 1;
                    row.numThree += 1;
                    row.numThree += 1;

                    
                }
                db.mainTabls.UpdateRange(rows);
                db.SaveChanges();
            }
        }

        
        public static List<MainTable> read(int count)
        {
            List<MainTable> list = new();

            using (ApplicationContext db = new ApplicationContext())
            {
                Random random = new Random();
               

                List<int> indeces = getRandomList(count); 

                    list = db.mainTabls.Where(x=>indeces.Contains(x.Id)).ToList();
                
            }

            return list;
        }

        public static List<int> getRandomList(int count)
        {
            Random a = new Random();
            List<int> randomList = new List<int>();
            int MyNumber = 0;

            

            for (int i = 0; i < count; i++)
            {
                MyNumber = a.Next(1,4000000);

                if (!randomList.Contains(MyNumber))
                    randomList.Add(MyNumber);

                else i--;
            }

            return randomList;
        }
    }
}
