namespace W_2_l_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Year;
            Console.WriteLine("Podaj rok");

            Year = int.Parse(Console.ReadLine());

            if (Year % 4 == 0)
            {
                Console.WriteLine(Year + " jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine(Year + " rok nie jest rokiem przestępnym");
            }
        }
    }
}