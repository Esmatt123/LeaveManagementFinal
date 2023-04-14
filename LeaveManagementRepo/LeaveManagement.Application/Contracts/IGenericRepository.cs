using LeaveManagement.Data;
namespace LeaveManagement.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id); //This code defines an asynchronous method called GetAsync that takes an integer id parameter and returns a Task<T> object, where T is the type of the object that will be retrieved with the specified id.
        Task<List<T>> GetAllAsync(); //This code defines an asynchronous method called GetAllAsync that returns a Task<List<T>> object, where T is the type of the objects that will be retrieved from a data source.
        Task<T> AddAsync(T entity); /*This code declares a method called "AddAsync" that takes 
                                  a generic entity "T" as its parameter and returns a Task.
                                  The method adds the specified entity to the data store 
                                  asynchronously, and it is typically used to persist new 
                                  records to a database using an ORM such as Entity Framework. */
        Task<bool> Exists(int id);// "Exists" is a method that asynchronously checks if an entity with the specified "id" exists in the data store and returns a boolean value indicating the result.
        Task DeleteAsync(int id); //"DeleteAsync" is a method that asynchronously deletes the record with the specified "id" from the data store.
        Task UpdateAsync(T entity); //"UpdateAsync" is a method that asynchronously updates the specified entity in the data store, and is commonly used to modify existing records in a database using an ORM.
        Task AddRangeAsync(List<T> entities);
       
    }
}
