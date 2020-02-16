using System;
using System.Threading;

class PrepareWholeGrainBreadUseCase: ProductUseCase<WholeGrainBread, object> {

    public PrepareWholeGrainBreadUseCase(WholeGrainBreadRepository Repository) : base(Repository) {
        
    }

    override public object Run() {
        WholeGrainBread product = new WholeGrainBread();
        Thread.Sleep(product.TimeToPrepare * 1000);
        Repository.AddProduct(product);
        return product;
    }
}