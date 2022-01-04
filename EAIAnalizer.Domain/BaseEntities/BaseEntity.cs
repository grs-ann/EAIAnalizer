using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.Domain.BaseEntities
{
    /// <summary>
    /// Represents base properties for all entities in project(related with db).
    /// Excluding those for which there is no need for a primary key.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        [Required]
        public Guid Id { get; set; }
    }
}
