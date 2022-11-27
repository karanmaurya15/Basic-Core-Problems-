namespace Basic_Core_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999)
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine("{0} is a Leap Year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year", year);
                }
            }
            else
            Console.WriteLine("Enter 4 digit number year");
        }
    }
}