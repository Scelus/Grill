class GetMeatloafUseCase: UseCase<Meatloaf> {

    public GetMeatloafUseCase(MeatloafRepository Repository) : base(Repository){
        
    }

    override public void run() {
        while (Repository.GetProduct() != null);
    }
}