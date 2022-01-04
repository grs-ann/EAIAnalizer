using EAIAnalizer.Domain.BaseEntities;
using EAIAnalizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.Domain.Entities
{
    public class Operation : BaseEntity
    {
        /// <summary>
        /// Operation datetime.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Type of operation(incoming/outcoming, etc.)
        /// </summary>
        public OperationType? OperationType { get; set; }
        /// <summary>
        /// Category of operation(salary, from other people, for example).
        /// </summary>
        [Required]
        public Category? Category { get; set; }
        /// <summary>
        /// Sum of operation. 
        /// </summary>
        [Required]
        [Column(TypeName="money")]
        public decimal Sum { get; set; }
        /// <summary>
        /// Currency(RUB, RUR, USD, for example).
        /// </summary>
        [Required]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Description of operation.
        /// </summary>
        public string? Description { get; set; }
    }
}
