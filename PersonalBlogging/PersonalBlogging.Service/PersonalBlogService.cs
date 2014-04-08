using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nt.Dao;
using PersonalBlogging.Dao;
using PersonalBlogging.Domain.Entities;

namespace PersonalBlogging.Service
{
    public partial class PersonalPostService : IPersonalPostService
    {
        private IRepository<Post> postRepository;

        public PersonalPostService()
        {
            this.postRepository = new RepositoryBase<Post>(new PersonalBlogContext());
        }
    }
}
