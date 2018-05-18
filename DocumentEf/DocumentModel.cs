namespace DocumentEf
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DocumentModel : DbContext
    {
        
        public DocumentModel()
            : base("name=DocumentModel")
        {
        }
        public  DbSet<User> Users { get; set; }
        public  DbSet<Person> Persons { get; set; }
        public  DbSet<Document> Documents { get; set; }
        public  DbSet<Signature> Signatures { get; set; }

    }

}