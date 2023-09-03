namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //FibonacciSeries fibonacciSeries = new FibonacciSeries();
            int n= Convert.ToInt32(Console.ReadLine());
            //fibonacciSeries.fibonacciSeries(n);
            // PerfectNumber perfectNumber = new PerfectNumber(n);
            //PrimeNumber primeNumber = new PrimeNumber();
            //bool flag = primeNumber.IsPrimeNumber(n);
            //Console.WriteLine(n + " Is prime Number "+flag);
            ReverseNumber reverseNumber = new ReverseNumber();
            int reversedVal = reverseNumber.reversedNumber(n);
            Console.WriteLine("Reversing the number " + n + " is " + reversedVal);
        }
    }
}