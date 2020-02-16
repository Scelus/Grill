using System.Collections.Generic;

class GetTomatoAndCucumberSaladUseCase: ProductUseCase<TomatoAndCucumberSalad, List<TomatoAndCucumberSalad>> {

    public GetTomatoAndCucumberSaladUseCase(TomatoAndCucumberSaladRepository Repository) : base(Repository)
    {
    
    }

    override public List<TomatoAndCucumberSalad> Run() {
        List<TomatoAndCucumberSalad> list = new List<TomatoAndCucumberSalad>();
        TomatoAndCucumberSalad salad;
        for (int i = 0; i < 2; i++)
        {
            do
            {
                salad = Repository.GetProduct();
            } while (salad == null);
            list.Add(salad);
        }
        return list;
    }
}