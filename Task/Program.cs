namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(() => Console.WriteLine(DateTime.Now.ToString()));
            task.Start();
            Task.Factory.StartNew(() => Console.WriteLine(DateTime.Now.ToString()));
            Task.Run(() => Console.WriteLine(DateTime.Now.ToString()));





            Task.WaitAll(task);




        }
    }
}