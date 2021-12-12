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
            Console.WriteLine("Masukkan Nilai N");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N >= 1 || N <= 10)
            {
                for (int i = N; i > 0; i--)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah induknya", i);
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggalah {1}", i, i - 1);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nilai ga boleh Dibawah 0 atau diatas 10");
            }
        }
    }
}
