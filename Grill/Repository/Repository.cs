using System;
using System.Collections.Generic;

abstract class Repository<T> where T : Product {

    abstract public int MaxProductQuantity { get; }

    private Queue<T> datasource = new Queue<T>();

    public bool AddProduct(T product) {
        if (datasource.Count < MaxProductQuantity) {
            datasource.Enqueue(product);
            return true;     
        }

        return false;
     }

     public T GetProduct() {
         if (datasource.Count > 0) {
            T product = datasource.Dequeue();
            Console.WriteLine("Got " + product.GetType().ToString());
            return product;
         }
         else {
            return null;
         }
     }

     public int GetCount() {
         return datasource.Count;
     }
}