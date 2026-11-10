namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class GuschinEntities : DbContext
    {
        public GuschinEntities()
            : base("name=GuschinEntities")
        {
        }

        public static GuschinEntities GetContext()
        {
            return new GuschinEntities();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}