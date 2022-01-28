using GestioneSpese_Week1Academy_DesignPatterns.Factory;
using GestioneSpese_Week1Academy_DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese_Week1Academy_DesignPatterns
{
    public class FactoryClient
    {
        public static void FactoryClientMethod()
        {
            ISpesaFactory factory = new AlloggioFactory();
            var spesa=factory.GetSpesa();

            Console.WriteLine(spesa.ToString());

            ISpesaFactory factory1 = new VittoFactory();
            var spesa1=factory1.GetSpesa();

            Console.WriteLine(spesa1.ToString());
            
            ISpesaFactory factory3 = new ViaggioFactory();
            var spesa3=factory3.GetSpesa();

            Console.WriteLine(spesa3.ToString());
            
            
            ISpesaFactory factory4 = new AltroFactory();
            var spesa4=factory4.GetSpesa();

            Console.WriteLine(spesa4.ToString());
            
            

            

        }
    }
}
