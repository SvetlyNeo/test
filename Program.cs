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
            int numOfBags;
            Console.WriteLine("Сколько мешков сахара в магазине?");
            numOfBags = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfMass = new int[numOfBags];
            Console.WriteLine("Укажите массы мешков с сахаром.");
            for (int i = 0; i < numOfBags; i++)
            {
                arrayOfMass[i] = Convert.ToInt32(Console.ReadLine());
            }

            int N;
            Console.Write("Сколько кг сахара вы хотите купить?: ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Подходят мешки с инедексом {0} {1}",CheckBags(arrayOfMass, N)[0], CheckBags(arrayOfMass, N)[1]);

            Console.ReadLine();
        }

        public static int[] CheckBags(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] + array[j] == n)
                        return new int[] { i, j };

            return new int[0];
        }
    }
}
