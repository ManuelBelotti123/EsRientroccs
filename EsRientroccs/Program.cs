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
            Random rn = new Random();
            LibreriaCS l = new LibreriaCS();

            l.aggiusta();
        }
    }
}
