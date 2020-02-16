using System.Threading;

class GetSteakUseCase: ProductUseCase<Steak, Steak> {

    public GetSteakUseCase(SteakRepository Repository) : base(Repository) {
    
    }

    override public Steak Run() {
        Steak steak;
        do
        {
            steak = Repository.GetProduct();
        } while (steak == null);
        return steak;
    }
}