using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace shortAsrul
{

    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20]

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // fungsi / methoad untuk menerima masukan
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang di simpang pada array
            while (true)
            {
                Console.Write("masukkan banyak elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maxsimal 20 elemen.\n ");
            }
            Console.WriteLine("");
            Console.ReadLine(" --------------- ");
            Console.WriteLine(" masukkan elemen array ");
            Console.WriteLine(" -------------- ");

            // pengguna memasukkan elemen pada array
            for (int i = 0; i < 20; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

            {
              PublicKey void display()
            }
            // menmpilkan array yang tersusun
            Console.WriteLine("");
            Console.ReadLine(" --------------- ");
            Console.WriteLine(" elemen array yang telah tersusun ");
            Console.WriteLine(" -------------- ");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
        }
    }
}
