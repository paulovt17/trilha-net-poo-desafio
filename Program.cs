using DesafioPOO.Models;

Console.WriteLine();

Console.WriteLine("NOKIA:");
Smartphone nokia = new Nokia(numero : "9999999", modelo : "Modelo 5.0", imei : "00000000", memoria : 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine();

Console.WriteLine("IPHONE:");
Smartphone iphone = new Iphone(numero: "1111111", modelo : "Modelo 2.0", imei : "77777777", memoria : 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
// IMPLEMENTADO!!!