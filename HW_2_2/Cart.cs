using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    internal class Cart
    {
        public static int[] StringRead()
        {
            string reader = Console.ReadLine();
            string[] textNumbers = reader.Split(' ');
            int[] numbers = new int[textNumbers.Length];
            for (int i = 0; i < textNumbers.Length; i++)
            {
                numbers[i] = int.Parse(textNumbers[i]) - 1;

            }
            return numbers;
        }

        public static string[] GoodsInCart() 
        {
            int[] numbers = StringRead();
            string[] result = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = Goods._goodsList[numbers[i]];
                Console.WriteLine(result[i]);
            }
            return result;
        }
    }
}
