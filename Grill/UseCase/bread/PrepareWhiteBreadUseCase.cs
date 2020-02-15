using System;
using System.Threading;

class PrepareWhiteBreadUseCase: UseCase<WhiteBread> {

    public PrepareWhiteBreadUseCase(WhiteBreadRepository Repository) : base(Repository) {
        
    }

    override public void run() {
        WhiteBread prodcut = new WhiteBread();
        Repository.AddProduct(prodcut);
        Thread.Sleep(prodcut.TimeToPrepare * 1000);
    }
}