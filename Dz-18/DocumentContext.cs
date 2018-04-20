namespace Dz_18
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DocumentContext : DbContext
    {
        public DocumentContext()
            : base("name=DocumentContext")
        {
        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<Person> People { get; set; }

    }
}