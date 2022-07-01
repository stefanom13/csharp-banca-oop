using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Banca
    {

        List<Cliente> clienti = new List<Cliente>();

        List<Prestito> prestiti = new List<Prestito>();

        public Banca(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; private set; }

    }
}
