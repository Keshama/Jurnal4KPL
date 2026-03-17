using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400060
{
    public class KodePaket
    {
        private Dictionary<string, string> tabelPaket = new Dictionary<string, string>()
        {
            {"Basic", "P201" },
            {"Standard", "P202" },
            {"Premium", "P203" },
            {"Unlimited", "P204" },
            {"Gaming", "P205" },
            {"Streaming", "P206" },
            {"Family", "P207" },
            {"Business", "P208" },
            {"Student", "P209" },
            {"Traveler", "P210" }
        };

        public string getKodePaket (string namaPaket)
        {
            if (tabelPaket.ContainsKey(namaPaket))
            {
                return tabelPaket[namaPaket];
            }
            else
            {
                return "kode paket tidak ada";
            }
            
        }
    }
}
