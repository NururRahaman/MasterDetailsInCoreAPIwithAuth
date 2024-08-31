using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam8_MasterDetailsInCoreAPIwithAuth.Models
{
    public class Plant
    {
        [Key]
        public int PlantId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrderDetail> Details { get; set; }
    }
}
