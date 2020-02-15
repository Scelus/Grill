class GetTomatoAndCucumberSaladUseCase: UseCase<TomatoAndCucumberSalad> {

    public GetTomatoAndCucumberSaladUseCase(TomatoAndCucumberSaladRepository Repository) : base(Repository)
    {
    
    }

    override public void Run() {
        while(Repository.GetProduct() != null);
    }
}