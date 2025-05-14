var runAsync = new RunAsyncClass();
runAsync.RunAsync();
public class DataFetcher
{
    public async Task<string> GetDataFromApiAsync()
    {
        await Task.Delay(2000);
        return "Data from API";
    }
    public async Task SaveDataToDbAsync(string data)
    {
        await Task.Delay(1000);
        Console.WriteLine($"Saved: {data}");
    }
}
public class RunAsyncClass
{
    public async Task RunAsync()
    {
        var fetcher = new DataFetcher();
        string data = await fetcher.GetDataFromApiAsync();
        await fetcher.SaveDataToDbAsync(data);
    }
}