class WhiteBreadRepository: Repository<WhiteBread> {
    override public int MaxProductQuantity {
        get { return 30;}
    }
}