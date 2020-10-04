using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
 public interface IUnitOfWork : IDisposable // when we finished our transaction is going to dispose of context
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> Compelete(); // num of changes to our database so or entity frame work is going
        //track all of the changes to the entities where we add where we remove
        // what we add things to a list whatever we do inside this unit of work
        // we get to run the complete meethod that's the part
        //thats going to save the changes to our database and return a number of changes
        //

    }
}
