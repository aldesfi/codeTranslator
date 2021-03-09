using System;

namespace codeTranslator
{
public class DbAldes
{
    string[] lines1;
    public DbAldes()
    {

    }

    public void insilisasiDatabase(String operandDatabaseName)
    {
        try
        {
            String databaseName = "AldesDB/"+operandDatabaseName+".dbaldes";
            lines1 = System.IO.File.ReadAllLines(databaseName);
        }
        catch(Exception e)
        {
            c("Ada Error : " + e.Message);
        }
        
    }

    public string terjemahkan(String operandString1)
    {   
       String returnValue="";
       Console.Write("Symbol Diperiksa = "); 
       returnValue+="\n---------------- JSON ----------------\n";
       int progres1=1;
            foreach (string line1 in lines1)
            {
                hitungProses(progres1);
                RecordTypeForKamus recordTypeForKamus1 = new RecordTypeForKamus();
                recordTypeForKamus1 = operasiMutilasi(line1);
                if(operandString1==recordTypeForKamus1.getPseudo())
                {
                    returnValue+= cetakJSON("Pseudo To HTML", operandString1 , recordTypeForKamus1.getHtml());
                    return returnValue;
                }
                else if (operandString1==recordTypeForKamus1.getHtml())
                {
                    returnValue+= cetakJSON("HTML To Pseudo", operandString1 , recordTypeForKamus1.getPseudo());
                    return returnValue;
                }

                progres1++;
            }

       returnValue+= cetakJSON("Ngga Ketemu", operandString1 , "Kayaknya Belum Ada Deh");
       return returnValue;
    }
    private String cetakJSON(String Operasi1, String Operand1, String Result1)
    {
                    string collectJson="";
                    collectJson+="{\n";
                    collectJson+="\t Operasi\t= '"+Operasi1+"'\n";
                    collectJson+="\t Operand\t= '"+Operand1+"'\n";
                    collectJson+="\t Result\t\t= '"+Result1+"'\n";
                    collectJson+= "\n}";

                    return collectJson;
    }
    private void hitungProses(int Operand1)
    {
                Console.Write(Operand1+"->");
    }
  private static RecordTypeForKamus operasiMutilasi(String operandLine)
  {
      RecordTypeForKamus recordTypeForKamus1 = new RecordTypeForKamus();
      string[] collection1 = operandLine.Split('=');
      recordTypeForKamus1.setPseudo(collection1[0]);
      recordTypeForKamus1.setHtml(collection1[1]);
      return recordTypeForKamus1;
  }


    public void tampil()
    {
         try
         {
            System.Console.WriteLine    ("--------------- Database Symbol ---------------");
            int incrementObject1=1;
            foreach (string line1 in lines1)
            {
            
            RecordTypeForKamus recordTypeForKamus1 = new RecordTypeForKamus();
            recordTypeForKamus1 = operasiMutilasi(line1);
            //CforPrint
            c("{");
            c("\t" + "pseudo \t= '" + recordTypeForKamus1.getPseudo() + "'\n\thtml \t= '" + recordTypeForKamus1.getHtml() +"'");
            c("}");

            if(incrementObject1<lines1.Length)
            {
                c(",");
            }

            incrementObject1++;
        }

        Console.WriteLine("Tekan Apa Saja Untuk Keluar");
        System.Console.ReadKey();
        }
        catch (Exception e)
        {
            c("Ada Error : "+e.Message);
        }
    }


  private void c(String txt)
  {
        Console.WriteLine(txt);
  }
    public void bacaDariFile()
    {
    
    }

}
}