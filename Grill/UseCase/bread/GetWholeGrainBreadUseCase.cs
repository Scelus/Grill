class GetWholeGrainBreadUseCase: UseCase<WholeGrainBread> {

    public GetWholeGrainBreadUseCase(WholeGrainBreadRepository Repository) : base(Repository) {
        
    }

    override public void Run() {
        while(Repository.GetProduct() != null);
    }
}