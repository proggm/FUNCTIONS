using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intent = new int[7];
            Console.WriteLine(Functions(GenerationArray(intent)));
            Console.ReadKey();
        }
        public static int[] GenerationArray(int[] array)
        {
            Random ran = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(-100, 100);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }
        static string Functions(int[] first)
        {
            int multi = 1;
            int abd = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > 0)
                {
                    abd += first[i];
                }
                if (first[i] < 0)
                {
                    multi = multi * first[i];
                }
            }
                return$"Сумма: {abd} и произведение: {multi}";

            
         
        }
    }
}
