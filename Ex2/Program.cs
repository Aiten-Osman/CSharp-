

double priceForParty= double.Parse(Console.ReadLine());
int numPoslanie= int .Parse(Console.ReadLine());    
int numRose= int .Parse(Console.ReadLine());    
int numKluch= int .Parse(Console.ReadLine());    
int numCaricat= int .Parse(Console.ReadLine());    
int numSuprice= int .Parse(Console.ReadLine());

double moneyPOslanie = numPoslanie * 0.60;
double moneyRose = (numRose * 7.20);
double moneyKluch = numKluch * 3.60;
double moneyCapr = numCaricat * 18.20;
double moneySyprice = numSuprice * 22.00;




double money = moneyPOslanie + moneyRose + moneyKluch + moneyCapr + moneySyprice;

int allArticuls= numPoslanie+numRose+numKluch+ numCaricat+numSuprice;

if (allArticuls>=25)
{
    money= money - (money*0.35);
}
else
{
    money = money;
}

double casting = 0.1 * money;

double win= money - casting;

if (win > priceForParty)

    Console.WriteLine($"Yes! {win - priceForParty:f2} lv left.");

else
    Console.WriteLine($"Not enough money! {priceForParty - win:f2} lv needed.");