using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Cliente
    {

        string Nome { get; set; }

        string Cognome { get; set; }

        string CodiceFiscale { get; set; }

        public int Stipendio { get; set; }

        public List<Prestito> prestiti = new List<Prestito>();

        // Costruttore per la creazione dell'istanza creazione
        public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.CodiceFiscale = codiceFiscale;
            this.Stipendio = stipendio;
        }


        public Cliente(int stipendio)
        {
            this.Stipendio = stipendio;
        }


        public string GetInformazioniCliente()
        {
            return $"***Cliente***\nNome: {Nome}\nCognome: {Cognome}\nCodice fiscale: {CodiceFiscale}\nStipendio: {Stipendio}";
        }


    }
}
