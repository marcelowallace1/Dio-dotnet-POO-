using System;
using Dio_poo.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Heroi Arus = new Heroi("Arus", "Guerreiro");
        Mago Wedge = new Mago("Wedge", "Mago Negro");
        Inimigo King = new Inimigo("King", "zumbi");


        System.Console.WriteLine(Arus.Atacar());
        System.Console.WriteLine(King.Atacar());

        if(Arus.ValorUltimoAtaque == King.ValorUltimoAtaque)
        {
            System.Console.WriteLine("Empate, ambos deram dano de " + Arus.ValorUltimoAtaque);
        }else if(Arus.ValorUltimoAtaque > King.ValorUltimoAtaque)
        {
            King.Receberdano(Arus.ValorUltimoAtaque - King.ValorUltimoAtaque);
            System.Console.WriteLine(Arus.Nome + "venceu esse round");
        }else
        {
            Arus.Receberdano(Arus.ValorUltimoAtaque - King.ValorUltimoAtaque);
            System.Console.WriteLine(King.Nome + "Venceu esta rodada");
        }

        


        // Console.WriteLine(Wedge.Atacar(20));
        // Console.WriteLine(Arus.Atacar());
        // Console.WriteLine(King.Atacar());
    }
}
