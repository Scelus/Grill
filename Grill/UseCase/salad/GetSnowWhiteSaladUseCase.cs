using System.Collections.Generic;

class GetSnowWhiteSaladUseCase: UseCase<SnowWhiteSalad, List<SnowWhiteSalad>> {

    public GetSnowWhiteSaladUseCase(SnowWhiteSaladRepository Repository) : base(Repository){
    
    }

    override public List<SnowWhiteSalad> Run() {
        List<SnowWhiteSalad> list = new List<SnowWhiteSalad>();
        SnowWhiteSalad salad;
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