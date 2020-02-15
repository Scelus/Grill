using System;
using System.Threading;

class PrepareTomatoAndCucumberSaladUseCase: UseCase<TomatoAndCucumberSalad> {

    public PrepareTomatoAndCucumberSaladUseCase(TomatoAndCucumberSaladRepository Repository) : base(Repository)
    {
    
    }

    override public void run() {
        TomatoAndCucumberSalad product = new TomatoAndCucumberSalad();
        Repository.AddProduct(product);
        Thread.Sleep(product.TimeToPrepare * 1000);
    }
}