class GetRussianSaladUseCase: UseCase<RussianSalad> {

    GetRussianSaladUseCase(RussianSaladRepository Repository) : base(Repository){
    
    }

    override public void run() {
        Repository.AddProduct(new RussianSalad());
    }
}