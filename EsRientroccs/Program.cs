using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreriaCS;

namespace EsRientroccs
{
    internal class Program
    {
        //dichiarazioni
        string nomefile = "belotti.csv";
        int lrec = 54;
        string sp = ";";

        //record
        public struct str
        {
            public string comune;
            public string prov;
            public string reg;
            public string stelle;
            public string cat;
            public string den;
            public string ind;
            public int cap;
            public string local;
            public string fraz;
            public string tel;
            public string fax;
            public string posel;
            public string web;
            public int ces;
            public int cam;
            public int pls;
            public int pla;
            public int mval;
            public int c;
        }

        static void Main(string[] args)
        {
            //dichiarazioni
            LibreriaCS l = new LibreriaCS();
            str r;

            int a = 0, cont = 0;
            var file = new FileStream("belotti.csv", FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            var app = new FileStream("app.csv", FileMode.Append, FileAccess.Write, FileShare.Read);
            BinaryReader rd = new BinaryReader(file);
            BinaryWriter wr = new BinaryWriter(app);
            file.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < 1; i++)
            {
                while (true)
                {
                    if (a != 10)
                    {
                        a = file.ReadByte();
                        cont++;
                    }
                    else
                    {
                        break;
                    }
                }
                file.Seek(0, SeekOrigin.Begin);
                byte[] br = rd.ReadBytes(cont);
                string line = Encoding.ASCII.GetString(br, 0, br.Length);
                //divisione dei vari campi della stringa
                string[] div = line.Split(';');
                Console.WriteLine(div[4]);
            }
        }
    }
}
