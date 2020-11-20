using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNI.Model.Model
{
   public class Comment
    {
        public int Id { get; set; }
        public string CommentValue { get; set; }
        public User User { get; set; }
        public Recipe Recipe { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
