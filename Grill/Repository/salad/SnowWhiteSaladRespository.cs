class SnowWhiteSaladRepository: Repository<SnowWhiteSalad> {
    override public int MaxProductQuantity {
        get { return 50; }
    }
}