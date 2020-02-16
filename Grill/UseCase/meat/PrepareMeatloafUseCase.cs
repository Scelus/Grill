
using System;
using System.Threading;

class PrepareMeatloafUseCase: ProductUseCase<Meatloaf, object> {

    public PrepareMeatloafUseCase(MeatloafRepository Repository) : base(Repository){
        
    }

    override public object Run() {
        Meatloaf product = new Meatloaf();
        Thread.Sleep(product.TimeToPrepare * 1000);
        Repository.AddProduct(product);
        return product;
    }
}