using System;
using System.Threading;

class PrepareBurgerUseCase: ProductUseCase<Burger, object> {

    public PrepareBurgerUseCase (BurgerRepository Repository) : base(Repository) {
        
    } 

    override public object Run() {
        Burger product = new Burger();
        Thread.Sleep(product.TimeToPrepare * 1000);
        Repository.AddProduct(product);
        return product;
    }
}