using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTaT_Lab2
{
    class Program
    {
        public static void swap(ref string src, int a, int b)
        {
            StringBuilder stringBuilder = new StringBuilder(src);
            char s = stringBuilder[a];
            stringBuilder[a] = stringBuilder[b];
            stringBuilder[b] = s;
            src = stringBuilder.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter string: ");
            string input = Console.ReadLine();
            Random seed = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                Random rnd = new Random(seed.Next());
                swap(ref input, i, rnd.Next(input.Length));
            }

            Console.WriteLine("New string: " + input);
            Console.Read();
        }
    }
}
