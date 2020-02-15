using System;
using System.Threading;

class PrepareSteakUseCase: UseCase<Steak> {

    public PrepareSteakUseCase(SteakRepository Repository) : base(Repository){
    
    }

    override public void Run() {
        Steak product = new Steak();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}