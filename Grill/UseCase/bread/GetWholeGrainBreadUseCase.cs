class GetWholeGrainBreadUseCase: UseCase<WholeGrainBread> {

    public GetWholeGrainBreadUseCase(WholeGrainBreadRepository Repository) : base(Repository) {
        
    }

    override public void run() {
        while(Repository.GetProduct() != null);
    }
}