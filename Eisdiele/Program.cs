using Eisdiele;


Eis Eis1 = new Becher();
Eis1 = new Schokokugel(Eis1);

Eis Eis2 = new Waffel();
Eis2 = new Schokokugel(Eis2);
Eis2 = new Vanillekugel(Eis2);
Eis2 = new Sahne(Eis2);

Console.WriteLine(Eis1.GetDescription() + ", CHF : " + Eis1.GetPrice());