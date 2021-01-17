using System;
using AS2021_TPSIT_4H_BronzettiChristian_ufficio.Models;
namespace AS2021_TPSIT_4H_BronzettiChristian_ufficio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma che gestisce l'ufficio pratiche, scritto da Bronzetti Christian 4 H");
            UfficioPratiche up = new UfficioPratiche();
             
            up.InserisciNuovaPratica("Rossi", "Mario", "A", "Conto");
            up.InserisciNuovaPratica("Bianchi", "Diego", "A", "Conto");
            up.InserisciNuovaPratica("Verdi", "Giuseppe", "b", "Revisione");
            up.InserisciNuovaPratica("Delfitto", "Marcello", "C", "Edilizia");
            up.InserisciNuovaPratica("Grandi", "Riccardo", "b", "Revisione");
            up.InserisciNuovaPratica("Giannini", "Claudio", "b", "Revisione");

            up.SalvataggioPratiche();
           
            Console.WriteLine("Ricerco pratica tramite codice id:");
            try
            {
                Console.WriteLine(up.RicercaPraticaTramiteCodice(0));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


             Console.WriteLine($"Ricerco pratica tramite codice id:\n{up.RicercaPraticheTramiteTipo("b")}");

            if(up.SalvataggioPratiche())
                Console.WriteLine("Salvato con successo, controlla il file!");

            if(up.EliminaPratica(0))
            {
                up.SalvataggioPratiche();
                Console.WriteLine("File aggiornato");
            }
            else
                Console.WriteLine("Non abbiamo trovato la pratica richiesta");
                
        }
    }
}
