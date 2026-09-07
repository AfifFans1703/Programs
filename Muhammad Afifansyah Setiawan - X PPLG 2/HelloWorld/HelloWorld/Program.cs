using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ulangProgram = true;
            while (ulangProgram)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("Ini Adalah Contoh Perbedaan Write & WriteLine!");
                Console.WriteLine("==================================================");
                Console.WriteLine("\nTekan tombol W untuk Write, tekan tombol L untuk WriteLine!");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();

                if (input.Key == ConsoleKey.W)
                {
                    Console.Write("Pemahaman Singkat :");
                    Console.WriteLine("Teks masih dilanjut/ditulis pada baris yang sama");
                    Console.WriteLine("Contoh penggunaan pada masukkan nama");
                    Console.Write("Masukkan Nama : ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Nama (String) ditulis disebelah Teks sebelumnya, tidak ganti baris");
                    Thread.Sleep(1200);
                    Console.WriteLine("Contoh Lain");
                    Console.Write("Buatlah kalimat sapaan tanpa salam & tanpa perkenalan");
                    Console.WriteLine();
                    Console.WriteLine("(Misal, Halo semuanya/Salam kenal!)\n");
                    Thread.Sleep(1200);
                    Console.WriteLine("Ucapan : ");
                    string ucapan = Console.ReadLine();
                    Console.Write("Halo! ");
                    Thread.Sleep(1200);
                    Console.Write("Nama saya ");
                    Thread.Sleep(1200);
                    Console.Write("" + nama + "! ");
                    Thread.Sleep(1200);
                    Console.Write("" + ucapan + "");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("Begitulah Write, menampilkan teks disamping & setelah teks sebelumnya");
                    Thread.Sleep(2500);
                    Console.WriteLine("Tidak/Bukan di bawahnya/di baris baru");
                    Console.WriteLine();
                }
                else if (input.Key == ConsoleKey.L)
                {
                    Console.WriteLine("Teks berada di baris bawahnya/baris baru");
                    Console.WriteLine("Contoh penggunaan pada masukkan nama");
                    Console.WriteLine("Masukkan Nama :");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Nama (String) yang diketik berada di baris bawah teks sebelumnya");
                    Thread.Sleep(1200);
                    Console.WriteLine("Contoh Lain");
                    Console.WriteLine("Buatlah identitas diri!");
                    Console.WriteLine("Tekan Enter setelah memasukkan satu kategori identitas!");
                    Thread.Sleep(1200);
                    Console.WriteLine("Misal, Afif (Enter), 18 (Enter), X (Enter), PPLG (Enter), 2 (Enter)");
                    Thread.Sleep(1200);
                    Console.WriteLine("Identitas urut :");
                    Console.WriteLine("Nama :");
                    Console.WriteLine("" + nama + "");
                    Console.WriteLine("Ganti nama? Tekan Y (Yes) atau N (No)");

                    while (true)
                    {
                        ConsoleKeyInfo input0 = Console.ReadKey(true);
                        if (input0.Key == ConsoleKey.Y)
                        {
                            Console.Write("Masukkan nama baru: ");
                            nama = Console.ReadLine();
                            break;
                        }
                        else if (input0.Key == ConsoleKey.N)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Masukkan tidak valid! Tekan Y atau N.");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Nomor Absen :");
                    string absen = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Kelas (X, XI, atau XII");
                    string kelas = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Jurusan :");
                    string jurusan = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("kelas ke :");
                    string kategori = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Wait...");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("Nama : " + nama + " ");
                    Console.WriteLine("Absen : " + absen + " ");
                    Console.WriteLine("Kelas : " + kelas + " ");
                    Console.Write(""+ jurusan +" ");
                    Console.Write("" + kategori + " ");
                    Console.WriteLine();
                    Console.WriteLine("Selesai...");
                    while (true)
                    {

                        Console.WriteLine("Ulangi...? Tekan Y (Yes) atau N (No)");
                        ConsoleKeyInfo input1 = Console.ReadKey(true);
                        Console.WriteLine();

                        if (input1.Key == ConsoleKey.Y)
                        {
                            ulangProgram = true;
                            break;
                        }
                        else if (input1.Key == ConsoleKey.N)
                        {
                            ulangProgram = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Masukkan tidak valid!");
                            Console.WriteLine("Tekan Enter untuk ulang...");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Masukkan tidak valid!");
                    Console.WriteLine("Tekan Enter untuk ulang...");
                    Console.ReadLine();
                }
                Console.WriteLine();
                Console.WriteLine("Program akan ditutup, tekan Enter...");
                break;
            }
        }
    }
}
