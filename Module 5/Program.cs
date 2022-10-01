namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(PowerUp(2, 10));
            Console.WriteLine(Factorial(20));
            /*Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);*/

            Console.ReadKey();

        }
        private static int PowerUp(int N, byte pow)
        {
            if(pow < 1)
            {
                return 1;
            }
            else if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, pow -= 1);
            }
        }
        static decimal Factorial(int x) {
            if (x == 0) 
            {
            return 1;
            }
            else 
            {
            return x * Factorial(x - 1);
            }
        }
        static void Echo(string phrase, int deep) 
        {
            var modif = phrase;
            if (modif.Length > 2) {
            modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1) {
            Echo(modif, deep - 1);
            }
        }
    }
}