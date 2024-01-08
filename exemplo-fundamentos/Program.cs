using exemplo_fundamentos.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("PE");
listaString.Add("BA");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");




// Console.WriteLine("Percorrendo a lista com o FOR\n");

// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}"); 
// }

// Console.WriteLine("\nPercorrendo a lista com o FOREACH\n");

// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {item}"); 
//     contadorForeach++;
// }










// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 74;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o array com o FOR\n");

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }





















// Console.WriteLine("\nPercorrendo o array com o FOREACH\n");

// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach}- {valor}");
//     contadorForeach++;
// }







// string? opcao;
// bool exibirMenu = true; 

// while (exibirMenu)
// { 
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 -Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente"); 
//             break;
            
//         case "2":
//             Console.WriteLine("Buscar cliente"); 
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente"); 
//             break;
        
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
            
//     }
// }

// Console.WriteLine("O seu programa se encerrou.");










// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para para): ");
//     numero = Convert.ToInt32( Console.ReadLine());

//     soma += numero;
// } while (numero != 0);


// Console.WriteLine($"Total da soma dos números digitados é: {soma}");















// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 5)
//     {
//         break;
//     }
// }








// int numero = 5;

// for(int contador = 0; contador <= 10; contador++) 
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }











// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);
// Console.WriteLine($"Incrementando o {numeroIncremento}");
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);
// Console.WriteLine($"Decrementando o {numeroDecremento}");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);



















// Calculadora calc = new Calculadora();

// calc.Somar(10,30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);















// bool choveu = false;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }















// bool presencaMinima = false;
// double media = 7.5;

// if (presencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }


















// bool maiorIdade = false;
// bool autorizacaoResponsavel = true;

// if (maiorIdade || autorizacaoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!"); 
// }





















// Console.WriteLine("Digite uma letra: ");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine($"A letra {letra} é vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;
// }

















// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" || 
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal.");
// }
// else
// {
//     Console.WriteLine("Não é vogal.");
// }






















// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// string resposta;

// if (possivelVenda)
// {
//     resposta = "Sim.";
// }
// else
// {
//     resposta = "Não.";
// }

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {resposta}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }








// string a = "15-";
// //int b = 0;

// int.TryParse(a, out int b); // tenta converter o "a", se não conseguir, exibe "b" como resultado

// Console.WriteLine(b);







// double a = 4 / (2 + 2);

// Console.WriteLine(a);







//cast implícito

//  int a = 5;
//  double b = a;

// long a = 5;
// int b = Convert.ToInt32(a);

// Console.WriteLine(b);














// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);






//cast - casting
// int a = Convert.ToInt32(null); //mais indicado para casting, pois caso o valor venha nulo a aplicação não para 

// // int a = int.Parse(null);


// Console.WriteLine(a);











// int a = 10;
// int b = 20;

// int c = a + b;

// // c = c + 5; //30 + 5

// // c += 5;

// //c = c - 5;

// // c -= 5;

// Console.WriteLine(c);










// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);

// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);



// Pessoa p = new Pessoa();

// p.Nome = "Neto";
// p.Idade = 18;
// p.Apresentar();