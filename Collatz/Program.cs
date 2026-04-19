namespace Collatz
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var inputstring = Console.ReadLine();
            if (inputstring != null)
            {
                int input = int.Parse(inputstring);
                int output = 0;
                int x = input;
                
                while (x != 1)
                {
                    if (x % 2 == 0)
                    {
                        x = x / 2;
                    }
                    else
                    {
                        x = 3 * x + 1;
                    }
                    output++;
                }
                Console.WriteLine(output);
            }
        }
    }
}