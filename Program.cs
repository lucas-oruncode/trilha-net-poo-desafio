using DesafioPOO.Models;

Iphone iphone = new("999-999-999", "14S", "nem sei", 16);
Nokia nokia = new("888-888-888", "Q3", "meizin", 8);

Console.WriteLine("========= IPHONE =========");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iZap");

Console.WriteLine("========= NOKIA =========");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Orkut");