using System;
using System.Collections.Generic;
using System.Text;

abstract class ProductUseCase<T, R> : UseCase<R> where T : Product
{
    public Repository<T> Repository;

    protected ProductUseCase(Repository<T> Repository)
    {
        this.Repository = Repository;
    }
}
