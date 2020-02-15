using System.Collections.Generic;

class GetRussianSaladUseCase: UseCase<RussianSalad, List<RussianSalad>> {

    public GetRussianSaladUseCase(RussianSaladRepository Repository) : base(Repository){
    
    }

    override public List<RussianSalad> Run() {
        List<RussianSalad> list = new List<RussianSalad>();
        RussianSalad salad;
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