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
            PerfectNumber perfectNumber = new PerfectNumber(n);
            //perfectNumber.Perfect_Number(n);
        }
    }
}