using System;
using System.Collections.Generic;

class Bike
{
    public string color = "Колір не змінили";
    private Wheels wheels;
    private Pedals pedals;
    private Rudder rudder;
    private Frame frame;
    public string name = "Ім'я не задано";
    public int speeed = 0;
    public string wheeels = "Модель колес не задана";

    public Bike(string name, Wheels wheels, Pedals pedals, Rudder rudder, Frame frame)
    {
        this.wheels = wheels;
        this.pedals = pedals;
        this.rudder = rudder;
        this.frame = frame;
        this.name = name;
    }
    public void Move()
    {
        Console.WriteLine($"Велосипед {name} починає рух");
    }
    public void SpeedUp(int speeed)
    {
        this.speeed = speeed;
        Console.WriteLine($"Швидкість була збільшена до {speeed} км/год");
    }
    public void ChangeWheels(string wheeels)
    {
        this.wheeels = wheeels;
        Console.WriteLine($"Колеса замінені на : {wheeels} ");
    }
    public void PaintBike(string color)
    {
        this.color = color;
        Console.WriteLine($"Велосипед було пофарбовано у {color}");
    }

    public override string ToString()
    {
        return $"\nМодель: {name} \nКолеса : {wheels} \nПедалі : {pedals} \nКермо : {rudder} \nРама : {frame} ";
    }

}
class Wheels
{
    public int diam;
    public Wheels(int diam)
    {
        this.diam = diam;
    }
    public override string ToString()
    {
        return $"Діаметр коліс {diam}'";
    }
}
class Frame
{
    public string model;
    public int first;
    public int second;
    public Frame(string model, int first, int second)
    {
        this.model = model;
        this.first = first;
        this.second = second;
    }
    public override string ToString()
    {
        return $"Модель рами - {model}, Розміри рами - {first}'{second}' ";
    }
}
class Rudder
{
    public string material;
    public double diam;
    public double width;
    public Rudder(string material, double diam, double width)
    {
        this.material = material;
        this.diam = diam;
        this.width = width;
    }
    public override string ToString()
    {
        return $"Матеріал - {material}, Діаметр - {diam}, Ширина - {width} мм";
    }

}
class Pedals
{
    public double length;
    public double width;
    public double height;
    public Pedals(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
    public override string ToString()
    {
        return $"Довжина педалей - {length}мм, ширина педалей - {width}мм, висота педалей - {height}мм";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Wheels wheels = new Wheels(26);
        Frame frame = new Frame("Spark Rough", 18, 20);
        Rudder rudder = new Rudder("Сталь", 25.4, 620);
        Pedals pedals = new Pedals(108, 108, 27);
        Bike bike = new Bike("Spark Rough 2021", wheels, pedals, rudder, frame);
        bike.Move();
        bike.SpeedUp(25);
        bike.PaintBike("чорний");
        bike.ChangeWheels("Pride Rocksteady");
        Console.WriteLine(bike);
    }
}

