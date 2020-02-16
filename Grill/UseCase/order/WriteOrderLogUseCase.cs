using System;
using System.Collections.Generic;
using System.Text;

class WriteOrderLogUseCase : UseCase<Boolean>
{

    public WriteOrderLogUseCase(CompletedOrder order)
    {
        this.Order = order;
    }

    public CompletedOrder Order { get; }

    public override bool Run()
    {
        double sum = Order.Meat.Price + Order.Bread.Price + Order.Salad.Price;

        Console.WriteLine("Order taken " + Order.Meat.GetType() + ", " + Order.Bread.GetType() + ", " + Order.Salad.GetType());
        Console.WriteLine("Total sum: " + sum.ToString());
        Console.WriteLine("Ttime: " + DateTime.Now.ToString());
        Console.WriteLine();

        return true;
    }
}
