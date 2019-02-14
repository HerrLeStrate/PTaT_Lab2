using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTaT_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder stringer = new StringBuilder(input);
            for(int i = 0; i < input.Length; i++)
            {
                if (stringer[i] == ' ') continue;
                stringer[i] = (stringer[i] == 'z') ? stringer[i] = 'a' : stringer[i] = (char)((int)(stringer[i]) + 1);
            }
            input = stringer.ToString();
            Console.WriteLine(input);
            Console.Read();
        }
    }
}
