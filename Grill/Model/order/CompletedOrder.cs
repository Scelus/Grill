using System;
using System.Collections.Generic;
using System.Text;


class CompletedOrder
{
    public Product Meat { get; }
    public Product Bread { get; }
    public Product Salad { get; }

    public CompletedOrder(Product meat, Product bread, Product salad)
    {
        this.Meat = meat;
        this.Bread = bread;
        this.Salad = salad;
    }
}