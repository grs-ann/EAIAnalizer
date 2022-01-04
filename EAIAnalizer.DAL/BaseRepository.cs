using EAIAnalizer_Backend.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.DAL
{
    /// <summary>
    /// Represents base class for implementation in inheritors.
    /// </summary>
    /// <typeparam name="TEntity">Entity being worked with.</typeparam>
    /// <typeparam name="TContext">Database context.</typeparam>
    public abstract class EFCoreBaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        private readonly TContext _dbContext;
        public EFCoreBaseRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds new entity to DB.
        /// </summary>
        /// <param name="entity">Entity to be added.</param>
        /// <returns>Added entity.</returns>
        public async Task<TEntity> Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Deletes entity from DB by int Id.
        /// </summary>
        /// <param name="id">Entity id having INT type.</param>
        /// <returns>Null if entity does not conitains at DB. Entity if this exists and successfully deleted.</returns>
        public async Task<TEntity?> DeleteById(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                _dbContext.Set<TEntity>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            return entity;
        }

        /// <summary>
        /// Deletes entity from DB by guid Id.
        /// </summary>
        /// <param name="id">Entity id having GUID type.</param>
        /// <returns>Null if entity does not conitains at DB. Entity if this exists and successfully deleted.</returns>
        public async Task<TEntity?> DeleteById(Guid id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                _dbContext.Set<TEntity>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            return entity;
        }

        /// <summary>
        /// Gets all entities by entity type at DB.
        /// </summary>
        /// <returns>Entities collection.</returns>
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        /// <summary>
        /// Gets entity from DB by int Id.
        /// </summary>
        /// <param name="id">Entity id having int type.</param>
        /// <returns>Null if entity with this id does not conitains at DB. Entity if this finded at DB.</returns>
        public async Task<TEntity?> GetById(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        /// <summary>
        /// Gets entity from DB by guid Id.
        /// </summary>
        /// <param name="id">Entity id having GUID type.</param>
        /// <returns>Null if entity with this id does not conitains at DB. Entity if this finded at DB.</returns>
        public async Task<TEntity?> GetById(Guid id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        /// <summary>
        /// Updates entity at DB>
        /// </summary>
        /// <param name="entity">Entity to update.</param>
        /// <returns>Updated entity.</returns>
        public async Task<TEntity> Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
