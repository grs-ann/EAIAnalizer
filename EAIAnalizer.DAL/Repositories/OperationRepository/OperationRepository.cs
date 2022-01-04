using EAIAnalizer.Domain.BaseEntities;
using EAIAnalizer.Domain.Entities;
using EAIAnalizer_Backend.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.DAL.Repositories
{
    public class OperationRepository<T> : EFCoreBaseRepository<Operation, ApplicationDbContext>, IOperationRepository
        where T : Operation, new()  
    {
        public OperationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
