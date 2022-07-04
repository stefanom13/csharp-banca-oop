using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Prestito
    {
        public Cliente userCliente;
        private int codId;
        public int Ammontare { get; private set; }
        int Rata { get; set; }
        public string dataInizio { get; set; }
        public string dataFine { get; set; }

        public Prestito(Cliente userCliente, int ammontare, int rata, string dataInizio, string dataFine)
        {
            this.userCliente = userCliente;
            this.Ammontare = ammontare;
            this.Rata = rata;
            this.dataInizio = dataInizio;
            this.dataFine = dataFine;
            
        }

        public string GetInformazioniPrestito()
        {
            return $"***Prestito***\nInformazioni Cliente:{userCliente.GetInfoCliente()}\n\nAmmontare prestito: {Ammontare}\nRata prestito : {Rata}\nData inizio:{dataInizio} e data fine {dataFine}\n\n";
        }
    }
}