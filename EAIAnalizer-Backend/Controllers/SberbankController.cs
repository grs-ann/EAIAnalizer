using EAIAnalizer.BLL.Services.Sberbank;
using EAIAnalizer.Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using MimeMapping;

namespace EAIAnalizer_Backend.Controllers
{
    public class SberbankController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ISberbankService _sberbankService;

        public SberbankController(ILogger<WeatherForecastController> logger,
            ISberbankService sberbankService)
        {
            _logger = logger;
            _sberbankService = sberbankService;
        }
        [HttpPost("GetDataFromExcel")]
        public async Task<IActionResult> GetDataFromExcel(IFormFile file)
        {
            _logger.LogInformation("GetDataFromExcel method start working.");
            var mimeType = MimeUtility.GetMimeMapping(file.FileName);
            if (!mimeType.Equals(KnownMimeTypes.Xlsx))
            {
                _logger.LogInformation($"Uncorrect document type: {mimeType}");
                return BadRequest($"Uncorrect document type: {mimeType}");
            }
            var fileInputDto = new FileInputDto
            {
                File = file,
                FileName = file.FileName
            };
            await _sberbankService.UploadDataFromExcel(fileInputDto);
            return Ok("Successfully upload.");
        }
    }
}
