using FizzBuzz;
using System.Diagnostics;

List<long> list = new();
int sims = 100000;
int countTo = 100;
Stopwatch sw = new();
Timers timers = new();
FizzBuzzSingle single = new();
FizzBuzzMultiThread threaded = new(); // 5threads at default
FizzBuzzRecursive recursive = new();
FizzBuzzSwitchCase switchCase = new();
FizzBuzzLINQ linq = new();

for (int i = 0; i < sims; i++)
{
    sw.Start();
    single.Play(true, countTo);
    sw.Stop();
    timers.single.Add(sw.ElapsedTicks);
    sw.Restart();
}


for (int i = 0; i < sims; i++)
{
    sw.Start();
    threaded.Play(true, countTo);
    sw.Stop();
    timers.threaded.Add(sw.ElapsedTicks);
    sw.Restart();
}

//    sw.Start();
//    recursive.Play();
//    sw.Stop();
//    timers.recursive.Add(sw.ElapsedMilliseconds);
//    sw.Restart();

    //    sw.Start();
    //    switchCase.Play();
    //    sw.Stop();
    //    timers.switchCase.Add(sw.ElapsedMilliseconds);
    //    sw.Restart();

    //    sw.Start();
    //    linq.Play();
    //    sw.Stop();
    //    timers.linq.Add(sw.ElapsedMilliseconds);
    //    sw.Restart();

sw.Stop();

Console.WriteLine(timers.single.Average());
Console.WriteLine(timers.threaded.Average());
//Console.WriteLine(timers.recursive.Average());
//Console.WriteLine(timers.switchCase.Average());
//Console.WriteLine(timers.linq.Average());

Console.WriteLine();

Console.WriteLine(timers.single.Min());
Console.WriteLine(timers.threaded.Min());
//Console.WriteLine(timers.recursive.Min());
//Console.WriteLine(timers.switchCase.Min());
//Console.WriteLine(timers.linq.Min());

Console.WriteLine();

Console.WriteLine(timers.single.Max());
Console.WriteLine(timers.threaded.Max());
//Console.WriteLine(timers.recursive.Max());
//Console.WriteLine(timers.switchCase.Max());
//Console.WriteLine(timers.linq.Max());

internal class Timers
{
    public List<long> single = new();
    public List<long> threaded = new();
    public List<long> recursive = new();
    public List<long> switchCase = new();
    public List<long> linq = new();
}