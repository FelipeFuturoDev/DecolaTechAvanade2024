//Primeiro Desafio
//1 / 1 - Registro de Usuário
//Explorando Sintaxe e Tipos de Dados
/*
using System;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
    string registroEmail = "josesilvaneto546@gmail.com";
    string registroNome = "Jose";
    string senha = "8993";

// Obtém o email e nome do usuário a partir da entrada do console
    registroEmail = Console.ReadLine();
    registroNome = Console.ReadLine();


// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");


    }
}
*/






//Segundo Desafio
//Dominando os Operadores
//1 / 1 - Gerenciamento de Tarefas


/*
using System;

class Program
{
    static void Main()
    {

// TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
     string titulo;
     string descricao;
     string dataVencimento;
        
 // Obtém o titulo e a descricao a partir da entrada do console  
    titulo = Console.ReadLine();
    descricao = Console.ReadLine();
    //dataVencimento = Console.ReadLine();

// TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
     if (descricao.Length > 50) {
            Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        }
        else
        {
 // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
    dataVencimento = Console.ReadLine();


 // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:            
         Console.WriteLine(descricao + " ate " + dataVencimento); 
        }
    }
}
*/








//Terceiro Desafio
//Desvendando o Controle de Fluxo
//1 / 1 - Soma de Números Pares em Intervalo

/*
using System;

class Program
{
    static void Main()
    {
    // Solicita ao usuário os limites inferiores e superiores
    int limiteInferior = int.Parse(Console.ReadLine());
    int limiteSuperior = int.Parse(Console.ReadLine());

    // Variável para acumular a soma dos números pares
    int somaPares = 0;

    // TODO: Crie um Loop para percorrer os números no intervalo
    // Lembre-se: O limiteSuperior deve ser menor ou igual a i;
    
    // TODO: Implemente o if para verificar se o número é par:
        
    
    // TODO: Crie o acumulador para a soma dos números pares:
    for( int index = limiteInferior; index <= limiteSuperior; index++)
    {
        if( index % 2 == 0)
        {
          somaPares += index;
        }
    }
           
    

    // Exibe o resultado
    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}
*/









//Quarto Desafio
//Utilizando Array e Listas
//1 / 1 - Catálogo de Jogos
/*
using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());


        // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
       string[] nomesJogos = new string [quantidadeJogos]; 
       
       // TODO: Criar um Loop para adicionar jogos
        for(int i = 0; i < quantidadeJogos; i++)
        {
          
          AdicionarJogo(i, nomesJogos);
          
        }        
           ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
        
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {   
       string listadejogos = string.Join(", ",nomes);
      
       Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {listadejogos} ao catalogo.");
        
    }
}
*/









//Quinto Desafio
//Manipulando Funções
//1 / 1 - Cálculo de Pegada de Carbono

/*
using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        //Console.ReadLine();
    }
    
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
      double fatorTransporte = 0.2;
      double fatorEletronicos =  0.1;
      double fatorCarne = 0.5;
      
      double pegadaDeCarbono = ( quilometrosPorDia * 365 * fatorTransporte) +
                               ( horasDeEletronicos * fatorEletronicos) +
                               (refeicoesComCarne * fatorCarne);
                             
       return pegadaDeCarbono;
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
  

}
*/
