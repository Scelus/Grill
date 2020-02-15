class GetSteakUseCase: UseCase<Steak> {

    public GetSteakUseCase(SteakRepository Repository) : base(Repository){
    
    }

    override public void run() {
        while (Repository.GetProduct() != null);
    }
}