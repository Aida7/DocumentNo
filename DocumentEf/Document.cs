using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentEf
{
    public class Document
    {
        public int Id { get; set;}
        public string TypeDocument { get; set; }
        public string Theme { get; set; }
        public string Text { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime DateView { get; set; }
        public DateTime DateCreate { get; set; }
     
    }
}
