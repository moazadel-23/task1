namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter smallCarpet count ");
            int smallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter largeCarpet count ");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());

            double tax = 0.06; // 6%
            double cost = (smallCarpet * 3) + (largeCarpet * 1);
            double totalTax = tax * cost;
            double totalEstimate = cost + totalTax;


            Console.WriteLine($"smallCarpet of price = {smallCarpet * 3} $");
            Console.WriteLine($"largeCarpet of price = {largeCarpet * 1} $");
            Console.WriteLine($"Cost = {cost} $");
            Console.WriteLine($"totalTax = {tax * cost} $");
            Console.WriteLine($"totalEstimate = {totalEstimate} $");
            Console.WriteLine("this estimate is valid for 30 days");

        }
    }
}
