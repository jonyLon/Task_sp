namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 1000;

            int counter = 0;
            var t = Task.Run(() =>
            {
                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                    {
                        counter++;
                        Console.WriteLine("Prime: " + i);
                    }
                }
            });
            
            Task.WaitAll(t);
            Console.WriteLine($"Prime count: {counter}");

            //Parallel.For(10, 100, PrintPrime);
            //Console.ReadLine();
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var limit = Math.Sqrt(number);

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;
        }
        //static void PrintPrime(int number)
        //{

        //    if (IsPrime(number))
        //    {
        //        Console.WriteLine(number);
        //    }
        //}
    }
}