using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.API.Interfaces.Services
{
    /// <summary>
    /// Interface for Resource Control Service implementations
    /// </summary>
    /// <typeparam name="TResource"></typeparam>
    public interface IService<TResource> where TResource : class
    {
        /// <summary>
        /// Handles a get request between the application and data layer for a specific resource honoring access control permissions.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <returns></returns>
        Task<TResource> GetAsync(Guid resourceId);

        /// <summary>
        /// Handles a create request for a new resource between the application and data layer honoring access control permissions.
        /// </summary>
        Task<Guid> CreateAsync(TResource resource);

        /// <summary>
        /// Handles an update request for a specific resource between the application and data layer honoring access control permissions.
        /// </summary>
        Task<Guid> UpdateAsync(TResource resource);

        /// <summary>
        /// Handles a delete request between the application and data layer for a specific resource honoring access control permissions.
        /// </summary>
        Task<int> DeleteAsync(TResource resource);
    }
}
