class GetWhiteBreadUseCase: UseCase<WhiteBread> {

    public GetWhiteBreadUseCase(WhiteBreadRepository Repository) : base(Repository) { }
    
    override public void Run() {
        while(Repository.GetProduct() != null);
    }
}