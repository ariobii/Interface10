using System;

using Newtonsoft.Json;

namespace Interface
{
    class ToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("Hasil Konversi ke Json :\n");
            Console.WriteLine(json);
        }
    }
}
