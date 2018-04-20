using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_18
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DocumentContext context = new DocumentContext())
            {
                var result = from d in context.Documents
                             join s in context.Signatures
                             on d.SignatureId equals s.Id
                             join p in context.People
                             on s.PersonId equals p.Id
                             select new { d.Id, d.DocumentTheme, d.DocumentCreator, d.CreationDate, d.Signature.Select(s => s.Person.FullName) };
            }
        }
    }
}
