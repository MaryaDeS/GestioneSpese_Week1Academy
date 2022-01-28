//using GestioneSpese_Week1Academy_FileReader;

//try
//{
//    GestioneSpese_Week1Academy_FileReader.FileReader MyFile = GestioneSpese_Week1Academy_FileReader.FileReader();
//    MyFile.WriteToFile(@"C:\Users\maria.de.stefano\Desktop\Academy\Spese.txt", $"[{DateTime.Now}] - fileContent");
//    MyFile.WriteToFileAsync(@"C:\Users\maria.de.stefano\Desktop\Academy\Spese.txt", $"[{DateTime.Now}] - fileContent async").Wait();

//    MyFile.WriteTofileAsync_SupressAsync("my message").GetAwaiter().GetResult();
//}
//catch (FileNotFoundException ex)
//{
//    Console.WriteLine(ex.Message, ex);
//}
using GestioneSpese_Week1Academy_DesignPatterns;
using GestioneSpese_Week1Academy_FileReader;

LetturaFile.LetturaFileSpesa();
//FileReader1.Main();
//FactoryClient.FactoryClientMethod();

