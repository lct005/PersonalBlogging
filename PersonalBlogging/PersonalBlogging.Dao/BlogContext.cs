using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlogging.Dao
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            var config = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"];
            if (config != null)
            {
                this.Database.Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            }
        }
    }
}
