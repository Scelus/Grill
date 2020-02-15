
using System;
using System.Threading;

class PrepareMeatloafUseCase: UseCase<Meatloaf> {

    public PrepareMeatloafUseCase(MeatloafRepository Repository) : base(Repository){
        
    }

    override public void Run() {
        Meatloaf product = new Meatloaf();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}