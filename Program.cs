
internal class Program
{
    private static async Task Main(string[] args)
    {
        Task<int> result = Result();
        //await Task.Delay(1000);
        var final = await result;
        Task task1 = AMeth();
        JustPrint();
    }
    static async Task<int> Result()
    {
        int result = 2 + 2;
        Console.WriteLine("Getting result, please wait....");
        await Task.Delay(3000);
        Console.WriteLine(result);
        return result;
    }
    static async Task AMeth()
    {
        Console.WriteLine("This is AMeth");
        await Task.Delay(1000);
        Console.WriteLine("You we just waited 1 second");
    }
    static void JustPrint()
    {
        Console.WriteLine("The other method has gone to get results of 2 + 2");
    }

}