LongProcess();

ShortProcess();


static async void LongProcess()
{
    async Task DoSomn()
    {
        Console.WriteLine("Do something");
    }
    Console.WriteLine("LongProcess Started");

    await DoSomn();
    //await Task.Delay(4000); // hold execution for 4 seconds 

    Console.WriteLine("LongProcess Completed");

}

static void ShortProcess()
{
    Console.WriteLine("ShortProcess Started");

    //do something here

    Console.WriteLine("ShortProcess Completed");
}