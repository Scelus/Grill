using System;
using System.Collections.Generic;

class GetCarrotAndCabbageSaladUseCase: UseCase<CarrotAndCabbageSalad, List<CarrotAndCabbageSalad>> {

    public GetCarrotAndCabbageSaladUseCase(CarrotAndCabbageSaladRepository Repository) : base(Repository){
    
    }

    override public List<CarrotAndCabbageSalad> Run() {
        List<CarrotAndCabbageSalad> list = new List<CarrotAndCabbageSalad>();
        CarrotAndCabbageSalad salad;
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