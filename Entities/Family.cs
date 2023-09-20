using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyWebAPImodels.Entities
{
    public class Family
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Person> Persons { get; set; }
    }
}
