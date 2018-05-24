using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            var listOfMass = new List<int>();
            Console.WriteLine("Укажите массы мешков с сахаром.");
            string inputData = Console.ReadLine().ToString();
            foreach (var n in inputData.Split(';', ',', '\n', '\r', '\t'))
            {
                int.TryParse(n, out k);
                
                listOfMass.Add(k);
            }

            int N;
            Console.Write("Сколько кг сахара вы хотите купить?: ");
            int.TryParse(Console.ReadLine(), out N);
            foreach (var l in CheckBags(listOfMass, N))
            {
                Console.WriteLine("Подходят мешки с индексами: {0}", l);
            }

            Console.ReadLine();
        }

        public static List<string> CheckBags(List<int> list, int n)
        {
            var lststr = new List<string>();
            for (int i = 0; i < list.Count; i++)
                for (int j = i + 1; j < list.Count; j++)
                    if (list[i] + list[j] == n)
                        lststr.Add(i + "," + j);

            return lststr;
        }
    }
}
