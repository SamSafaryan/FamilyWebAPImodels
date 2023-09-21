using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWebAPImodels.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        [ForeignKey("Family")]
        public int FamilyId { get; set;}
        public Family Family { get; set;}
        public List<Person> Persons { get; set; }
        
    }
}
