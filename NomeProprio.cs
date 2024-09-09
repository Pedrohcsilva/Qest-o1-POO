using System;

public class NomeProprio
{
    private string nomeCompleto;
    private string nomePaper;


    public NomeProprio(string nomeCompleto)
    {
        this.nomeCompleto = nomeCompleto;
        GerarNomePaper();
    }

    public NomeProprio(string nomeCompleto, string nomePaper)
    {
        this.nomeCompleto = nomeCompleto;
        this.nomePaper = nomePaper;
    }

    private void GerarNomePaper()
    {
        string[] nomes = nomeCompleto.Split(' ');

        string sobrenome = nomes[nomes.Length - 1];

        string primeiroNome = nomes[0];

        string inicialMeio = "";
        if (nomes.Length > 2)
        {
            inicialMeio = nomes[1];
            if (!inicialMeio.EndsWith("."))
            {
                inicialMeio += ".";
            }
        }
        nomePaper = $"{sobrenome}, {primeiroNome} {inicialMeio}";
    }

    public void ImprimeNomePaper()
    {
        Console.WriteLine(nomePaper);
    }
}
