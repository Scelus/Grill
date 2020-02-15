class GetRussianSaladUseCase: UseCase<RussianSalad> {

    public GetRussianSaladUseCase(RussianSaladRepository Repository) : base(Repository){
    
    }

    override public void Run() {
        while(Repository.GetProduct() != null);
    }
}