using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public interface IRepository<T>
    {
        // Retrieves an entity by its unique identifier.
        T GetById(int id);

        // Retrieves all entities of type T from the repository.
        IEnumerable<T> GetAll();

        // Adds a new entity to the repository.
        void Add(T entity);

        // Updates an existing entity in the repository.
        void Update(T entity);

        // Deletes an entity from the repository.
        void Delete(T entity);
    }
}
