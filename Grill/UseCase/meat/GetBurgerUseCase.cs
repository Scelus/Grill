class GetBurgerUseCase: UseCase<Burger> {

    public GetBurgerUseCase(BurgerRepository Repository) : base(Repository) {
        
    }

    override public void Run() {
        while (Repository.GetProduct() != null);
    }
}