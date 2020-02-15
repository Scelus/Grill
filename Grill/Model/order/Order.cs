using System;
using System.Collections.Generic;
using System.Text;


class Order
{
    public int MeatOrder;
    public int BreadOrder;
    public int SaladOrder;

    public Order(int meat, int bread, int salad)
    {
        this.MeatOrder = meat;
        this.BreadOrder = bread;
        this.SaladOrder = salad;
    }
}

