using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nt.Dao;
using PersonalBlogging.Domain;
using PersonalBlogging.Service.Interfaces;

namespace PersonalBlogging.Service
{

    public class BlogService : ServiceBase<Blog>, IBlogService
    {
        private IRepository<Blog> blogRepository;

        public BlogService(IRepository<Blog> blogRepository)
            : base(blogRepository)
        {
            this.blogRepository = blogRepository;
        }
    }
}
