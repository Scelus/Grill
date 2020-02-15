class GetTomatoAndCucumberSaladUseCase: UseCase<TomatoAndCucumberSalad> {

    GetTomatoAndCucumberSaladUseCase(TomatoAndCucumberSaladRepository Repository) : base(Repository)
    {
    
    }

    override public void run() {
        Repository.GetProduct();
    }
}