using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class Futbol
    {
        Random Randomr = new Random();

        protected string AdSoyad;
        protected int FormNo;
        protected int Hız;
        protected int Dayanıklılık;
        protected int Pas, Şut, Yetenek;
        protected int Kararlılık;
        protected int DoğalForm;
        protected int Şans;
        public Futbol(string AdSoyad, int FormNo)       // Kurucu metod oluşturuldu
        {

            this.AdSoyad = AdSoyad;
            this.FormNo = FormNo;

            Hız = Randomr.Next(50, 100);             // 50 100 arasında rastgele sayı verir, 100 dahil değil.
            Dayanıklılık = Randomr.Next(50, 100);
            Pas = Randomr.Next(50, 100);
            Şut = Randomr.Next(50, 100);
            Yetenek = Randomr.Next(50, 100);
            Kararlılık = Randomr.Next(50, 100);
            DoğalForm = Randomr.Next(50, 100);
            Şans = Randomr.Next(50, 100);

        }

        public Futbol() { }


        public virtual Boolean Pasver()
        {

            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayanıklılık * 0.1 + DoğalForm * 0.1 + Şans * 0.2);

            if (PasSkor > 60)

                return true;

            else

                return false;


        }

        public virtual Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Şut * 0.2 + DoğalForm * 0.1 + Kararlılık * 0.2 + Hız * 0.1 + Şans * 0.2);

            if (GolSkor > 70)
                return true;
            else
                return false;
        }




        public class Defans : Futbol
        {
            private int PozisyonAlma;
            private int Kafa;
            private int Sıcrama;
            public Defans(string AdSoyad, int FormNo)
            {
                this.AdSoyad = AdSoyad;
                this.FormNo = FormNo;
                Hız = Randomr.Next(50, 90);
                Dayanıklılık = Randomr.Next(50, 100);
                Pas = Randomr.Next(50, 100);
                Şut = Randomr.Next(50, 100);
                Yetenek = Randomr.Next(50, 100);
                Kararlılık = Randomr.Next(50, 100);
                DoğalForm = Randomr.Next(50, 100);
                Şans = Randomr.Next(50, 100);

            }

            public override Boolean Pasver()
            {

                int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayanıklılık * 0.1 + PozisyonAlma * 0.1 + DoğalForm * 0.1 + Şans * 0.2);

                if (PasSkor > 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


        }
        public class OrtaSaha : Futbol
        {
            private int UzunTop;
            private int İlkDokunuş;
            private int Uretkenlik;
            private int TopSurme;
            private int OzelYetenek;
            public OrtaSaha(string AdSoyad, int FormNo)
            {
                this.AdSoyad = AdSoyad;
                this.FormNo = FormNo;
                Hız = Randomr.Next(50, 90);
                Dayanıklılık = Randomr.Next(50, 100);
                Pas = Randomr.Next(50, 100);
                Şut = Randomr.Next(50, 100);
                Yetenek = Randomr.Next(50, 100);
                Kararlılık = Randomr.Next(50, 100);
                DoğalForm = Randomr.Next(50, 100);
                Şans = Randomr.Next(50, 100);
            }

            public virtual Boolean Pasver()     // Virtual metotlar Inheritance (Kalıtım) yoluyla aktarıldıkları sınıfların
                                                // içerisinden override edilerek değiştirilebilirler.
                                                // Eğer override edilmezlerse temel sınıf içerisinde tanımladıkları şekilde çalışırlar.
            {

                int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayanıklılık * 0.1 + DoğalForm * 0.1 + Şans * 0.2);

                if (PasSkor > 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }


        }

        public class Forvet : Futbol
        {
            private int Bıtırıcılık;
            private int IlkDokunus;
            private int Kafa;
            private int OzelYetenek;
            private int Soğukkanlılık;
            public Forvet(string AdSoyad, int FormNo)
            {
                this.AdSoyad = AdSoyad;
                this.FormNo = FormNo;
                Hız = Randomr.Next(50, 90);
                Dayanıklılık = Randomr.Next(50, 100);
                Pas = Randomr.Next(50, 100);
                Şut = Randomr.Next(50, 100);
                Yetenek = Randomr.Next(50, 100);
                Kararlılık = Randomr.Next(50, 100);
                DoğalForm = Randomr.Next(50, 100);
                Şans = Randomr.Next(50, 100);
            }


            public virtual Boolean Pasver()
            {

                int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayanıklılık * 0.1 + DoğalForm * 0.1 + Şans * 0.2);

                if (PasSkor > 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
    }
}
