using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlogging.Domain.Entities;

namespace PersonalBlogging.Dao
{
    public class PersonalBlogContext : DbContext
    {
        public DbSet<Post> Blogs { get; set; }

        public PersonalBlogContext()
        {
            var config = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"];
            if (config != null)
            {
                this.Database.Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
