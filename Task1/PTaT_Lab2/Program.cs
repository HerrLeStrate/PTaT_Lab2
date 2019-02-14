using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTaT_Lab2
{
    class Program
    {

        public static Int64 getLong()
        {
            string input = Console.ReadLine();
            Int64 result;
            if(!Int64.TryParse(input, out result))
            {
                Console.WriteLine("Неккоректный ввод. Попробуйте ещё: ");
                return getLong();
            }
            return result;
        }

        public static Int64 getMaxBinaryResult(Int64 value)
        {
            Int64 result = 0;
            while (value % 2 == 0) { result++; value /= 2; }
            return result;
        }

        static void Main(string[] args)
        {
            Int64 a, b;

            Console.WriteLine("Введите левую границу: ");
            a = getLong();

            Console.WriteLine("Введите правую границу: ");
            b = getLong();

            if (a > b)
            {
                Int64 t = a;
                a = b;
                b = t;
            }

            Int64 ans = 0;
            for(Int64 i = a; i <= b; i++)
            {
                ans += getMaxBinaryResult(i);
            }

            Console.WriteLine("Ответ: " + ans);
            Console.Read();
        }
    }
}
