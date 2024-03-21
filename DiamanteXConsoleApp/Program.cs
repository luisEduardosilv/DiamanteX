namespace DiamanteXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número ímpar:");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("O número informado não é ímpar. Por favor, informe um número ímpar.");
                return;
            }

            int metade = n / 2;

            for (int i = 0; i < metade; i++)
            {
                for (int j = 0; j < metade - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            for (int i = metade; i >= 0; i--)
            {
                for (int j = 0; j < metade - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            }
    }
}
