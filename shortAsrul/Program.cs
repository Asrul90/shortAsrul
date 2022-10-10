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
        //Deklarasi array int dengan ukuran 42
        private int[] a = new int[42];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        // FUNGSI / METHOD UNTUK MENERIMA DATA
   
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 42)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 42 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen ASRUL");
            Console.WriteLine("---------------------");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }

        // METHOD YANG DAPAT DI PANGGIL DARI OBJEK LAIN 
        public void display()
        {
            // CONSOLE WRITLINE BERFUNGSI UNTUK MENJALANGKAN LEBIH DARI 1 DATA
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element ASRUL yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int AS = 0; AS < n; AS++)
            {
                Console.WriteLine(a[AS]);
            }
            Console.WriteLine("");
        }
        public void BubbletSortArray()
        {
            for (int i = 1; i < n; i++) //For n-1 passes
            {
                //Pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya
                for (int AS = 0; AS < n - i; AS++)
                {
                    if (a[AS] > a[AS + 1]) //Jika elemen tidak dalam urutan yang benaar
                    {
                        //Tukar elemen
                        int temp;
                        temp = a[AS];
                        a[AS] = a[AS + 1];
                        a[AS + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the BubbleSort class
            Program myList = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //Pemanggilan fungsi untuk mengurutkan array
            myList.BubbletSortArray();
            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}