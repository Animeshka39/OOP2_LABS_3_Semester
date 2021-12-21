using System;

abstract class Communication
{
    public string Name { get; set; }
    public int Distance { get; set; }
    public string Spmethod { get; set; }
    public string Mcformation { get; set; }
    public string Sencoding { get; set; }
    public string Ctype { get; set; }

    public Communication(string name,int distance,string spmethod, string mcformation, string sencoding, string сtype)
    {
        Name = name;          //name of communication equipment
        Distance = distance;  //signal distance
        Spmethod = spmethod;  //signal propagation method
        Mcformation = mcformation; //means of channel formation
        Sencoding = sencoding; //signal encoding
        Ctype = сtype; //channel type
    }

    public abstract void Display();
}

class Military : Communication
{
    private int Year { get; set; }

    public Military(string name, int year, int distance, string spmethod, string mcformation, string sencoding, string сtype)
        : base(name,distance,spmethod,mcformation,sencoding,сtype)
    {
        Year = year;
    }
    public override void Display()
    {
        Console.WriteLine($"Military communication equipment {Name} \nYear: {Year} \nSignal distance: {Distance}km \nSignal propagation method: {Spmethod} \nMeans of channel formation: {Mcformation} \nSignal encoding: {Sencoding} \nChannel type: {Ctype}");
    }
}

class Exoteric : Communication
{
    private int Price { get; set; }

    public Exoteric(string name, int price, int distance, string spmethod, string mcformation, string sencoding, string сtype)
        : base(name, distance, spmethod, mcformation, sencoding, сtype)
    {
        Price = price;
    }

    public override void Display()
    {
        Console.WriteLine($"\nExoteric Communication equipment {Name} \nPrice: {Price}$ \nSignal distance: {Distance}km \nSignal propagation method: {Spmethod} \nMeans of channel formation: {Mcformation} \nSignal encoding: {Sencoding} \nChannel type: {Ctype}");
    }

    public static void Main(string[] args)
    {

        Military military = new Military("ТА-57", 1957, 40,"Wire","Wire","Classified","Telephone channel");
        Exoteric exoteric = new Exoteric("Walkie-talkie",1000,5,"Wireless", "Radio", "Not classified", "Radio channel");
        military.Display();
        exoteric.Display();
    }
}