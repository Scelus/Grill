class WholeGrainBreadRepository: Repository<WholeGrainBread> {
    override public int MaxProductQuantity {
        get { return 30;}
    }
}