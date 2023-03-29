using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Domain.Entities
{
    public class Field
    {
        [Key]
        public int Id { get;  set; }
        public string Name { get;  set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
