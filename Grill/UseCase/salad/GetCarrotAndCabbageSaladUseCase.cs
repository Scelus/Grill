class GetCarrotAndCabbageSaladUseCase: UseCase<CarrotAndCabbageSalad> {

    GetCarrotAndCabbageSaladUseCase(CarrotAndCabbageSaladRepository Repository) : base(Repository){
    
    }

    override public void run() {
        Repository.GetProduct();
    }
}