abstract class UseCase<T, R> where T: Product {
    public Repository<T> Repository;

    protected UseCase(Repository<T> Repository) {
        this.Repository = Repository;
    }

    abstract public R Run();
}