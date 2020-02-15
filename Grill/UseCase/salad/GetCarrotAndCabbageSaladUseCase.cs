class GetCarrotAndCabbageSaladUseCase: UseCase<CarrotAndCabbageSalad> {

    public GetCarrotAndCabbageSaladUseCase(CarrotAndCabbageSaladRepository Repository) : base(Repository){
    
    }

    override public void Run() {
        while(Repository.GetProduct() != null);
    }
}