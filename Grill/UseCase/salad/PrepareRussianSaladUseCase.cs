using System;
using System.Threading;

class PrepareRussianSaladUseCase: UseCase<RussianSalad> {

    public PrepareRussianSaladUseCase(RussianSaladRepository Repository) : base(Repository){
    
    }

    override public void run() {
        RussianSalad product = new RussianSalad();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}