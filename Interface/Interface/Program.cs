using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IConvertObject convert;

            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "18.11.2279";
            mhs.nama = "Aulia Ariobimo";
            mhs.email = "aulia.05@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi :");
            Console.WriteLine("1. JSON");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. CSV\n");

            Console.Write("Nomor Format Data [1...3] : ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            if (nomorFormatData == 1)
                convert = new ToJson();
            else if (nomorFormatData == 2)
                convert = new ToXml();
            else if (nomorFormatData == 3)
                convert = new ToCsv();
            else
            {
                Console.WriteLine("\nInput Salah\n");
                return;
            }

            convert.Convert(mhs);
        }
    }
}
