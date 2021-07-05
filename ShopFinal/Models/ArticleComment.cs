using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopFinal.Models
{
    public class ArticleComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public DateTime PublishedDate { get; set; }
        public int ArticlesId { get; set; }
        public Product Article { get; set; }
        public int Rating { get; set; }
    }
}
