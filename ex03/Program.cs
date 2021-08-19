using System;

/*
Crie uma classe Abstrata chamada Animal com os atributos nome e peso, sendo que no
construtor você deverá passar o nome e o peso do animal e crie dois métodos abstratos:
som() e quantidadeDeRacao() . Em seguida, crie duas classes herdando de Animal: Cachorro
e Gato.
• O método som() deverá retornar o som que cada animal faz. (“auau” para cachorro e
“miau” para gato)
• O método quantidadeDeRacao() deverá retornar quanta ração o animal come por
dia, observando as seguintes regras
o Gatos abaixo ou igual a 4kg consomem 12g por cada kg do seu peso
o Gatos acima de 4kg consomem 15g por cada kg do seu peso
o Cachorros abaixo ou igual a 3kg consomem 35g por cada kg do seu peso
o Cachorros acima 3kg e abaixo ou igual a 10kg consomem 45g por cada kg do
seu peso
o Cachorros acima de 10kg consomem 50g por cada kg do seu peso
• Exemplos:
o Um gato de 5kg consome: 15 x 5 = 75g de ração por dia
o Um cachorro de 7kg consome: 45 x 7 = 315g de ração por dia


Crie uma classe com método Main(), e crie os seguintes: animais:
• Uma gata de 20kg chamada Coca
• Uma gata de 3kg chamada Foxy
• Um cachorro de 10kg chamado Einstein
• Um gato de 5kg chamado Edward
Some a quantidade de ração consumida por todos os animais e exiba na tela.

*/

namespace ex03
{
class Program
{
    static void Main(string[] args)
    {
        Gato coca = new Gato("Coca", 20);
        Gato foxy = new Gato("Foxy", 3);
        Cachorro einstein = new Cachorro("Einstein", 10);
        Gato edward = new Gato("Edward", 5);

        Animal[] animais = {coca, foxy, einstein, edward};

        int quantidadeDiariaRacao = 0;

        foreach (var animal in animais)
        {
            quantidadeDiariaRacao += animal.quantidadeDeRacao();
        }

        Console.WriteLine($"Serão consumidos {quantidadeDiariaRacao}g por dia");

        
    }
}
}





public abstract class Animal
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public Animal(string nome, int peso)
        {
            Nome = nome;
            Peso = peso;
        }
        public abstract void som();
        public abstract int quantidadeDeRacao();
    }


public class Cachorro : Animal
    {
        public Cachorro(string nome, int peso) : base(nome, peso)
        {
        }

        public override int quantidadeDeRacao()
        {
            if (Peso <= 3)
            {
                return 35 * Peso;
            }
            else if (Peso > 3 && Peso <= 10)
            {   
                return 45 * Peso;
            }
            return 50 * Peso;
        }

        public override void som()
        {
            Console.WriteLine("auau");
        }
    }

public class Gato : Animal
    {
        public Gato(string nome, int peso) : base(nome, peso)
        {
        }

        public override int quantidadeDeRacao()
        {
            if (Peso <= 4)
                return 12 * Peso;

            return 15 * Peso;;
        }

        public override void som()
        {
            Console.WriteLine("miau");
        }
    }    
