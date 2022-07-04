using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Banca
    {
        string Nome { get; set; }

        public List<Cliente> clienti;
        public List<Prestito> prestiti;

        public Banca(string nome)
        {
            this.Nome = nome;
            this.clienti = new List<Cliente>();
            this.prestiti = new List<Prestito>();
        }

        // metodi istanza cliente

        // metodo creazione cliente
        public static Cliente CreaCliente()
        {
            Console.WriteLine("\n*** Creazione un nuovo Cliente ***\n");

            Console.Write("Inserire il nome: ");
            string nome = Console.ReadLine();

            Console.Write("Inserire il cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Inserire il codice fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Inserire lo stipendio annuo: ");
            int stipendio = Int32.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);

            return cliente;
        }

        // metodo modifica informazioni cliente

        public static Cliente ModificaCliente()
        {
            Console.WriteLine("\n*** Modifica Cliente ***\n");

            // caratterizzo il cliente

            Console.Write("Inserire lo stipendio annuo: ");
            int stipendio = Int32.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(stipendio);

            return cliente;
        }




        // salvo il cliente nella lista clienti
        public void AggiungiNuovoCliente(Cliente cliente)
        {
            clienti.Add(cliente);
        }

        public void ListaClienti()
        {
            Console.WriteLine();
            Console.WriteLine("\n*** Lista Clienti ***\n");

            foreach (Cliente cliente in clienti)
            {
                Console.WriteLine(cliente.GetInfoCliente() + "\n");
            }
        }

        public Cliente GetCliente(int IndCliente)
        {
            IndCliente--;
            if (IndCliente < 0 || IndCliente >= clienti.Count())
            {
                Console.WriteLine("Mi dispiace: Il cliente selezionato non esiste!");
                return null;
            }

            return clienti[IndCliente];
        }

        public Cliente ModificaInformazioniCliente(Cliente clienteDaModificare)
        {
            Cliente modificheCliente = Banca.ModificaCliente();

            clienteDaModificare.Stipendio = modificheCliente.Stipendio;

            return clienteDaModificare;
        }
        //***** fine metodi 'istanza cliente *****
        //***** metodi istanza prestito *****
        public Prestito CreaPrestito()
        {
            Console.WriteLine("\n*** Crea un Prestito ***\n");


            Console.Write("\nInserire l'indiceCliente:");
            int indCliente = Int32.Parse(Console.ReadLine());
            Cliente clienteRichiedente = this.GetCliente(indCliente);

            Console.Write("Inserire l'ammontare del prestito: ");
            int ammontarePrestito = Int32.Parse(Console.ReadLine());

            Console.Write("Inserire le rate del prestito: ");
            int rataPrestito = Int32.Parse(Console.ReadLine());

            string dataInizio = DateTime.Today.ToShortDateString();
            DateTime dateTime = DateTime.Parse(dataInizio);
            Console.WriteLine("\n\n*** Data inizio prestito: {0}***\n", dataInizio);

            //calcolo data fine prestito
            double tempo = ammontarePrestito / rataPrestito;
            int ratePrestito = (int)Math.Round(tempo, 0);

            DateTime dataFinale = dateTime.AddMonths(ratePrestito);
            string dataFine = Convert.ToString(dataFinale);
            Console.WriteLine("\n\n*** Data fine prestito: {0}***\n", dataFine);

            Console.Write("Inserire prestito 'y' o 'n' -->");
            string validatore = Console.ReadLine();
            Console.Clear();
            if (validatore == "y")
            {
                Prestito prestito = new Prestito(clienteRichiedente, ammontarePrestito, rataPrestito, dataInizio, dataFine);

                Console.WriteLine("Il prestito è stato concesso");
                return prestito;
            }

            return null;

        }
        //inserimento prestito
        public void InserisciPrestito(Prestito prestito)
        {
            this.prestiti.Add(prestito);
        }

        //lista prestiti
        public void ListaPrestiti()
        {
            Console.WriteLine();
            Console.WriteLine("\n*** Lista Prestiti ***\n");

            foreach (Prestito prestito in prestiti)
            {
                Console.WriteLine(prestito.GetInformazioniPrestito() + "\n");
            }
        }

        public void GetPrestito(string codiceFiscale)
        {
            int sommaPrestiti = 0;
            List<Prestito> prestitiCliente = new List<Prestito>();

            //ciclo array contenente tutti i prestiti dei clienti

            foreach (Prestito prestito in prestiti)
            {

                if (codiceFiscale == prestito.userCliente.CodiceFiscale)
                {

                    prestitiCliente.Add(prestito);

                }
            }
            foreach (Prestito prestito in prestitiCliente)
            {

                Console.WriteLine("{0}\nRate del prestito rimanenti: {1}\n", prestito.GetInformazioniPrestito(), this.GetRateRimanenti(prestito));

            }

            foreach (Prestito prestito in prestitiCliente)
            {
                sommaPrestiti += prestito.Ammontare;

            }
            Console.WriteLine("\n****La somma totale dei prestiti è: {0} euro****", sommaPrestiti);
        }

        public int GetRateRimanenti(Prestito prestito)
        {
            string tempDate = DateTime.Today.ToShortDateString();
            DateTime dataAttuale = DateTime.Parse(tempDate);
            DateTime dataFinale = DateTime.Parse(prestito.dataFine);

            int rateRestanti = -12 * (dataAttuale.Year - dataFinale.Year) + dataAttuale.Month - dataFinale.Month;

            return rateRestanti;
        }

        public void ProspettoPrestiti(List<Prestito> prestiti)
        {
            foreach (Prestito prestito in prestiti)
            {
                Console.Write(prestito.GetInformazioniPrestito());
            }
        }


    }
}
