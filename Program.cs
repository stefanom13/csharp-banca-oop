//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)

//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio

//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.

//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.
//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.
using csharp_banca_oop;

Banca banca = new Banca("BNL");

//   liste

banca.clienti.Add(new Cliente("Michele", "Dantino", "MCD20FSFS1845", 340000));
banca.clienti.Add(new Cliente("Orazio", "Bertolami", "EI76LDVLO57325", 35000));
banca.clienti.Add(new Cliente("Luca", "Eugregi", "AOMSOEHT67822", 32000));
banca.clienti.Add(new Cliente("Enzo", "Priamo", "LIBIDI54321", 72000));

//aggiunta prestiti

banca.prestiti.Add(new Prestito(banca.clienti[0], 40000, 200, "12/04/2016", "12/07/2022"));
banca.prestiti.Add(new Prestito(banca.clienti[1], 30000, 200, "12/04/2021", "07/08/2032"));


// Aggiungere un nuovo cliente

Cliente cliente = Banca.CreaCliente();

banca.AggiungiNuovoCliente(cliente);

// lista clienti

banca.ListaClienti();

//seleziona un cliente dalla lista 
Console.Write("Inserire indiceCliente:");
int indCliente = Int32.Parse(Console.ReadLine());

//Cliente clienteCercato = banca.GetCliente(indCliente);

//Console.WriteLine(clienteCercato.GetInfoCliente());

//Prestito prestito = banca.CreaPrestito();
//banca.InserisciPrestito(prestito);
//Console.WriteLine(prestito.GetInformazioniPrestito());
//Console.WriteLine();
//banca.ListaPrestiti();






