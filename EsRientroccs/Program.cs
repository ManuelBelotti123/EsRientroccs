﻿using System;
using System.Collections.Generic;
using System.Data.Common;
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
                Console.WriteLine("3. Lunghezza Massima tra i Record");
                Console.WriteLine("4. Aggiunta di un record in coda");
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
                    case 4:
                        string[] div = new string[18];
                        Console.WriteLine("Inserisci i campi del nuovo record che vuoi inserire:");
                        Console.WriteLine("Comune:");
                        div[0] = Console.ReadLine();
                        Console.WriteLine("Provincia:");
                        div[1] = Console.ReadLine();
                        Console.WriteLine("Regione:");
                        div[2] = Console.ReadLine();
                        Console.WriteLine("Tipologia:");
                        div[3] = Console.ReadLine();
                        Console.WriteLine("Categoria(Stelle):");
                        div[4] = Console.ReadLine();
                        Console.WriteLine("Denominazione:");
                        div[5] = Console.ReadLine();
                        Console.WriteLine("Indirizzo:");
                        div[6] = Console.ReadLine();
                        Console.WriteLine("CAP:");
                        div[7] = Console.ReadLine();
                        Console.WriteLine("Località:");
                        div[8] = Console.ReadLine();
                        Console.WriteLine("Frazione:");
                        div[9] = Console.ReadLine();
                        Console.WriteLine("Telefono:");
                        div[10] = Console.ReadLine();
                        Console.WriteLine("FAX:");
                        div[11] = Console.ReadLine();
                        Console.WriteLine("Indirizzo Posta Elettronica:");
                        div[12] = Console.ReadLine();
                        Console.WriteLine("Sito Internet:");
                        div[13] = Console.ReadLine();
                        Console.WriteLine("Codice esercizio:");
                        div[14] = Console.ReadLine();
                        Console.WriteLine("Camere:");
                        div[15] = Console.ReadLine();
                        Console.WriteLine("Posti letto standard:");
                        div[16] = Console.ReadLine();
                        Console.WriteLine("Posti letto aggiuntivi:");
                        div[17] = Console.ReadLine();
                        l.AggRec(div);
                        Console.WriteLine("Record aggiunto correttamente");
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
