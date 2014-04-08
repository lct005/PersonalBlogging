using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlogging.Domain.Entities;

namespace PersonalBlogging.Dao
{
    public class PersonalBlogContextInitialer : DropCreateDatabaseIfModelChanges<PersonalBlogContext>
    {
        protected override void Seed(PersonalBlogContext context)
        {
            base.Seed(context);

            context.Blogs.Add(new Post());
            context.SaveChanges();
        }
    }
}
