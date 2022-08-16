using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Url
    {
        public int Id { get; set; }
        public int TweetId { get; set; }
        public string TweetUrl { get; set; }
    }
}
