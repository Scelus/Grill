class TomatoAndCucumberSaladRepository: Repository<TomatoAndCucumberSalad> {
    override public int MaxProductQuantity {
        get { return 50; }
    }
}