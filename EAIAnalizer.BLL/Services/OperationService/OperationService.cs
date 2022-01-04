using EAIAnalizer.DAL.Repositories;
using EAIAnalizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.BLL.Services
{
    public class OperationService : IOperationService
    {
        private readonly OperationRepository<Operation> _operationRepository;
        public OperationService(OperationRepository<Operation> operationRepository)
        {
            _operationRepository = operationRepository;
        }
    }
}
