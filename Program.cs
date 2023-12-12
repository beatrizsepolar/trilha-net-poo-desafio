using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "2199999999", modelo: "Nokia G60 5G", imei: "123456", memoria: 16);

nokia.Ligar();
nokia.InstalarAplicativo("Facebook");



Console.WriteLine("Smartfone iPhone:");
Smartphone iphone = new Iphone(numero: "21666666666", modelo: "iPhone 15 PRO MAX", imei: "8746235", memoria: 128);

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

