using System;

/* Utilizando conceitos de herança, crie uma classe abstrata chamada Idioma com um
atributo chamado nomeDoIdioma e um método abstrato chamado saudacao() que imprime
o nome do idioma e uma saudação na tela, em seguida, crie as classes que herdam Idioma
e suas respectivas saudações:

Idioma Saudação
Português Olá Mundo
Inglês Hello World
Húngaro Helló Világ
Tcheco Ahoj Svete

Em seguida, crie uma classe com método Main , instancie as classes e chame o método
saudacao().*/

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassIdioma p = new ClassIdioma("Portugues"," Ola Mundo ");
            p.saudacao();
            ClassIdioma I = new ClassIdioma("Ingles"," Hello Word ");
            I.saudacao();
            ClassIdioma H = new ClassIdioma("Hungaro"," Helló Világ ");
            H.saudacao();
            ClassIdioma T = new ClassIdioma("Tcheco"," Ahoj Svete ");
            T.saudacao();


        }
    }
}






public class ClassIdioma : Idioma
{
    
    public ClassIdioma(string nomeDoIdioma, string tipoSaudacao)
    {
        this.NomeDoIdioma = nomeDoIdioma;
        this.TipoSaudacao = tipoSaudacao;
    }

    public override void saudacao()
    {
        Console.WriteLine(NomeDoIdioma +" "+TipoSaudacao);
    }
}



public abstract class Idioma
{
    private string nomeDoIdioma;
    public string NomeDoIdioma
    {
        get { return this.nomeDoIdioma; }
        set { this.nomeDoIdioma = value; }
    }
    


    private string tipoSaudacao;
    public string TipoSaudacao
    {
        get { return this.tipoSaudacao; }
        set { this.tipoSaudacao = value; }
    }
    
    

    public abstract void saudacao();

}
