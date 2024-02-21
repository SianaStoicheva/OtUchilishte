using System.Collections.Generic;

namespace ListEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
          //Otpecatvane na funkciite

            Console.WriteLine("Chetni" + string.Join(" ",GetEvenElement(list)));
            Console.WriteLine("Nechetni" + string.Join(" ",GetOddElement(list)));
        }
        static List<int> GetEvenElement (List<int> intput) 
        {
            List<int> listEven = new List<int>();
            for (int i = 0; i < intput.Count; i++)
            {
                if (intput[i] % 2 == 0)
                {
                    listEven.Add(intput[i]);
                }
               
            }
            return listEven;
        } 
        static List<int> GetOddElement (List<int> intput)
        {
            List<int> listOdd = new List<int>();
            for (int i = 0; i < intput.Count; i++)
            {
                if (intput[i] % 2 != 0)
                {
                    listOdd.Add(intput[i]);
                }

            }
            return listOdd;
        }

    }
}
