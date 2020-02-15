class CarrotAndCabbageSaladRepository: Repository<CarrotAndCabbageSalad> {
    override public int MaxProductQuantity {
        get { return 50; }
    }
}