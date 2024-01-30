using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Uygulamam
{
     class Futbol
    {
        public Random rastgelesayi = new Random();
        protected string AdSoyad;
        protected int Formano;
        protected int Hiz;
        protected int Dayaniklilik;
        protected int Pas;
        protected int Sut;
        protected int Yetenek;
        protected int Kararlilik;
        protected int Dogalform;
        protected int Sans;
        public Futbol ( string Adsoyad , int Formano)
        {
            Hiz = rastgelesayi.Next(50 , 100);
            Dayaniklilik = rastgelesayi.Next(50, 100);
            Pas = rastgelesayi.Next(50, 100);
            Sut = rastgelesayi.Next(50, 100);
            Yetenek = rastgelesayi.Next(50, 100);
            Kararlilik = rastgelesayi.Next(50, 100);
            Dogalform = rastgelesayi.Next(50, 100);
            Sans = rastgelesayi.Next(50, 100);
        }
        public Futbol()
        {

        }



        public virtual Boolean Pasver()
        {
            int Passkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + Dogalform * 0.1 + Sans * 0.2);
            if (Passkor > 70)
            {
                return true;
            }

            else
            {
                return false;

            }
        }







        public virtual Boolean Golvurusu()
        {
            int Golskor = Convert.ToInt32(Yetenek*0.3 + Sut*0.2 + Kararlilik*0.2 + Dogalform*0.1 + Sans*0.2);
            if (Golskor > 70)
            {
                return true;

            }
            else
            {
                return false;

            }

        }



    }
    class Defans : Futbol
    {
        private int Pozisyonalma;
        private int kafa;
        private int sicrama;
        public Defans(string Adsoyad, int Formano)
        {
            this.AdSoyad = Adsoyad;
            this.Formano = Formano;

            Hiz = rastgelesayi.Next(50, 90);
            Dayaniklilik = rastgelesayi.Next(50, 90);
            Pas = rastgelesayi.Next(50, 90);
            Sut = rastgelesayi.Next(50, 90);
            Yetenek = rastgelesayi.Next(50, 90);
            Kararlilik = rastgelesayi.Next(50, 90);
            Dogalform = rastgelesayi.Next(50, 90);
            Sans = rastgelesayi.Next(50, 90);
            Pozisyonalma = rastgelesayi.Next(50, 90);
            kafa = rastgelesayi.Next(50, 90);
            sicrama = rastgelesayi.Next(50, 90);
        }
        public Defans()
        {

        }


        public override Boolean Pasver()
        {
            int Passkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + Dogalform * 0.1 + Pozisyonalma * 0.1 + Sans * 0.2);
            if (Passkor > 80)
            {
                return true;
            }

            else
            {
                return false;

            }
        }




        public override Boolean Golvurusu()
        {
            int Golskor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + Hiz * 0.1 + Dogalform * 0.1 + Sans * 0.2);
            if (Golskor > 80)
            {
                return true;

            }
            else
            {
                return false;

            }


        }
    }

        class Ortasaha : Futbol
        {
            private int Uzuntop;
            private int Ilkdokunus;
            private int Uretkenlik;
            private int Ozelyetenek;
            public Ortasaha(string Adsoyad, int Formano)
            {
                this.AdSoyad = Adsoyad;
                this.Formano = Formano;

                Hiz = rastgelesayi.Next(60, 100);
                Dayaniklilik = rastgelesayi.Next(60, 100);
                Pas = rastgelesayi.Next(60, 100);
                Sut = rastgelesayi.Next(60, 100);
                Yetenek = rastgelesayi.Next(60, 100);
                Kararlilik = rastgelesayi.Next(60, 100);
                Dogalform = rastgelesayi.Next(60, 100);
                Sans = rastgelesayi.Next(60, 100);
                Uzuntop = rastgelesayi.Next(60, 100);
                Ilkdokunus = rastgelesayi.Next(60, 100);
                Uretkenlik = rastgelesayi.Next(60, 100);
                Ozelyetenek = rastgelesayi.Next(60, 100);
            }

            public Ortasaha()
            {

            }
            public override Boolean Pasver()
            {
                int Passkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + Dogalform * 0.1 + Uzuntop * 0.1 + Sans * 0.2);
                if (Passkor > 80)
                {
                    return true;
                }

                else
                {
                    return false;

                }
            }

            public override Boolean Golvurusu()
            {
                int Golskor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + Hiz * 0.1 + Dogalform * 0.1 + Sans * 0.2);
                if (Golskor > 70)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }

        }
            class Forvet : Futbol
            {
                private int Bitiricilik;
                private int Ilkdokunus;
                private int Kafa;
                private int Ozelyetenek;
                private int Sogukkanlilik;
                public Forvet(string Adsoyad, int Formano)
                {

                    this.AdSoyad = Adsoyad;
                    this.Formano = Formano;
                    Hiz = rastgelesayi.Next(70, 100);
                    Dayaniklilik = rastgelesayi.Next(70, 100);
                    Pas = rastgelesayi.Next(70, 100);
                    Sut = rastgelesayi.Next(70, 100);
                    Yetenek = rastgelesayi.Next(70, 100);
                    Kararlilik = rastgelesayi.Next(70, 100);
                    Dogalform = rastgelesayi.Next(70, 100);
                    Sans = rastgelesayi.Next(70, 100);
                    Bitiricilik = rastgelesayi.Next(70, 100);
                    Ilkdokunus = rastgelesayi.Next(70, 100);
                    Kafa = rastgelesayi.Next(70, 100);
                    Ozelyetenek = rastgelesayi.Next(70, 100);
                    Sogukkanlilik = rastgelesayi.Next(70, 100);

                }
                public Forvet()
                {

                }
                public override Boolean Golvurusu()
                {
                    int Golskor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + Hiz * 0.1 + Dogalform * 0.1 + Sans * 0.2);
                    if (Golskor > 70)
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
