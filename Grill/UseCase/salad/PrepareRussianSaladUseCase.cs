using System;
using System.Collections.Generic;
using System.Threading;

class PrepareRussianSaladUseCase: UseCase<RussianSalad, object> {

    public PrepareRussianSaladUseCase(RussianSaladRepository Repository) : base(Repository){
    
    }

    override public object Run() {
        List<RussianSalad> list = new List<RussianSalad>();
        RussianSalad product = new RussianSalad();

        Thread.Sleep(product.TimeToPrepare * 1000);

        for (int i = 0; i < 5; i++)
        {
            product = new RussianSalad();
            Repository.AddProduct(product);
            list.Add(product);
        }
        return list;
    }
}