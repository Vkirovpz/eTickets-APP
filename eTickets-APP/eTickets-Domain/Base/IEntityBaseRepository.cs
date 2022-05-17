﻿namespace eTickets_Domain.Base
{
    using eTickets.Data.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}