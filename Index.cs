using System;

namespace codeTranslator
{
public class Index
{
  public static void Main (string[] args)
  {
    Index index1 = new Index();
    index1.bacaDatabase();
  }

  private void bacaDatabase()
  {
        DbAldes dbAldes = new DbAldes();
        dbAldes.insilisasiDatabase   ("DatabaseSymbol");
        //dbAldes.tampil(); //print-database
        
        Console.Write   ("Masukkan Symbol : ");

        // Test Input
        string symbol1 = Console.ReadLine();
        string hasil1  = dbAldes.terjemahkan(symbol1); 
        Console.WriteLine (hasil1);

        Console.ReadKey();
       
  }
}
}