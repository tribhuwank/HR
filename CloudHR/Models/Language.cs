using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudHR.Models
{
    public class Language: EntityBase
    {
        public string Name { get; set; }
        public string ExpertiseLevel { get; set; }
    }
}
