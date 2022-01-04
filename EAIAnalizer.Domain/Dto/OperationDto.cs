using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.Domain.Dto
{
    public class OperationDto
    {
        /// <summary>
        /// Operation datetime.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Type of operation(incoming/outcoming, etc.)
        /// </summary>
        [Required]
        public int OperationTypeId { get; set; }
        /// <summary>
        /// Category of operation(salary, from other people, for example).
        /// </summary>
        [Required]
        public int CategoryId { get; set; }
        /// <summary>
        /// Sum of operation. 
        /// </summary>
        [Required]
        public decimal Sum { get; set; }
        /// <summary>
        /// Currency(RUB, RUR, USD, for example).
        /// </summary>
        [Required]
        public int CurrencyId { get; set; }
        /// <summary>
        /// Description of operation.
        /// </summary>
        public string? Description { get; set; }
    }
}
