class GetWholeGrainBreadUseCase: ProductUseCase<WholeGrainBread, WholeGrainBread> {

    public GetWholeGrainBreadUseCase(WholeGrainBreadRepository Repository) : base(Repository) {
        
    }

    override public WholeGrainBread Run() {
        WholeGrainBread wholeGrainBread;
        do
        {
            wholeGrainBread = Repository.GetProduct();
        } while (wholeGrainBread == null);
        return wholeGrainBread;
    }
}