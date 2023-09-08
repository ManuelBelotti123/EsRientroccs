using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreriaCS;
using static libreriaCS.LibreriaCS;

namespace EsRientroccs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dichiarazioni
            int scelta = 0;
            Random rn = new Random();
            LibreriaCS l = new LibreriaCS();
            //menu a scelta
            do
            {
                Console.Clear();
                //opzioni
                Console.WriteLine("1. Aggiusta il formato del file");
                Console.WriteLine("2. Conta il numero dei campi del file");
                Console.WriteLine("0. Esci dal programma");
                scelta = int.Parse(Console.ReadLine());
                //scelta
                switch (scelta)
                {
                    case 1:
                        if (l.ContrAgg() == false)
                        {
                            l.aggiusta();
                            Console.WriteLine("File aggiustato correttamente");
                            Console.WriteLine("Clicca un tasto per continuare...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Operazione già effettuata");
                            Console.WriteLine("Clicca un tasto per continuare...");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("I campi di questo file sono " + l.ContaCampi() + ".");
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("La lunghezza massima dei record presenti è " + l.LungMaxRec() + " caratteri.");
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                }
            } while (scelta != 0);
        }
    }
}
