using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Dio_poo.src.Entities
{
    public class Heroi
    {

        public Heroi(string Nome, String ClasseFantastica)
        {
            //os valores desta classe vao ser iguais aos valores fornecidos
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 50;
            this.PontosDeMagia = 50;
           // this.NomeDoPet = NomeDoPet;
        }
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int PontosDeVida { get; set; }
        
        public int PontosDeMagia { get; set; }

        public int ValorUltimoAtaque { get; set; }
        public string ClasseFantastica { get; set; }

        public override  string ToString()
        {
            return "Meu nome e: " + this.Nome + "\n"
                    + "Classe: " + this.ClasseFantastica + "\n"
                    + "Nivel: " + this.Nivel + "\n"
                    + "HP: " + this.PontosDeVida + "\n"
                    + "MP: " + this.PontosDeMagia + "\n";
        }

    public virtual string Atacar()
    {   
        Random dado = new Random();
        int forcaDoAtaque = this.Nivel + dado.Next(1, 20);
        this.ValorUltimoAtaque = forcaDoAtaque;
        return this.Nome + "ataca com sua espada e causa " + forcaDoAtaque + " de dano";
    }

        public void Receberdano(int danoRecebido)
        {
            this.PontosDeVida -= danoRecebido;
        }    



    }


}