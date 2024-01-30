using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Uygulamam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Futbol> takim = new List<Futbol>(); 
            takim.Add(new Futbol("kaleci" , 1 ));
            
            takim.Add(new Defans("defans1", 2));
            takim.Add(new Defans("defans2", 3));
            takim.Add(new Defans("defans3", 4));
            takim.Add(new Defans("defans4", 5));
            takim.Add(new Ortasaha("ortasaha1", 6));
            takim.Add(new Ortasaha("ortasaha2", 7));
            takim.Add(new Ortasaha("ortasaha3", 8));
            takim.Add(new Ortasaha("ortasah4", 9));
            takim.Add(new Forvet ("forvet1", 10));
            takim.Add(new Forvet("forvet2", 11));
            Random Rastgele = new Random();
          
            int Formano;
            int paskontrol = 12;
            Boolean gololabilir = true;
            Formano = Rastgele.Next(1, 12);

            for ( int i = 1; i<=3; i++)
            {
                while( paskontrol == Formano)
                {
                    Formano = Rastgele.Next(1, 12);

                }

                paskontrol = Formano;

                if (!takim[Formano-1].Pasver()) 
                {
                    Console.WriteLine(Formano + " numaralı oyuncunun pası başarısız...");
                    gololabilir = false;
                    break;
                }

                else
                {
                    Console.WriteLine(Formano + " numaralı oyuncunun pası tam isabet...");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            Console.WriteLine("Kaleciyle karşı karşıya.....");
            System.Threading.Thread.Sleep(2000);







            if ( gololabilir = true)
            {
                if ( takim[Formano - 1 ].Golvurusu())
                {
                    Console.WriteLine("GOOOOOOOOLLLLLLLLLLL....");
                }
                else
                {
                    Console.WriteLine("az farkla kaçırdı....");
                }

            }
            Console.ReadLine();


        }
    }
}
