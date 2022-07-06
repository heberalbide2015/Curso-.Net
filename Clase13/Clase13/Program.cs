using Clase13.Modelo;

Billetera billetera1 = new Billetera(1, 1, 1, 1, 1, 1, 1);

Billetera billetera2 = new Billetera(2, 0, 0, 1, 0, 0, 0);
Billetera billeteraaux = billetera1;
billetera1.BilletesDe10 = 45;
Console.WriteLine(billetera1.BilletesDe10);
Console.WriteLine(billeteraaux.BilletesDe10);
Console.WriteLine($"La billetera 1 contiene ${billetera1.Total()}");
Console.WriteLine($"La billetera 2 contiene ${billetera2.Total()}");
Billetera billetera3 = billetera1.Combinar(billetera2);
Console.WriteLine();
Console.WriteLine("Se procede a combinar ambas billeteras");
Console.WriteLine($"La billetera 1 contiene ${billetera1.Total()}");
Console.WriteLine($"La billetera 2 contiene ${billetera2.Total()}");
Console.WriteLine($"La billetera 3 contiene ${billetera3.Total()}");