using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Prestito
    {
        public int Id { get; private set; }

        Cliente cliente { get; set; }
        public double PrestitoTotale { get; set; }
        public DateTime InizioPrestito { get; set; }
        public DateTime FinePrestito { get; set; }
    }
}
