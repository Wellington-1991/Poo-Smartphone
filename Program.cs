using DesafioPOO.Models;


Nokia s = new Nokia("Nokia", "N-95", "NOKIA_1254_KI", 128);
s.Ligar();
s.Numero = "123456";
s.ReceberLigacao();
s.InstalarAplicativo("Doulingo");
Console.WriteLine(s.Numero);

Iphone i = new Iphone("Iphone", "12", "Iphone_1254_IP", 256);
i.Numero = "654321";
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("WhatssApp");
Console.WriteLine(i.Numero);
