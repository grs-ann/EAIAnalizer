using EAIAnalizer.BLL.Services;
using EAIAnalizer.DAL.Repositories;
using EAIAnalizer.Domain.Dto;
using EAIAnalizer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EAIAnalizer_Backend.Controllers
{
    public class OperationController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOperationService _opertaionService;
        private readonly OperationRepository<Operation> _operationRepository;

        public OperationController(ILogger<WeatherForecastController> logger,
            IOperationService operationService, OperationRepository<Operation> operationRepository)
        {
            _logger = logger;
            _opertaionService = operationService;
            _operationRepository = operationRepository;
        }
        [HttpPost("AddNewOperation")]
        public async Task<IActionResult> AddNewOperation(OperationDto operationDto)
        {
            if (operationDto != null)
            {
                var operation = new Operation
                {
                    // поправить контент(связи между таблицами!)
                    //Category = operationDto.CategoryId
                }
                var result = await _operationRepository.Add(operation);
                return Ok($"New operation has been added. Operation data: {result}");
            }
            _logger.LogInformation("Operation model is null.");
            return BadRequest("Operation model is null.");
        }
        [HttpGet("GetAllOperations")]
        public async Task<IEnumerable<Operation>> GetAllOperations()
        {
            return new List<Operation>();
        }
    }
}
