using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400060
{
    class Progeam
    {
        static void Main(string[] args)
        {
            KodePaket kode = new KodePaket();
            string[] daftarPaket = {"Basic", "Standard", "Premium","bulanan", "Unlimited", "Streaming", "Family", "Business", "Student", "Traveler"};

            foreach(string nama in daftarPaket)
            {
                Console.WriteLine($"Paket: {nama,-10} | Kode: {kode.getKodePaket(nama)}");
            } 
        }
    }
}