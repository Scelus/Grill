using System;
using System.Threading;

class PrepareSteakUseCase: UseCase<Steak, object> {

    public PrepareSteakUseCase(SteakRepository Repository) : base(Repository){
    
    }

    override public object Run() {
        Steak product = new Steak();
        Thread.Sleep(product.TimeToPrepare * 1000);
        Repository.AddProduct(product);
        return product;
    }
}