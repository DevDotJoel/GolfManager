using GolfManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Domain.Entities
{
    public class Event:Audit
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int FieldId { get; private set; }
        public virtual Field Field { get; private set; }
        public Event( string name,string description,int fieldId  )
        {
            Name = name;
            Description = description;
            FieldId = fieldId;
        }
        private Event()
        {

        }
        public void SetName(string name )
        {
            Name = name;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        public void SetFieldId(int fieldId)
        {
            FieldId = fieldId;
        }
    }
}
