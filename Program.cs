//var runAsync = new RunAsyncClass();
////await runAsync.RunAsync(1000, 2000);
//Task task1 = runAsync.RunAsync("Cook rice", 100000);
//Task task2 = runAsync.RunAsync("Warm eba", 10000);
//Task task3 = runAsync.RunAsync("Make tea", 1000);
//await Task.WhenAll(task1, task2, task3);

//public class RunAsyncClass
//{
//    public async Task RunAsync(string taskName, int delayTime)
//    {
//        Console.WriteLine($"{taskName} started");
//        await Task.Delay(delayTime);
//        Console.WriteLine($"{taskName} completed after {delayTime / 1000} seconds");
//    }
//}


var stopwatch = new StopWatch();
stopwatch.Menu();

public class StopWatch
{
    public async Task PrintTime(string time, int delayTime)
    public void Menu()
    {
        while (true)
        {
            var watch = new Run();
            Console.WriteLine("Click enter key to start or any other key to end app");
            var start = Console.ReadLine()!;
            switch (start)
            {
                case "":
                    Console.WriteLine("STOPWATCH IS COUNTING....");
                    var startTime = watch.Start(DateTime.Now);
                    Console.WriteLine("Press enter key to stop");
                    var stop = Console.ReadKey()!;
                    var endTime = char.IsWhiteSpace(stop.KeyChar) ? $"The duration time is: {watch.Stop(startTime)}s. Press any key to continue" : "\nInvalid! Click any key to start stopwatch again";
                    Console.WriteLine(endTime);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default: return;
            }

        }
    }
    class Run
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; set; }
        public Run()
        {
            StartTime = DateTime.Now;
        }
        public DateTime Start(DateTime start)
        {
            StartTime = start;
            return StartTime;
        }
        public TimeSpan Stop(DateTime start)
        {
            EndTime = start;
            TimeSpan totalTime = DateTime.Now - EndTime;
            return totalTime;
        }
    }
}