using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.Domain.Dto
{
    public class FileInputDto
    {
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string Data { get; set; }
    }
}
