using GestioneSpese_Week1Academy_DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese_Week1Academy_DesignPatterns.Entities
{
    public class AlloggioSpesa : ISpesa
    {
        private readonly string _spesaType;
        private DateTime? _spesaDate;
        private string _descrizione;
        private decimal _importoSpesa;

        public AlloggioSpesa( DateTime spesaDate, string descrizione, decimal importoSpesa)
        {
            _spesaType = "Alloggio";
            _spesaDate = spesaDate;
            _descrizione= descrizione;
            _importoSpesa= importoSpesa;

        }

        public string SpesaType
        {
            get { return _spesaType; }
        }

        public DateTime? SpesaDate
        { get { return _spesaDate; } 
          set { _spesaDate = value; } 
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public decimal ImportoSpesa
        { get { return  _importoSpesa; }
          set { _importoSpesa = value; }
        }
      
    }
}
