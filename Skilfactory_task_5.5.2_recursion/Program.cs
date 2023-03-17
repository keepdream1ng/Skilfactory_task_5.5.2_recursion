namespace Skilfactory_task_5._5._2_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter phrase for echo/ Введите фразу для эха");
            string phrase = Console.ReadLine();

            Console.WriteLine("Enter echo deepness/ Введите глубину эха");
            byte deepness = Byte.Parse(Console.ReadLine());

            Echo(phrase, deepness);
        }

        static void Echo(string phrase, byte deepness)
        {
            if (deepness > 0) {
                phrase = phrase.Remove(0, 2);
                Console.WriteLine($"...{phrase}");
                Echo(phrase, --deepness);
            }

        }
    }
}