using Eisdiele;


Eis eis1 = new Becher();
eis1 = new Schokokugel(eis1);

Eis eis2 = new Waffel();
eis2 = new Schokokugel(eis2);
eis2 = new Vanillekugel(eis2);
eis2 = new Sahne(eis2);

Console.WriteLine(eis1.GetDescription() + ", CHF : " + Math.Round(eis1.GetPrice(), 2));
Console.WriteLine(eis2.GetDescription() + ", CHF : " + Math.Round(eis2.GetPrice(), 2));