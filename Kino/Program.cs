using System;

namespace Kino
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = {
                {0,1,1,1,0,0,0,0,1,1},
                {0,0,0,0,0,0,0,0,0,0},
                {0,1,1,1,0,0,0,0,1,1},
                {0,1,1,1,0,0,0,0,1,1},
                {0,1,1,1,0,0,0,0,1,1}
                            };
            int wiersz = 0;
            int kolumna = 0;
            int i = 0;
            bool czyWolnyRzad = false;
            while(wiersz<5)
            {
                int iloscWolnychMiejsc = 0;
                kolumna = 0;
                while (kolumna < 10)
                {
                   if(tab[wiersz,kolumna]==0)
                   {
                        iloscWolnychMiejsc++;
                        kolumna++;
                   } else
                   {
                        kolumna++;
                   }
                
                    if(iloscWolnychMiejsc==10)
                    {
                        while(i<10)
                        {
                            Console.WriteLine(wiersz+ ", "+ i);
                            czyWolnyRzad = true;
                            i++;
                        }
                    }
                }
                wiersz++;
                
            }
            if (czyWolnyRzad != true)
            {
                Console.Write("Idź do innego kina");
            }



        }
    }
}
