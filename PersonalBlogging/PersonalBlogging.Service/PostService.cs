using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlogging.Domain.Entities;

namespace PersonalBlogging.Service
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPostsByUser(int userId);
        void AddBlog(Post post);
    }

    public partial class PersonalPostService
    {
        public IEnumerable<Post> GetAllPostsByUser(int userId)
        {
            return this.postRepository.GetQuery().AsEnumerable();
        }

        public void AddBlog(Post post)
        {
            this.postRepository.Add(post);
            this.postRepository.SaveChanges();
        }
    }
}
