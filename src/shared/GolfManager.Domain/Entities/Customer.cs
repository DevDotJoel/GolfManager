using GolfManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Domain.Entities
{
    public class Customer:Audit
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get;private set; }
        public Customer(string name,string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;

        }
        private Customer()
        {

        }
    }
}
