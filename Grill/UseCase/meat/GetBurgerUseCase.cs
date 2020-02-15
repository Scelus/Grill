class GetBurgerUseCase: UseCase<Burger, Burger> {

    public GetBurgerUseCase(BurgerRepository Repository) : base(Repository) {
        
    }

    override public Burger Run() {
        Burger burger;
        do
        {
            burger = Repository.GetProduct();
        } while (burger == null);
        return burger;
    }
}