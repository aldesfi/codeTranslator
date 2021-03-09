using System;

public class RecordTypeForKamus
{
    String pseudo1;
    String html1;

    public RecordTypeForKamus()
    {
     
    }

    public string getPseudo()
    {
        return this.pseudo1;
    }

    public void setPseudo(String operandPseudo)
    {
        this.pseudo1 = operandPseudo;
    }

    public string getHtml()
    {
        return this.html1;
    }

    public void setHtml(String operandHtml)
    {
        this.html1 = operandHtml;
    }
}