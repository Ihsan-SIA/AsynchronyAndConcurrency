var runAsync = new RunAsyncClass();
//await runAsync.RunAsync(1000, 2000);
Task task1 = runAsync.RunAsync("Cook rice", 100000);
Task task2 = runAsync.RunAsync("Warm eba", 10000);
Task task3 = runAsync.RunAsync("Make tea", 1000);
await Task.WhenAll(task1, task2, task3);

public class DataFetcher
{
    public async Task<string> GetDataFromApiAsync(int delayMilliseconds)
    {
        await Task.Delay(delayMilliseconds);
        return "Data from API";
    }
    public async Task SaveDataToDbAsync(string data, int delayMilliseconds)
    {
        await Task.Delay(delayMilliseconds);
        Console.WriteLine($"Saved: {data}");
    }
}
public class RunAsyncClass
{
    public async Task RunAsync(string taskName, int delayTime)
    {
        Console.WriteLine($"{taskName} started");
        await Task.Delay(delayTime);
        Console.WriteLine($"{taskName} completed after {delayTime/1000} seconds");
        //var fetcher = new DataFetcher();
        //string data = await fetcher.GetDataFromApiAsync(getTime);
        //await fetcher.SaveDataToDbAsync(data, saveTime);
    }
}