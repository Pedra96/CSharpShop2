using CSharpShop2;


var Prodotto1= new Elettrodomestico("Fornello",12,23,4,12,"europea","bosh","Fornello da cucina ad induzione");
var Prodotto2 = new Acqua(1.456,4.67832,"Acqua Naturale",2,200,4,"bottiglia d'acqua bella fresca","ghiacciaio dietro casa mia è buona fidati");
Prodotto1.StampaProdotto();
Prodotto2.StampaProdotto();

Prodotto2.SvuotaBottiglia();
Console.WriteLine(Prodotto2.GetLitri());
Prodotto2.RiempiBottiglia(-0.4);
Console.WriteLine(Prodotto2.GetLitri());
Prodotto2.BeviAcqua(-1);