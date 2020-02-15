using System.Threading;

class GetSteakUseCase: UseCase<Steak> {

    public GetSteakUseCase(SteakRepository Repository) : base(Repository){
    
    }

    override public void Run() {
        while (Repository.GetProduct() != null);
    }
}