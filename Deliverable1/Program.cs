
using System;

Console.WriteLine("Welcome to the restocking tool");
int SodaStock = 100;
int CandyStock = 40;
int ChipsStock = 60;
int PretzelsStock  = 50;

int SodaRestock = 0;
int CandyRestock = 0;
int ChipsRestock = 0;
int PretzelsRestock = 0;


Console.WriteLine("How many Sodas have been sold today? " + SodaStock +  " are in stock.");
SodaRestock = Convert.ToInt32(Console.ReadLine());
if (SodaRestock >= SodaStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted");
} else
{
    SodaStock -= SodaRestock;
    Console.WriteLine("There are " + SodaStock + " sodas left.");
}


Console.WriteLine("How much Candy has been sold today? " + CandyStock + " are in stock.");
CandyRestock = Convert.ToInt32(Console.ReadLine());
if (CandyRestock >= CandyStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}
else
{
    CandyStock -= CandyRestock;
    Console.WriteLine("There is " + CandyStock + " Candy left.");
}


Console.WriteLine("How many Chips have been sold today? " + ChipsStock + " are in stock.");
ChipsRestock = Convert.ToInt32(Console.ReadLine());
if(ChipsRestock >= ChipsStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}
else
{
    ChipsStock -= ChipsRestock;
        Console.WriteLine("There are " + ChipsStock + " chips left.");
}


Console.WriteLine("How many Pretzels have been sold today? " + PretzelsStock + " are in stock.");
PretzelsRestock = Convert.ToInt32(Console.ReadLine());
if (PretzelsRestock >= PretzelsStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}
else
{
    PretzelsStock -= PretzelsRestock;
    Console.WriteLine("There are " + PretzelsStock + " pretzels left.");
}

Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");

if (SodaRestock >= SodaStock)
{
    Console.WriteLine("Soda needs restocked");
}
if (CandyRestock >= CandyStock)
{
    Console.WriteLine("Candy needs restocked");
}
if (PretzelsRestock >= PretzelsStock)
{
    Console.WriteLine("Pretzels needs restocked");
}
if (ChipsRestock >= ChipsStock)
{
    Console.WriteLine("Chips needs restocked");
}

