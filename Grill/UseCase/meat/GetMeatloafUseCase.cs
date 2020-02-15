using System.Threading;

class GetMeatloafUseCase: UseCase<Meatloaf> {

    public GetMeatloafUseCase(MeatloafRepository Repository) : base(Repository){
        
    }

    override public void Run() {
        while (Repository.GetProduct() != null)
        {
            Thread.Sleep(10);
        }
    }
}