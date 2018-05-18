using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEf
{
    public class Signature
    {
        public int Id { get; set; }
        public string SignatureName { get; set; }
        public string Password { get; set; }
        public ICollection<Person> People { get; set; }
        
    }
}
