using System;
using System.Collections.Generic;
using System.Threading;

class PrepareSnowWhiteSaladUseCase: ProductUseCase<SnowWhiteSalad, object> {

    public PrepareSnowWhiteSaladUseCase(SnowWhiteSaladRepository Repository) : base(Repository){
    
    }

    override public object Run() {
        List<SnowWhiteSalad> list = new List<SnowWhiteSalad>();
        SnowWhiteSalad product = new SnowWhiteSalad();

        Thread.Sleep(product.TimeToPrepare * 1000);

        for (int i = 0; i < 5; i++)
        {
            product = new SnowWhiteSalad();
            Repository.AddProduct(product);
            list.Add(product);
        }
        return list;
    }
}