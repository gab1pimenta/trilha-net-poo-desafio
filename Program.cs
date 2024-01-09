using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia (numero: "996112228", modelo: "G11 Plus", imei: "00012345", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone: ");
Iphone iphone = new Iphone (numero: "998114298", modelo: "15 Pro Max", imei: "00054321", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("TikTok");