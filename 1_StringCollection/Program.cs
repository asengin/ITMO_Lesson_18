using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_StringCollection
{
    class Program
    {
        /* Условие задачи:
         * Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
         * Проверить, корректно ли в ней расставлены скобки.
         */
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string inpString = Console.ReadLine();
            Console.WriteLine(ChekString(inpString));

            Console.ReadKey();
        }

        static string ChekString(string inpString)
        {
            Dictionary<char, char> keys = new Dictionary<char, char>
            {
                {'(',')' },
                {'[',']' },
                {'{','}' },
            };
            Stack<char> stack = new Stack<char>();

            foreach (char s in inpString)
            {
                if (s == '(' || s == '[' || s == '{')
                    stack.Push(keys[s]);
                if (s == ')' || s == ']' || s == '}')
                {
                    if (stack.Count == 0)
                        return "Закрытых скобок больше чем открытых";
                    if (stack.Pop() != s)
                        return "Закрытая скобка не соответствует открытой";
                }
            }
            return stack.Count == 0 ? "Скобки расставлены корректно" : "Открытых скобок больше чем закрытых";
        }
    }
}
