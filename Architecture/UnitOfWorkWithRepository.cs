using System;
using System.Collections.Generic;

// Entity class representing a domain object
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

// Repository interface for CRUD operations on entities
public interface IRepository<T>
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
}

// Concrete repository implementation for the Product entity
public class ProductRepository : IRepository<Product>
{
    private List<Product> products = new List<Product>();

    public void Add(Product entity)
    {
        products.Add(entity);
    }

    public void Update(Product entity)
    {
        // Implementation for updating a product in the database
    }

    public void Delete(Product entity)
    {
        products.Remove(entity);
    }

    public Product GetById(int id)
    {
        return products.Find(p => p.Id == id);
    }

    public IEnumerable<Product> GetAll()
    {
        return products;
    }
}

// Unit of Work interface
public interface IUnitOfWork : IDisposable
{
    IRepository<Product> ProductRepository { get; }
    void Commit();
}

// Concrete implementation of the Unit of Work pattern
public class UnitOfWork : IUnitOfWork
{
    private readonly IRepository<Product> productRepository;

    public UnitOfWork()
    {
        productRepository = new ProductRepository();
    }

    public IRepository<Product> ProductRepository => productRepository;

    public void Commit()
    {
        // Implementation for committing changes to the database
        Console.WriteLine("Changes committed.");
    }

    public void Dispose()
    {
        // Implementation for disposing resources
        Console.WriteLine("UnitOfWork disposed.");
    }
}

class Program
{
    static void Main()
    {
        // Example usage of Unit of Work pattern
        using (var unitOfWork = new UnitOfWork())
        {
            var product = new Product { Id = 1, Name = "Example Product", Price = 19.99m };

            // Adding a product
            unitOfWork.ProductRepository.Add(product);

            // Updating the product
            product.Price = 29.99m;
            unitOfWork.ProductRepository.Update(product);

            // Deleting the product
            unitOfWork.ProductRepository.Delete(product);

            // Committing changes
            unitOfWork.Commit();
        }
    }
}
