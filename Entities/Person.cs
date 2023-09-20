using FamilyWebAPImodels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWebAPImodels.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get;set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public PersonType PersonType { get; set; }
        [ForeignKey("Family")]
        public int FamilyId { get; set; }
        public Family Family { get; set; }
        public List<Animal> Animals { get; set; }
    }
}
