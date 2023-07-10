using ConsoleApp1.Model;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    public class Initialization
    {
        public static async Task initialization(List<MainTable>mainTabls, int num) 
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

           await Task.Run(async() =>
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var bulkConfig = new BulkConfig { BulkCopyTimeout = 1000000 };

                    Console.WriteLine($"Поток №{num} начал заполнение БД");
                    await db.BulkInsertAsync(mainTabls, bulkConfig);
                    await db.BulkSaveChangesAsync();
                    Console.WriteLine($"В потоке №{num} работа завершена");

                    stopwatch.Stop();

                    Console.WriteLine($"Время выполнения программы: {stopwatch.Elapsed}");
                }
            });

        }

    }
}
//List<MainTabl> mainTabls = new List<MainTabl>();

//for (int i = 0; i < 500000; i++)
//{
//    Random rnd = new Random();
//    int tablOne = rnd.Next(1, 50);
//    int tablTwo = rnd.Next(1, 50);
//    int tablThree = rnd.Next(1, 50);

//    MainTabl mainTabl = GenerateMilions.GenerateRows(tablOne, tablTwo, tablThree);
//    mainTabl.Id = i+1;

//    mainTabls.Add(mainTabl);
//    if (i % 10000 == 1)
//    {
//        Console.WriteLine($"В потоке №{num}  было создано {i} строк");
//    }
//}