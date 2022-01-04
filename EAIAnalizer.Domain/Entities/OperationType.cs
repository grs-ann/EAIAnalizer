using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.Domain.Entities
{
    /// <summary>
    /// Represents type of operation.
    /// </summary>
    public class OperationType
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; set; }
    }
}
