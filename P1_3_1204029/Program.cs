using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("ANAK AYAM TURUN  ");


            int ja = Convert.ToInt16(Console.ReadLine());

            int aym = ja;

            for (int i = ja; i > 1; i--)
            {
                Console.WriteLine("Anak ayam turunlah " + ja-- + ",  mati satu tinggallah " + ja);
            }
            Console.WriteLine("Anak ayam turunlah " + ja + ",  mati satu tinggallah induknya ");

        }
    }
}
