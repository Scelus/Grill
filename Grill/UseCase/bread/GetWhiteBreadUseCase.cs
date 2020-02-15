class GetWhiteBreadUseCase: UseCase<WhiteBread, WhiteBread> {

    public GetWhiteBreadUseCase(WhiteBreadRepository Repository) : base(Repository) { }
    
    override public WhiteBread Run() {
        WhiteBread whiteBread;
        do
        {
            whiteBread = Repository.GetProduct();
        } while (whiteBread == null);
        return whiteBread;
    }
}