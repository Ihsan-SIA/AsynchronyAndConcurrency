
internal class Program
{
    private static async Task Main(string[] args)
    {
        //Task<int> result = Result();
        //await Task.Delay(1000);
        //JustPrint();
    }
    //static async Task<int> Result()
    //{
    //    int result = 2 + 2;
    //    Console.WriteLine("Getting result, please wait....");
    //    await Task.Delay(3000);
    //    return result;
    //}
    //static void JustPrint()
    //{
    //    Console.WriteLine("The other method has gone to get results of 2 + 2");
    //}
    

    static async void LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");

    }

    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }
}