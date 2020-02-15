class SteakRepository: Repository<Steak> {
     override public int MaxProductQuantity {
         get { return 20; }
     }
}