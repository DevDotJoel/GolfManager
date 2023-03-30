using GolfManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Domain.Entities
{
    public class Field:Audit
    {
        [Key]
        public int Id { get; private  set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Capacity { get; private set; }
        public Field( string name,string description, int capacity)
        {
            Name = name;
            Description = description;
            Capacity = capacity;
        }
        private Field()
        {
        } 
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        public void SetCapacity(int capacity)
        {
            Capacity = capacity;
        }
    }
}
