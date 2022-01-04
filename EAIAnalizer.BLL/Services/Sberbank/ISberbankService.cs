using EAIAnalizer.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.BLL.Services
{
    public interface ISberbankService
    {
        /// <summary>
        /// Uploads data from 'excel' document to database.
        /// </summary>
        /// <param name="fileInput">Contains file.</param>
        /// <returns>Task object.</returns>
        public Task UploadDataFromExcel(FileInputDto fileInput);
    }
}
