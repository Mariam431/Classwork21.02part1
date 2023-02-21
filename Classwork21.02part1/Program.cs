namespace Classwork21._02part1
{

    internal class Program
    {
        static int OutMethod(out int t)
        {

             t = int.Parse(Console.ReadLine());
            return t*t;
        }
        static void OutMethod2(out int a)
        {

            a = int.Parse(Console.ReadLine());
            a = a * a;
            Console.WriteLine(a);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(OutMethod(out int t));
            OutMethod2(out int a);

        }

    }
}