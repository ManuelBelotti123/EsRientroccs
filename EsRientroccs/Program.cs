using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
                Console.WriteLine("GESTIONE FILE CSV");
                Console.WriteLine("1. Aggiusta il formato del file");
                Console.WriteLine("2. Conta il numero dei campi del file");
                Console.WriteLine("3. Lunghezza Massima tra i Record");
                Console.WriteLine("4. Aggiunta di un record in coda");
                Console.WriteLine("5. Visualizza tre campi a scelta");
                Console.WriteLine("6. Ricerca in un campo");
                Console.WriteLine("7. Modifica di un record");
                Console.WriteLine("8. Cancellazione logica di un record");
                Console.WriteLine("9. Recupero di un record");
                Console.WriteLine("10. Ricompatta il file");
                Console.WriteLine("11. Visualizza l'intero file");
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
                    case 5:
                        int[] cvis = new int[3];
                        Console.WriteLine("Digita il numero corrispondente ai campi che vuoi visualizzare:");
                        Console.WriteLine("0. Comune");
                        Console.WriteLine("1. Provincia");
                        Console.WriteLine("2. Regione");
                        Console.WriteLine("3. Tipologia");
                        Console.WriteLine("4. Categoria(Stelle)");
                        Console.WriteLine("5. Denominazione");
                        Console.WriteLine("6. Indirizzo");
                        Console.WriteLine("7. CAP");
                        Console.WriteLine("8. Località");
                        Console.WriteLine("9. Frazione");
                        Console.WriteLine("10. Telefono");
                        Console.WriteLine("11. FAX");
                        Console.WriteLine("12. Indirizzo Posta Elettronica");
                        Console.WriteLine("13. Sito Internet");
                        Console.WriteLine("14. Codice esercizio");
                        Console.WriteLine("15. Camere");
                        Console.WriteLine("16. Posti letto standard");
                        Console.WriteLine("17. Posti letto aggiuntivi");
                        for (int i = 0; i < cvis.Length; i++)
                        {
                            Console.WriteLine("Inserisci il numero:");
                            cvis[i] = int.Parse(Console.ReadLine());
                        }
                        string[] arr = l.EstrapolaCampi(cvis[0], cvis[1], cvis[2]);
                        int j = 0;
                        while (arr[j] != null)
                        {
                            Console.WriteLine(arr[j]);
                            j++;
                        }
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Inserisci il termine che vuoi ricercare:");
                        string ricerca = Console.ReadLine();
                        Console.WriteLine("Digita il numero corrispondente al campo in cui vuoi ricercare:");
                        Console.WriteLine("0. Comune");
                        Console.WriteLine("1. Provincia");
                        Console.WriteLine("2. Regione");
                        Console.WriteLine("3. Tipologia");
                        Console.WriteLine("4. Categoria(Stelle)");
                        Console.WriteLine("5. Denominazione");
                        Console.WriteLine("6. Indirizzo");
                        Console.WriteLine("7. CAP");
                        Console.WriteLine("8. Località");
                        Console.WriteLine("9. Frazione");
                        Console.WriteLine("10. Telefono");
                        Console.WriteLine("11. FAX");
                        Console.WriteLine("12. Indirizzo Posta Elettronica");
                        Console.WriteLine("13. Sito Internet");
                        Console.WriteLine("14. Codice esercizio");
                        Console.WriteLine("15. Camere");
                        Console.WriteLine("16. Posti letto standard");
                        Console.WriteLine("17. Posti letto aggiuntivi");
                        int campo = int.Parse(Console.ReadLine());
                        string[] ric = l.Ricerca(campo, ricerca);
                        j = 0;
                        while (ric[j] != null)
                        {
                            Console.WriteLine(ric[j]);
                            j++;
                        }
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Inserisci il termine che vuoi modificare:");
                        ricerca = Console.ReadLine();
                        Console.WriteLine("Inserisci la modifica da effettuare:");
                        string modifica = Console.ReadLine();
                        Console.WriteLine("Digita il numero corrispondente al campo in cui vuoi ricercare:");
                        Console.WriteLine("0. Comune");
                        Console.WriteLine("1. Provincia");
                        Console.WriteLine("2. Regione");
                        Console.WriteLine("3. Tipologia");
                        Console.WriteLine("4. Categoria(Stelle)");
                        Console.WriteLine("5. Denominazione");
                        Console.WriteLine("6. Indirizzo");
                        Console.WriteLine("7. CAP");
                        Console.WriteLine("8. Località");
                        Console.WriteLine("9. Frazione");
                        Console.WriteLine("10. Telefono");
                        Console.WriteLine("11. FAX");
                        Console.WriteLine("12. Indirizzo Posta Elettronica");
                        Console.WriteLine("13. Sito Internet");
                        Console.WriteLine("14. Codice esercizio");
                        Console.WriteLine("15. Camere");
                        Console.WriteLine("16. Posti letto standard");
                        Console.WriteLine("17. Posti letto aggiuntivi");
                        campo = int.Parse(Console.ReadLine());
                        l.ModificaCampo(campo, ricerca, modifica);
                        Console.WriteLine("Operazione completata");
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 8:
                        bool cor = false;
                        Console.WriteLine("Inserisci il termine nel campo del record che vuoi cancellare:");
                        ricerca = Console.ReadLine();
                        Console.WriteLine("Digita il numero corrispondente al campo in cui vuoi ricercare:");
                        Console.WriteLine("0. Comune");
                        Console.WriteLine("1. Provincia");
                        Console.WriteLine("2. Regione");
                        Console.WriteLine("3. Tipologia");
                        Console.WriteLine("4. Categoria(Stelle)");
                        Console.WriteLine("5. Denominazione");
                        Console.WriteLine("6. Indirizzo");
                        Console.WriteLine("7. CAP");
                        Console.WriteLine("8. Località");
                        Console.WriteLine("9. Frazione");
                        Console.WriteLine("10. Telefono");
                        Console.WriteLine("11. FAX");
                        Console.WriteLine("12. Indirizzo Posta Elettronica");
                        Console.WriteLine("13. Sito Internet");
                        Console.WriteLine("14. Codice esercizio");
                        Console.WriteLine("15. Camere");
                        Console.WriteLine("16. Posti letto standard");
                        Console.WriteLine("17. Posti letto aggiuntivi");
                        campo = int.Parse(Console.ReadLine());
                        l.CancRecLogica(campo, ricerca, cor);
                        Console.WriteLine("Operazione completata");
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 9:
                        cor = true;
                        Console.WriteLine("Inserisci il termine nel campo del record che vuoi recuperare:");
                        ricerca = Console.ReadLine();
                        Console.WriteLine("Digita il numero corrispondente al campo in cui vuoi ricercare:");
                        Console.WriteLine("0. Comune");
                        Console.WriteLine("1. Provincia");
                        Console.WriteLine("2. Regione");
                        Console.WriteLine("3. Tipologia");
                        Console.WriteLine("4. Categoria(Stelle)");
                        Console.WriteLine("5. Denominazione");
                        Console.WriteLine("6. Indirizzo");
                        Console.WriteLine("7. CAP");
                        Console.WriteLine("8. Località");
                        Console.WriteLine("9. Frazione");
                        Console.WriteLine("10. Telefono");
                        Console.WriteLine("11. FAX");
                        Console.WriteLine("12. Indirizzo Posta Elettronica");
                        Console.WriteLine("13. Sito Internet");
                        Console.WriteLine("14. Codice esercizio");
                        Console.WriteLine("15. Camere");
                        Console.WriteLine("16. Posti letto standard");
                        Console.WriteLine("17. Posti letto aggiuntivi");
                        campo = int.Parse(Console.ReadLine());
                        l.CancRecLogica(campo, ricerca, cor);
                        Console.WriteLine("Operazione completata");
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 10:
                        l.Ricompatta();
                        Console.WriteLine("Ricompattamento del file completato");
                        Console.WriteLine("Clicca un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 11:
                        j = 0;
                        arr = l.Visualizza();
                        while (arr[j] != null)
                        {
                            Console.WriteLine(arr[j]);
                            j++;
                        }
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
