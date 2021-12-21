using System;

abstract class Car
{
    public string Name { get; set; }

    public Car(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Toyota : Car
{
    public int Year { get; set; }

    public Toyota(string name, int year)
        : base(name)
    {
        Year = year;
    }
    public override void Display()
    {
        Console.WriteLine($"Toyota {Name} Year: {Year}");
    }
}

class Mitsubishi : Car
{
    public string Model { get; set; }

    public Mitsubishi(string name, string model)
        : base(name)
    {
        Model = model;
    }

    public override void Display()
    {
        Console.WriteLine($"Mitsubishi {Name} Model: {Model}");
    }

    public static void Main(string[] args)
    {

        Toyota toyota = new Toyota("Supra", 1998);
        Mitsubishi mitsubishi = new Mitsubishi("Evo Lancer", "Sedan");
        toyota.Display();
        mitsubishi.Display();
        Rifle rifle = new Rifle("AKM", 350);
        Pistol pistol = new Pistol("Beretta", "92FS");
        rifle.Display();
        pistol.Display();
        Smartphone smartphone = new Smartphone("Huawei", "HiSilicon Kirin 655");
        Basic basic = new Basic("Siemens", "C65");
        smartphone.Display();
        basic.Display();
        Skyline skyline = new Skyline("Skyline R34", "2.6 L twin-turbocharged RB26DETT I6");
        Silvia silvia = new Silvia("Silvia S15", "6-speed manual gearbox");
        skyline.Display();
        silvia.Display();
        Eminem eminem = new Eminem("Eminem", 15);
        Kendrick kendrick = new Kendrick("Kendrick Lamar", "Humble");
        eminem.Display();
        kendrick.Display();


    }
}
abstract class Gun
{
    public string Name { get; set; }

    public Gun(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Rifle : Gun
{
    public int EFR { get; set; }

    public Rifle(string name, int efr)
        : base(name)
    {
        EFR = efr;
    }
    public override void Display()
    {
        Console.WriteLine($"Rifle {Name} Effective firing range: {EFR}m");
    }
}

class Pistol : Gun
{
    public string Model { get; set; }

    public Pistol(string name, string model)
        : base(name)
    {
        Model = model;
    }

    public override void Display()
    {
        Console.WriteLine($"Pistol {Name} Model: {Model}");
    }

   
}
abstract class Phone
{
    public string Name { get; set; }

    public Phone(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Smartphone : Phone
{
    public string Processor { get; set; }

    public Smartphone(string name, string processor)
        : base(name)
    {
        Processor = processor;
    }
    public override void Display()
    {
        Console.WriteLine($"Smartphone {Name} Processor: {Processor}m");
    }
}

class Basic : Phone
{
    public string Model { get; set; }

    public Basic(string name, string model)
        : base(name)
    {
        Model = model;
    }

    public override void Display()
    {
        Console.WriteLine($"Basic phone {Name} Model: {Model}");
    }


}
abstract class Nissan
{
    public string Name { get; set; }

    public Nissan(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Skyline : Nissan
{
    public string Engine { get; set; }

    public Skyline(string name, string engine)
        : base(name)
    {
        Engine = engine;
    }
    public override void Display()
    {
        Console.WriteLine($"Nissan {Name} Engine: {Engine}");
    }
}

class Silvia : Nissan
{
    public string Transmission { get; set; }

    public Silvia(string name, string transmission)
        : base(name)
    {
        Transmission = transmission;
    }

    public override void Display()
    {
        Console.WriteLine($"Nissan {Name} Transmission: {Transmission}");
    }


}
abstract class Rapper
{
    public string Name { get; set; }

    public Rapper(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Eminem : Rapper
{
    public int Grammys { get; set; }

    public Eminem(string name, int grammys)
        : base(name)
    {
        Grammys = grammys;
    }
    public override void Display()
    {
        Console.WriteLine($"{Name} Grammys: {Grammys}");
    }
}

class Kendrick : Rapper
{
    public string Fsong { get; set; }

    public Kendrick(string name, string fsong)
        : base(name)
    {
        Fsong = fsong;
    }

    public override void Display()
    {
        Console.WriteLine($"{Name} Famous song: {Fsong}");
    }


}