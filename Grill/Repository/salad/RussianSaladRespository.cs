class RussianSaladRepository: Repository<RussianSalad> {
    override public int MaxProductQuantity {
        get { return 50; }
    }
}