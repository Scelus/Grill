using System;
using System.Threading;

class PrepareBurgerUseCase: UseCase<Burger> {

    public PrepareBurgerUseCase (BurgerRepository Repository) : base(Repository) {
        
    } 

    override public void Run() {
        Burger product = new Burger();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}