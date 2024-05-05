using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo:"NK1220", imei:"111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Github");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "987654", modelo: "PlusX", imei: "222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");


// TODO: Realizar os testes com as classes Nokia e Iphone