using System.Collections.Generic;

namespace MagazinesDemo.Business.Repositories
{
    /// <summary>
    /// Base interface for an entity repository
    /// This inteface include basic CRUD operations
    /// </summary>
    /// <typeparam name="TEntity">The TEntity type</typeparam>
    /// <typeparam name="TKey">The type of the TEntity key.</typeparam>
    internal interface IRepository<TEntity, TKey> where TEntity : class
    {
        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Gets an entity given the specified key
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        TEntity Get(TKey key);

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Removes an entity given the specified key
        /// </summary>
        /// <param name="key">The key.</param>
        void Remove(TKey key);
    }
}
