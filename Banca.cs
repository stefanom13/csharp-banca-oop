using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Banca
    {
        public string Nome { get; set; }

        static List<Cliente> clienti = new List<Cliente>();

        static List<Prestito> prestiti = new List<Prestito>();




        // metodo creazione cliente
        // aggiungere cliente
        public static void aggiungiCliente()
        {
            Console.WriteLine("\n* Aggiungi Cliente *\n");
            Cliente cliente = creaCliente();
            Console.WriteLine(cliente.toString());
            clienti.Add(cliente);
        }

        // modificare cliente
        public static void modificaCliente(Cliente vecchioCliente)
        {
            Console.WriteLine("\n* Modifica cliente *\n");
            Cliente cliente = creaCliente();
            clienti.Remove(vecchioCliente);
            clienti.Add(cliente);
            Console.WriteLine(cliente.toString());
        }
        private static Cliente creaCliente()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Codice Fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Stipendio: ");
            uint stipendio = Convert.ToUInt32(Console.ReadLine());

            Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);

            return cliente;
        }

        // ricercare cliente
        public static Cliente cercaCliente(String codiceFiscale)
        {
            foreach (Cliente cliente in clienti)
            {
                if (cliente.codiceFiscale == codiceFiscale)
                {
                    return cliente;
                }
            }

            return null;
        }


    }
}
