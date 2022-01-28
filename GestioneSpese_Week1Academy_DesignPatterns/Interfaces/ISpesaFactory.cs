using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese_Week1Academy_DesignPatterns.Interfaces
{
    public interface ISpesaFactory
    {

        ISpesa Rimborso();
        ISpesa GetSpesa();
        
        
    }
}
