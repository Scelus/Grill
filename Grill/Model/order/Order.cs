using System;
using System.Collections.Generic;
using System.Text;


class Order
{
    public Meat MeatOrder;
    public Bread BreadOrder;
    public Salad SaladOrder;

    public enum Meat { Meatloaf, Steak, Burger };
    public enum Bread { WhiteBread, WholeGrainBread };
    public enum Salad { RussianSalad, SnowWhiteSalad, TomatoesAndCucumberSalad, CarrortsAndCabbageSalad }

    public Order(Meat meat, Bread bread, Salad salad)
    {
        this.MeatOrder = meat;
        this.BreadOrder = bread;
        this.SaladOrder = salad;
    }
}

