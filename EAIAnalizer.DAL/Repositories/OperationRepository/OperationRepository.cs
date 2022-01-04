using EAIAnalizer.Domain.BaseEntities;
using EAIAnalizer_Backend.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.DAL.Repositories.OperationRepository
{
    public class OperationRepository<T> : EFCoreBaseRepository<BaseOperation, ApplicationDbContext>, IOperationRepository
        where T : BaseOperation, new()  
    {
        public OperationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
