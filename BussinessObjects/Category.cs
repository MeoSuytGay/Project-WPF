using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public partial class Category
    {
        // Constructor
        public Category(int catId, string catName)
        {
            this.CategoryId = catId;
            this.CategoryName = catName;
            Products = new HashSet<Product>();
        }

        // Properties
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null;

        // Collection of products in this category
        public virtual ICollection<Product> Products { get; set; }
    }
}
