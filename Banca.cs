using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Banca
    {
        string Nome { get; set; }

        public List<Cliente> clienti;
        List<Prestito> prestiti;

        public Banca(string nome)
        {
            this.Nome = nome;
            this.clienti = new List<Cliente>();
            this.prestiti = new List<Prestito>();
        }

        //***** metodi istanza cliente *****

        // metodo creazione cliente
        public static Cliente CreaCliente()
        {
            Console.WriteLine("\n*** Creazione un nuovo Cliente ***\n");

            // caratterizzo il cliente

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

        
    }
}
