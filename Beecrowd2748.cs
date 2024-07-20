using System;

class Program
{
    static void Main(string[] args)
    {
        int totalTracos = 39;
        int posicaoTexto = 8;

        Console.WriteLine(new string('-', totalTracos));

        ImprimirLinhaFormatada("Roberto", totalTracos, posicaoTexto);
        ImprimirLinhaEmBranco(totalTracos);
        ImprimirLinhaFormatada("5786", totalTracos, posicaoTexto);
        ImprimirLinhaEmBranco(totalTracos);
        ImprimirLinhaFormatada("UNIFEI", totalTracos, posicaoTexto);

        Console.WriteLine(new string('-', totalTracos));
    }

    static void ImprimirLinhaFormatada(string texto, int totalTracos, int posicaoTexto)
    {
        string linhaFormatada = "|" + texto.PadLeft(posicaoTexto + texto.Length).PadRight(totalTracos - 2) + "|";
        Console.WriteLine(linhaFormatada);
    }

    static void ImprimirLinhaEmBranco(int totalTracos)
    {
        Console.WriteLine("|" + new string(' ', totalTracos - 3) + " |");
    }
}
