using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEf
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sername { get; set; }
        public int SignatureId { get; set; }
        public Signature Signature { get; set; }
    }
}
