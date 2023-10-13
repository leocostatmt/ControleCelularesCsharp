using DesafioPOO.Models;


Console.WriteLine("*****controle de instalação IPhone*****");
Iphone iphone = new Iphone("+55 13 996092345","modelo iphone","#34254354534", 164);
Console.WriteLine($"telefone {iphone.Numero} do seu IPhone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify®");

Console.WriteLine("\n");
Console.WriteLine("*****controle de instalação Nokia*****");
Nokia nokia = new Nokia("+55 13 990962734","G4","#1235461112", 512);
Console.WriteLine($"Telefone {nokia.Numero} do seu Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("HBOmax®");
// TODO: Realizar os testes com as classes Nokia e Iphone
