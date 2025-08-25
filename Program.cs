using DesafioPOO.Models;
//Testes implementados

Smartphone nokia = new Nokia("123456789", "Modelo 1", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("-------------");

Smartphone iphone = new Iphone("123456789", "Modelo 1", "1111111", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");
