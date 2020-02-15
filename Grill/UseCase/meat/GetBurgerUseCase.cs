class GetBurgerUseCase: UseCase<Burger> {

    public GetBurgerUseCase(BurgerRepository Repository) : base(Repository) {
        
    }

    override public void run() {
        while (Repository.GetProduct() != null);
    }
}