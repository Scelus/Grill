using System;
using System.Collections.Generic;
using System.Threading;

class PrepareCarrotAndCabbageSaladUseCase: UseCase<CarrotAndCabbageSalad, object> {

    public PrepareCarrotAndCabbageSaladUseCase(CarrotAndCabbageSaladRepository Repository) : base(Repository){
    
    }

    override public object Run() {
        List<CarrotAndCabbageSalad> list = new List<CarrotAndCabbageSalad>();
        CarrotAndCabbageSalad product = new CarrotAndCabbageSalad();
        
        Thread.Sleep(product.TimeToPrepare * 1000);

        for (int i = 0; i < 5; i++) { 
            product = new CarrotAndCabbageSalad();
            Repository.AddProduct(product);
            list.Add(product);
        }
        return list;
    }
}