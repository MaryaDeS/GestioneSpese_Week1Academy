using GestioneSpese_Week1Academy_DesignPatterns.Entities;
using GestioneSpese_Week1Academy_DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese_Week1Academy_DesignPatterns.Factory
{
    public class AltroFactory : ISpesaFactory
    {
        private DateTime _spesaDate;
        private string _descrizione;
        private decimal _importoSpesa;

        public AltroFactory()
        {
        }

        public AltroFactory(DateTime spesaDate, string descrizione, decimal importoSpesa)
        {

            _spesaDate = spesaDate;
            _descrizione = descrizione;
            _importoSpesa = importoSpesa;

        }
        public ISpesa GetSpesa()
        {
            return new AltroSpesa(_spesaDate, _descrizione, _importoSpesa);
        }

        public ISpesa Rimborso()
        {
            throw new NotImplementedException();
        }
    }
}
