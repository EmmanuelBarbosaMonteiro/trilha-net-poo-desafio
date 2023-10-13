using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 12", imei: "987654321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");