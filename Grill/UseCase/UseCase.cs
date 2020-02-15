abstract class UseCase<T> where T: Product {
    public Repository<T> Repository;

    protected UseCase(Repository<T> Repository) {
        this.Repository = Repository;
    }

    abstract public void Run();
}