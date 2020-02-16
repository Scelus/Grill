using System;
using System.Collections.Generic;
using System.Threading;

class PrepareTomatoAndCucumberSaladUseCase: ProductUseCase<TomatoAndCucumberSalad, object> {

    public PrepareTomatoAndCucumberSaladUseCase(TomatoAndCucumberSaladRepository Repository) : base(Repository)
    {
    
    }

    override public object Run() {
        List<TomatoAndCucumberSalad> list = new List<TomatoAndCucumberSalad>();
        TomatoAndCucumberSalad product = new TomatoAndCucumberSalad();

        Thread.Sleep(product.TimeToPrepare * 1000);

        for (int i = 0; i < 5; i++)
        {
            product = new TomatoAndCucumberSalad();
            Repository.AddProduct(product);
            list.Add(product);
        }
        return list;
    }
}