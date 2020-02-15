using System.Threading;

class GetMeatloafUseCase: UseCase<Meatloaf, Meatloaf> {

    public GetMeatloafUseCase(MeatloafRepository Repository) : base(Repository){
        
    }

    override public Meatloaf Run() {
        Meatloaf meatloaf;
        do
        {
            meatloaf = Repository.GetProduct();
        } while (meatloaf == null);
        return meatloaf;
    }
}