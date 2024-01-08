using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

//Smartphone Nokia
Nokia smartphone1 = new(numero: "12340000", modelo: "nokiaa", imei: "abcd1234", memoria: 1024);

//Smartphone Apple
Iphone smartphone2 = new(numero: "981445500", modelo: "iphonee", imei: "ssdd8899", memoria: 1024);


Console.WriteLine("Smartphone Nokia:");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphoe Iphone:");
smartphone1.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo(nomeApp: "Signal");
