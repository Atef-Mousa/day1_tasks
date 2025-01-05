namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpetPrice = 25;
            int largeCarpetPrice = 35;
            double taxRate = 0.06;
            const int validDays = 30 ;
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Number of small carpets : ");
            int smallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets : ");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: 25");
            Console.WriteLine("Price per large room: 35");

            int cost = ((smallCarpetPrice * smallCarpet) + (largeCarpetPrice * largeCarpet));
            double tax = (cost * taxRate);
            double costAfterTax = cost + tax ;

            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax : ${tax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${costAfterTax}");
            Console.WriteLine($"This estimate is valid for {validDays} days");
        }
    }
}
