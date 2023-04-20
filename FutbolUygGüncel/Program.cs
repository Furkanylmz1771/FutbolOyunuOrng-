using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Futbol.Futbol;

namespace Futbol
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Futbol> takım = new List<Futbol>    // Futboldan değerler alan takım adında  dizi oluşturuldu
            {
                new Futbol("kaleci", 1),       // Takım dizisinin ilk indeksine 1  nolu kaleci eklendi
                new Defans("defans1", 2),
                new Defans("defans2", 3),
                new Defans("defans3", 4),
                new Defans("defans4", 5),
                new OrtaSaha("OrtaSaha1", 6),
                new OrtaSaha("OrtaSaha2", 7),
                new OrtaSaha("OrtaSaha3", 8),
                new OrtaSaha("OrtaSaha4", 9),
                new Forvet("Forvet1", 10),
                new Forvet("Forvet2", 11)
            };


            Random rastgele = new Random();
            int FormaNo;
            bool GolOlabilir = true;
            FormaNo = rastgele.Next(1, 12);



            for (int i = 1; i <= 3; i++)
            {
                FormaNo = rastgele.Next(1, 12);       // 12 dahil değil.
                if (!takım[FormaNo - 1].Pasver())     //  -1 = diziler 0'dan başlar.'    
                {
                    Console.WriteLine(FormaNo + "numaralı oyuncu pası yanlış");
                    GolOlabilir = false;      // Hatalı pas için
                }
                else
                {
                    Console.WriteLine(FormaNo + "numaralı oyuncu pası doğru");

                }
            }

            if (GolOlabilir = true)
            {
                if (takım[FormaNo - 1].GolVurusu())

                    Console.WriteLine("Gol oldu");

                else
                {
                    Console.WriteLine("Gol vuruşu başarısız.");

                    Console.ReadLine();


                }

            }
        }
    }
}
