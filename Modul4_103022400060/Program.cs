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

            MesinKopi mesinKopi = new MesinKopi();
            Console.WriteLine("/-- perubahan sesuai soal");
            mesinKopi.UbahState(MesinKopi.Trigger.POWER_ON);
            mesinKopi.UbahState(MesinKopi.Trigger.START_BREW);
            mesinKopi.UbahState(MesinKopi.Trigger.FINISH_BREW);
            mesinKopi.UbahState(MesinKopi.Trigger.START_MAINTENANCE);
            mesinKopi.UbahState(MesinKopi.Trigger.FINISH_MAINTENANCE);
            mesinKopi.UbahState(MesinKopi.Trigger.POWER_OFF);
            Console.WriteLine("/-- uji gagal");
            mesinKopi.UbahState(MesinKopi.Trigger.START_BREW);
            Console.ReadLine();

        }
    }
}