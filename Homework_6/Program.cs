using System;

abstract class Plant
{
    public string Name { get; set; }
    public double Water { get; set; }
    public int Light { get; set; }

    public Plant(string name, double water, int light)
    {
        Name = name;
        Water = water;
        Light = light;
    }

    public Plant(string name, int light)
    {
        Name = name;
        Water = 1;
        Light = light;
    }

    public abstract string TypeName { get; }

    public virtual void Water_()
    {
        Console.WriteLine(Name + " полит. Расход: " + Water + " л/нед.");
    }

    public virtual void Prune()
    {
        Console.WriteLine(Name + " обрезан.");
    }

    public virtual void Replant()
    {
        Console.WriteLine(Name + " пересажен.");
    }

    public virtual void ShowCare()
    {
        Console.WriteLine(TypeName + " " + Name + ": полив " + Water + " л, свет " + Light + "%");
    }

    public abstract double CalcFertilizer();

    public virtual void Print()
    {
        Console.WriteLine(TypeName + ": " + Name + ", полив " + Water + " л, свет " + Light + "%");
    }
}

class Flower : Plant
{
    public string Color { get; set; }
    public string BloomSeason { get; set; }

    public Flower(string name, double water, int light, string color, string bloomSeason)
        : base(name, water, light)
    {
        Color = color;
        BloomSeason = bloomSeason;
    }

    public Flower(string name, int light, string color)
        : base(name, light)
    {
        Color = color;
        BloomSeason = "лето";
    }

    public override string TypeName => "Цветок";

    public override double CalcFertilizer() => Math.Round(Water * 0.5, 1);

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Цвет: " + Color + ", сезон: " + BloomSeason);
    }
}

class Bush : Plant
{
    public bool Berry { get; set; }
    public double Spread { get; set; }

    public Bush(string name, double water, int light, bool berry, double spread)
        : base(name, water, light)
    {
        Berry = berry;
        Spread = spread;
    }

    public Bush(string name, int light, bool berry)
        : base(name, light)
    {
        Berry = berry;
        Spread = 50;
    }

    public override string TypeName => "Кустарник";

    public override double CalcFertilizer() => Math.Round(Water * 0.8 + (Berry ? 10 : 0), 1);

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Плодоносит: " + (Berry ? "да" : "нет") + ", диаметр: " + Spread + " см");
    }
}

class Tree : Plant
{
    public int Age { get; set; }
    public double Height { get; set; }

    public Tree(string name, double water, int light, int age, double height)
        : base(name, water, light)
    {
        Age = age;
        Height = height;
    }

    public Tree(string name, int light, int age)
        : base(name, light)
    {
        Age = age;
        Height = 100;
    }

    public override string TypeName => "Дерево";

    public override double CalcFertilizer() => Math.Round(Water * 0.1 + Age * 2, 1);

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Возраст: " + Age + " лет, высота: " + Height + " см");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Flower rose = new Flower("Роза", 3.5, 90, "красный", "лето");

        Console.WriteLine("Введите кустарник (имя;полив;свет;плодоносит;диаметр):");
        string line = Console.ReadLine();
        string[] parts = line.Split(';');
        Bush currant = new Bush(parts[0], double.Parse(parts[1]), int.Parse(parts[2]),
                                bool.Parse(parts[3]), double.Parse(parts[4]));

        Console.Write("Имя дерева: "); string tName = Console.ReadLine();
        Console.Write("Полив: "); double tW = double.Parse(Console.ReadLine());
        Console.Write("Свет: "); int tL = int.Parse(Console.ReadLine());
        Console.Write("Возраст: "); int tA = int.Parse(Console.ReadLine());
        Console.Write("Высота: "); double tH = double.Parse(Console.ReadLine());

        Tree oak = new Tree(tName, tW, tL, tA, tH);

        Plant[] garden = new Plant[] { rose, currant, oak };

        Console.WriteLine("Объекты сада:");
        foreach (var p in garden) p.Print();

        Console.WriteLine("Полив:");
        foreach (var p in garden) p.Water_();

        Console.WriteLine("Обрезка:");
        foreach (var p in garden) p.Prune();

        Console.WriteLine("Пересадка:");
        foreach (var p in garden) p.Replant();

        Console.WriteLine("График ухода:");
        foreach (var p in garden) p.ShowCare();

        Console.WriteLine("Удобрения:");
        foreach (var p in garden)
            Console.WriteLine(p.Name + ": " + p.CalcFertilizer() + " г");

        Flower secondRose = new Flower("Вторая роза", 60, "белый");
        Console.WriteLine("Второй конструктор цветка:");
        secondRose.Print();

        Bush secondBush = new Bush("Второй куст", 40, true);
        Console.WriteLine("Второй конструктор кустарника:");
        secondBush.Print();

        Tree secondTree = new Tree("Второе дерево", 50, 5);
        Console.WriteLine("Второй конструктор дерева:");
        secondTree.Print();
    }
}