using EAIAnalizer.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.Domain.Entities
{
    public class BankCard : BaseEntity
    {
        /// <summary>
        /// Name of card.
        /// </summary>
        [Required]
        public string? Name { get; set; }    
        /// <summary>
        /// Short number, consisting of 4 digits.
        /// </summary>
        public int ShortNumber { get; set; }
        /// <summary>
        /// Long number
        /// </summary>
        public long LongNumber { get; set; }
    }
}
