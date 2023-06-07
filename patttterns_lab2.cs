using System;
using System.Collections.Generic;

// Прототип (Строительный материал)
abstract class BuildingMaterialPrototype
{
    public abstract BuildingMaterialPrototype Clone();
    public abstract void Accept(Visitor visitor);
}

// Конкретный прототип (Кирпич)
class Brick : BuildingMaterialPrototype
{
    public string Type { get; set; }

    public Brick(string type)
    {
        Type = type;
    }

    public override BuildingMaterialPrototype Clone()
    {
        return (BuildingMaterialPrototype)MemberwiseClone();
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitBrick(this);
    }
}

// Конкретный прототип (Дерево)
class Wood : BuildingMaterialPrototype
{
    public string Type { get; set; }

    public Wood(string type)
    {
        Type = type;
    }

    public override BuildingMaterialPrototype Clone()
    {
        return (BuildingMaterialPrototype)MemberwiseClone();
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitWood(this);
    }
}

// Посетитель (Покупатель)
interface Visitor
{
    void VisitBrick(Brick brick);
    void VisitWood(Wood wood);
}

// Конкретный посетитель (Строитель)
class Builder : Visitor
{
    public void VisitBrick(Brick brick)
    {
        Console.WriteLine($"Строитель использует кирпич типа {brick.Type}");
    }

    public void VisitWood(Wood wood)
    {
        Console.WriteLine($"Строитель использует дерево типа {wood.Type}");
    }
}

// Магазин стройматериалов
class BuildingMaterialsStore
{
    private Dictionary<string, BuildingMaterialPrototype> _prototypes = new Dictionary<string, BuildingMaterialPrototype>();

    public BuildingMaterialPrototype this[string key]
    {
        get { return _prototypes[key].Clone(); }
        set { _prototypes[key] = value; }
    }
}

// Пример использования
class Program
{
    static void Main(string[] args)
    {
        // Создание магазина стройматериалов
        BuildingMaterialsStore store = new BuildingMaterialsStore();

        // Инициализация прототипов строительных материалов
        Brick redBrick = new Brick("Красный");
        Wood oakWood = new Wood("Дуб");

        store["Кирпич"] = redBrick;
        store["Дерево"] = oakWood;

        // Создание копий материалов для клиентов
        BuildingMaterialPrototype clientBrick = store["Кирпич"].Clone();
        BuildingMaterialPrototype clientWood = store["Дерево"].Clone();

        // Посетитель - строитель
        Builder builder = new Builder();

        // Использование копий материалов клиентом
        clientBrick.Accept(builder);
        clientWood.Accept(builder);

        Console.ReadLine();
    }
}