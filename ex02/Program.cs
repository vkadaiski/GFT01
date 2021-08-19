using System;

/*
Crie um programa para mostrar qual presente o funcionário vai receber.
• Esse programa deverá receber o ano de entrada deste funcionário e considerar o ano
atual (2021)
• Os presentes são:
o 1 ano = Vale Presente
o 2 anos = Smart Watch
o 5 anos = Fone Bluetooth
o 10 anos = Vale Jantar
o 15 anos = Vale Jantar Top
• Caso o funcionário não esteja dentro de nenhum desses anos, o programa deverá
imprimir em tela: “Esse ano não vai ter presente”
*/

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {   
            int AnoEntrada;
            
            Console.WriteLine("Vamos descobri qual o seu presente!?");
            Console.WriteLine("Digite em qual ano voce entrou na GFT, lembre-se de colocar o ano completo! EX: 2020");
            AnoEntrada = Convert.ToInt32(Console.ReadLine());

            int Ano = DateTime.Now.Year - AnoEntrada;

            switch (Ano)
            {
                case 1:
                    Console.WriteLine("Parabens Voce Ganhou um Vale Presente!");
                    break;
                case 2:
                    Console.WriteLine("Parabens Voce Ganhou um Smart Watch");
                    break;
                case 5:
                    Console.WriteLine("Parabens Voce Ganhou um Fone Bluetooth");
                    break;
                case 10:
                    Console.WriteLine("Parabens Voce Ganhou um Vale Jantar");
                    break;
                case 15:
                    Console.WriteLine("Parabens Voce Ganhou um Vale Jantar Top");
                    break;
                default:
                    Console.WriteLine("Esse ano não vai ter presente");
                    break;
            }
            

        }

        


        
    }
}



