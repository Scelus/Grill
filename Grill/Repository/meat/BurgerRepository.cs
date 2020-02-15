class BurgerRepository: Repository<Burger> {
     override public int MaxProductQuantity {
         get { return 20; }
     }
}