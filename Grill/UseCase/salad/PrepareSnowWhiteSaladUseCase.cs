using System;
using System.Threading;

class PrepareSnowWhiteSaladUseCase: UseCase<SnowWhiteSalad> {

    public PrepareSnowWhiteSaladUseCase(SnowWhiteSaladRepository Repository) : base(Repository){
    
    }

    override public void Run() {
        SnowWhiteSalad product = new SnowWhiteSalad();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}