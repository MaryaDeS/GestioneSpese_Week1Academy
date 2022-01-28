using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese_Week1Academy_DesignPatterns.Interfaces
{
    public interface ISpesa
    {
        string SpesaType { get; }
        DateTime? SpesaDate { get; set; }
        string Descrizione { get; set; }
        decimal ImportoSpesa { get; set;}

        


    }
}
