namespace Basic_Core_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of times to flip coin");
            double num = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double headCount = 0, tailCount = 0;
            for (int i = 0; i < num; i++)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Tails :" + tailCount);
            Console.WriteLine("Head :" + headCount);
            headCount *= (100 / num);
            tailCount *= (100 / num);
            Console.WriteLine("The Percentage of Heads vs Tails is {0}% and {1}%", headCount, tailCount);

        }
    }
}