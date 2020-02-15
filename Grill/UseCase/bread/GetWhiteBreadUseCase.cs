class GetWhiteBreadUseCase: UseCase<WhiteBread> {

    public GetWhiteBreadUseCase(WhiteBreadRepository Repository) : base(Repository) { }
    
    override public void run() {
        while(Repository.GetProduct() != null);
    }
}