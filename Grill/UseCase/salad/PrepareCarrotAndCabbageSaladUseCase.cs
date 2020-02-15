using System;
using System.Threading;

class PrepareCarrotAndCabbageSaladUseCase: UseCase<CarrotAndCabbageSalad> {

    public PrepareCarrotAndCabbageSaladUseCase(CarrotAndCabbageSaladRepository Repository) : base(Repository){
    
    }

    override public void run() {
        CarrotAndCabbageSalad product = new CarrotAndCabbageSalad();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}