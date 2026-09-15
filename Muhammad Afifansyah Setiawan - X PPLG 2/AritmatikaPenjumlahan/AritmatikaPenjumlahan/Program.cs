using System;

namespace AritmatikaPenjumlahan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel, hasil = 0;

            Console.Write("mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("appel = ");
            apel = int.Parse(Console.ReadLine());

            // opersasi penjumlahan dengan operator +
            hasil = mangga + apel;

            Console.WriteLine($"Hasil mangga + appel = {hasil}");
        }
    }
}
