using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.Models
{
    public class CommentListViewModel
    {   
        public IEnumerable<CommentViewModel> Comments { get; set; }
        public int MostRecent { get; set; }
    }
}
