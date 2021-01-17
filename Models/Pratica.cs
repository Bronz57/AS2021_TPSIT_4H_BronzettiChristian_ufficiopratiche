using System;

namespace AS2021_TPSIT_4H_BronzettiChristian_ufficio.Models
{
    class Pratica
    {
        string _cognome;
        string _nome;
        int _id; //id privata per ogni oggetto creato da main
        public int Id { get => _id; } //proprieta readonly per id
         static int _nPratica; //campo statico per aggiornare l'id
        string _tipo;
        public string Tipo { get=> _tipo; }//proprieta readonly per il tipo
        string _descrizione;

        public Pratica(string cognome, string nome, string tipo, string descrizione )
        {
            _cognome = cognome;
            _nome = nome;
            _tipo = tipo;
            _descrizione = descrizione;
            _id = ContaPratica();
        }

        private static int  ContaPratica() => _nPratica++;

        public override string ToString()
        {
           return $"Nome: {_nome}\n"+ $"Cognome:{_cognome}\n"+
                  $"Id pratica: {_id}\n"+ $"Tipo pratica: {_tipo}\n"+
                  $"Descrizione pratica: {_descrizione}\n";
        }
    }    
}