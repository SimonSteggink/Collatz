namespace Collatz
{
    internal static class Program
    {
        private static void Main()
        {
            for (var i = 0; i < 4; i++){
                var userInput = Console.ReadLine();
                if (userInput == null) continue;
                var input = int.Parse(userInput);
                var output = 0;
                var x = input;
                
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