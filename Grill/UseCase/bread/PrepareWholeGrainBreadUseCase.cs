using System;
using System.Threading;

class PrepareWholeGrainBreadUseCase: UseCase<WholeGrainBread> {

    public PrepareWholeGrainBreadUseCase(WholeGrainBreadRepository Repository) : base(Repository) {
        
    }

    override public void Run() {
        WholeGrainBread product = new WholeGrainBread();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}