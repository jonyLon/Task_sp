using System.Threading.Channels;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            Task.Factory.StartNew(() =>
                Console.WriteLine(arr.Max())
            );
            Task.Factory.StartNew(() => Console.WriteLine(arr.Min()));
            Task.Factory.StartNew(() => Console.WriteLine(arr.Average()));
            Task.Factory.StartNew(() => Console.WriteLine(arr.Sum()));


            Console.ReadLine();

        }

    }
}