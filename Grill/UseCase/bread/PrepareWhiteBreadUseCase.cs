using System;
using System.Threading;

class PrepareWhiteBreadUseCase: ProductUseCase<WhiteBread, object> {

    public PrepareWhiteBreadUseCase(WhiteBreadRepository Repository) : base(Repository) {
        
    }

    override public object Run() {
        WhiteBread prodcut = new WhiteBread();
        Thread.Sleep(prodcut.TimeToPrepare * 1000);
        Repository.AddProduct(prodcut);
        return prodcut;
    }
}