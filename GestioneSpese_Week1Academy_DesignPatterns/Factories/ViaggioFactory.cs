using GestioneSpese_Week1Academy_DesignPatterns.Entities;
using GestioneSpese_Week1Academy_DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GestioneSpese_Week1Academy_DesignPatterns.Factory
{
    public class ViaggioFactory : ISpesaFactory
    {
        
        private DateTime _spesaDate;
        private string _descrizione;
        private decimal _importoSpesa;

        public ViaggioFactory()
        {
        }

        public ViaggioFactory(DateTime spesaDate, string descrizione, decimal importoSpesa)
        {
            
            _spesaDate = spesaDate;
            _descrizione = descrizione;
            _importoSpesa = importoSpesa;

        }

        public ISpesa GetSpesa()
        {
            throw new NotImplementedException();
        }

        public ISpesa Rimborso()
        {
            throw new NotImplementedException();
        }


        //public ISpesa GetSpesa()
        //{
        //    return new ViaggioSpesa(_spesaDate, _descrizione, _importoSpesa);
        //}


        //static string[] codes = new string[] { "Viaggio", "Alloggio", "Vitto", "Altro" };
        //const decimal FixedFee = 50;
        //const string  path= @"C:\Users\maria.de.stefano\Desktop\Academy\Week9_Academy\Spese.txt";


        //internal static bool CheckString(string code)
        //{
        //    if (codes.Contains(code))
        //    {
        //        return true;
        //    }return false;

        //}

        //public ISpesa Rimborso()
        //{
        //    throw new NotImplementedException();//retur FixedFee + vorrei mettere l'importo della spesa;
        //}

        //public static List<string> LoadSpesa(string code)
        //{
        //    List<string> spese = new List<string>();
        //    using (StreamReader sr=new StreamReader(path))
        //    {
        //        string allSpese=sr.ReadToEnd();

        //        string[] rows=allSpese.Split('\n');

        //        for(int i=0;i<rows.Length;i++)
        //        {
        //            if(rows[i].Contains(code))
        //                spese.Add(rows[i]);
        //        }
        //    }
        //    return spese;
        //}
    }
}
