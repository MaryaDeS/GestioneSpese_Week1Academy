using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GestioneSpese_Week1Academy_FileReader
{
    public class LetturaFile
    {
        public static void LetturaFileSpesa() {
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(@"C:\Users\maria.de.stefano\Desktop\Academy\Week9_Academy\Spese.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    
    }
}
