using EAIAnalizer.Domain.Dto;
using EAIAnalizer_Backend.DB;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.BLL.Services.Sberbank
{
    public class SberbankService : ISberbankService
    {
        private readonly ApplicationDbContext _dbContext;
        public SberbankService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Uploads data from 'excel' document to database.
        /// </summary>
        /// <param name="fileInput">Contains file.</param>
        /// <returns>Task object.</returns>
        public async Task UploadDataFromExcel(FileInputDto fileInput)
        {
            if (fileInput != null && fileInput.File != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await fileInput.File.CopyToAsync(memoryStream);
                    using (var package = new ExcelPackage(memoryStream))
                    {
                        var worksheet = package?.Workbook?.Worksheets?.FirstOrDefault();
                        if (worksheet != null)
                        {
                            var rowCount = worksheet.Dimension.Rows;
                            var columnsCount = worksheet.Dimension.Columns;
                            // todo ! realize the logic, which can transfer(map) sberbank excel table into our db.
                        }
                    }
                }
            }
        }
    }
}
