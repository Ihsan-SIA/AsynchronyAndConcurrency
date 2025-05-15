internal class Program
{
    private static async void Main(string[] args)
    {
        LongProcess();

        ShortProcess();
    }


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
