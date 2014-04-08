using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nt.Contract.Domain;

namespace PersonalBlogging.Domain.Entities
{
    [Table("Post")]
    public class Post : NtEntity
    {
        public string Title { get; set; }
    }
}
