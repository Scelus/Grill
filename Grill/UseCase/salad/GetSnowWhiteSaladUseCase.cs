class GetSnowWhiteSaladUseCase: UseCase<SnowWhiteSalad> {

    public GetSnowWhiteSaladUseCase(SnowWhiteSaladRepository Repository) : base(Repository){
    
    }

    override public void Run() {
        while(Repository.GetProduct() != null);
    }
}