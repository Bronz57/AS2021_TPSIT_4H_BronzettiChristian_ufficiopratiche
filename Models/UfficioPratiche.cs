using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AS2021_TPSIT_4H_BronzettiChristian_ufficio.Models
{
    class UfficioPratiche
    {
        List<Pratica> _pratiche = new List<Pratica>();
        public UfficioPratiche(){}

        public void InserisciNuovaPratica(string nome, string cognome, string tipo, string descrizione)
        => _pratiche.Add(new Pratica(cognome, nome, tipo, descrizione));

        public Pratica RicercaPraticaTramiteCodice(int id)
        {
            foreach(Pratica p in _pratiche)
                if(p.Id==id)
                    return p;

           throw new Exception("Pratica non trovata");
        }

        public string RicercaPraticheTramiteTipo(string tipo)
        {
            tipo.ToUpper();
            //aggiungo quelli che trovo ad una lista che poi mi serve per stampare
            List<Pratica> praticheStessoTipo = new List<Pratica>();

            foreach(Pratica p in _pratiche)
                if(p.Tipo == tipo)
                    praticheStessoTipo.Add(p);
             
             StringBuilder sb = new StringBuilder();
             foreach(Pratica p in praticheStessoTipo)
                sb.Append(p.ToString());

            return sb.ToString();

        }

        public bool SalvataggioPratiche()
        {
            StringBuilder sb = new StringBuilder(); //uso uno stringbuilder in modo da costruirmi una stringq 

            //aggiunge ogni pratica della list alla stringa
            foreach(Pratica p in _pratiche)
                sb.AppendLine(p.ToString());

            //scrive all'interno del file la stringa creata
            File.AppendAllText("ListaPratiche.txt", sb.ToString());

            return true;
        }

        public bool EliminaPratica(int id)
        {
            
            //variabile per salvare la posizione della pratica da eliminare
            int index =0; 
            bool f = true; //flag di controllo se è vero salva altrimenti no
            for(int i = 0; i<_pratiche.Count; i++)
                if(id == _pratiche[i].Id)
                {
                     index = i;
                     break;
                }
                else
                    f = false;
                   

            _pratiche.RemoveAt(index);

            return f;
            
        }
    }
}