using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEf
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DocumentModel())
            {
                context.Signatures.Add(new Signature { Id = 1, SignatureName = "1QWED233", Password = "111111" });
                context.Signatures.Add(new Signature { Id = 2, SignatureName = "ded1213dfg", Password = "244144" });
                context.SaveChanges();
                context.Users.AddRange(new List<User>
                {
                 new User {Id = 1, Name = "Victor", SerName= "E",  Mail = "Victor@mail.ru" },
                 new User {Id=2,Name="Alen",SerName="S",Mail="Del@mail.ru" },
                 new User {Id=3,Name="Alens",SerName="St", Mail="De1l@mail.ru" },
                 new User {Id = 4, Name = "Victors", SerName= "Ee",  Mail = "Victo1r@mail.ru" },
                });
                context.SaveChanges();
                context.Persons.AddRange(new List<Person>
                {
                    new Person{ Id=1,Name="Red",Sername="S",SignatureId=1},
                    new Person{ Id=2,Name="Red1",Sername="S",SignatureId=2},
                    new Person{ Id=3,Name="M1",Sername="T",SignatureId=2},
                    new Person{ Id=4,Name="M",Sername="T",SignatureId=1}
                });
                context.SaveChanges();
                context.Documents.AddRange(new List<Document>
                {
                    new Document{ Id=1,Theme="1",Text="DDDDD",TypeDocument="Document",UserID=1,PersonId=1,DateView=DateTime.Now,DateCreate=DateTime.Now},
                    new Document{Id=2,Theme="2",Text="wwww",TypeDocument="document",UserID=2,PersonId=1,DateView=DateTime.Now,DateCreate=DateTime.Now},
                    new Document{ Id=3,Theme="2",Text="dfdfd",TypeDocument="doc",UserID=1,PersonId=2,DateCreate=DateTime.Now,DateView=DateTime.Now},
                    new Document{ Id=4,Theme="3",Text="ds",TypeDocument="we",UserID=2,PersonId=2,DateCreate=DateTime.Now,DateView= DateTime.Now}
                });
               
                  context.SaveChanges(); 
            
            }
             int min = 2;
               List<Document> documents = new List<Document>();
                  documents
                .Where(number => number.Person.Id <= min );
            
           // foreach (var item in documents)
           // {
               //   (from document
                // in documents.AsParallel()
                // where item.Person.Id >= min 
                // select document ).ForAll(number => Console.WriteLine(number));

            //}
           

            Console.ReadLine();

        }    
    }
}
