//Primeiro Desafio
//Primeiro Desafio com POO
//1 / 1 - Primeiro Desafio com POO

/*
using System;

class Pessoa
{  

  private string nome;
  private int idade;

    public Pessoa(string n, int i)
    {

        nome = n;
        idade = i;

    }

    public string GetNome()
    {

        return nome;

    }

    public int GetIdade()
    {

        return idade;

    }
}
class Program
{
    static void Main()
    {
       string n = Console.ReadLine();
       int idade = int.Parse(Console.ReadLine());
       Pessoa p1 = new Pessoa(n, idade);      
       Console.WriteLine($"Nome: {n}, Idade: {idade}");
    }
}
*/









//Segundo desafio
//Utilizando Propriedades e Métodos
//1 / 1 - Controle de Velocidade do Robô

/*
using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] velocidades = Console.ReadLine().Split(' ');
        int vmin = int.Parse(velocidades[0]);
        int vmax = int.Parse(velocidades[1]);

        Robo rb = new Robo(vmin, vmax);

        string comandos = Console.ReadLine();

        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                rb.Acelerar();
            }
            else if (comando == 'D')
            {
                rb.Desacelerar();
            }
        }

        Console.WriteLine(rb.VelocidadeAtual);
    }
}
*/









//Terceiro desafio
//Criando um Objeto com Atributos
//1 / 1 - Criando um jogador de futebol

/*
using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador( string nome, string nacionalidade, int idade, string posicao )
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;

        Console.WriteLine();
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(Nome);
        Console.WriteLine(Nacionalidade);
        Console.WriteLine(Idade);
        Console.WriteLine($"Posição: {Posicao}");
        
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        string posicao = Console.ReadLine();

        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

    }
}
*/









//Quarto Desafio
//Utilizando Construtores
//1 / 1 - Criando seu Personagem

/*
using System;

class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    public Personagem(string nome, string raca, string classe)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

    public void ExibirStatus()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Raça:{Raca}");
        Console.WriteLine($"Classe:{Classe}");
        Console.WriteLine($"Nível:{Nivel}");
        Console.WriteLine($"Vida:{Vida}");
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string raca = Console.ReadLine();
        string classe = Console.ReadLine();

        Personagem personagem = new Personagem(nome, raca, classe);
        Console.WriteLine();
        Console.WriteLine("Status:");
        personagem.ExibirStatus();
    }
}
*/









//Quinto Desafio
//Utilizando Herança e Subclasses
//1 / 1 - A batalha dos RPGistas: herança e subclasse!

/*
using System;

class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

class Subclasse : Personagem
{
    public int DanoBase { get; set; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    public void CalcularDano()
    {
        Console.WriteLine($"{Nome} atacou e causou {DanoBase * Mana} de dano!");
    }
}

class Program
{
    static void Main()
    {
        string nome;
        int mana, danoBase;

        nome = Console.ReadLine();
        mana = int.Parse(Console.ReadLine());
        danoBase = int.Parse(Console.ReadLine());

        Subclasse subclasse = new Subclasse(nome, mana, danoBase);
        subclasse.CalcularDano();
    }
}
*/