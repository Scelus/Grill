class GetSnowWhiteSaladUseCase: UseCase<SnowWhiteSalad> {

    GetSnowWhiteSaladUseCase(SnowWhiteSaladRepository Repository) : base(Repository){
    
    }

    override public void run() {
        Repository.GetProduct();
    }
}