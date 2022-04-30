using System;
using System.Threading.Tasks;

namespace User.API.Interfaces.Repositories
{
    /// <summary>
    /// Generic repository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Create a single <see cref="T"/> resource
        /// </summary>
        /// <param name="resource"><see cref="T"/> to create</param>
        /// <returns>Identifier of created resource</returns>
        Task<Guid> CreateAsync(T resource);

        /// <summary>
        /// Updates single <see cref="T"/> resource
        /// </summary>
        /// <param name="resource"><see cref="T"/> to update</param>
        /// <returns></returns>
        Task<Guid> UpdateAsync(T resource);

        /// <summary>
        /// Retrieve a single <see cref="T"/> from database by identifier
        /// </summary>
        /// <param name="resourceId">Identifier of the resource</param>
        /// <returns><see cref="T"/></returns>
        Task<T> GetByIdAsync(string resourceId);

        /// <summary>
        /// Delete a single <see cref="T"/> resource.
        /// </summary>
        /// <param name="resourceId">Identifier of the resource</param>
        /// <returns></returns>
        Task<int> DeleteAsync(string resourceId);
    }
}
