using ConsoleApp1.Model;
using ConsoleApp1.Service;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

int countGenerData = 4000000;
int countUpdateData = 200000;

using (ApplicationContext db = new ApplicationContext())
    {

       // db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

       // GenerateDate.GenerateTableOne(50, 10, 60).ForEach(b => db.tablOne.Add(b));
        //GenerateDate.GenerateTableTwo(50, 10, 60).ForEach(b => db.tablTwo.Add(b));
        //GenerateDate.GenerateTableThree(50, 10, 60).ForEach(b => db.tablThree.Add(b));
        //await db.SaveChangesAsync();
        
    }

    //reateThread.Run(countGenerData);

//await CreateThread.Update(countUpdateData, countGenerData);
CreateThread.update(200000);

stopwatch.Stop();

Console.WriteLine($"Время выполнения программы: {stopwatch.Elapsed}");