using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        // Method to get a list of categories
        public static List<Category> GetCategories()
        {
            List<Category> listCategories = new List<Category>();

            try
            {
                // Creating category instances
                Category beverages = new Category(1, "Beverages");
                Category confections = new Category(2, "Confections");
                Category dairy = new Category(3, "Dairy Products");
                Category grains = new Category(4, "Grains/Cereals");
                Category meat = new Category(5, "Meat");
                Category produce = new Category(6, "Produce");
                Category seafood = new Category(7, "Seafood");

                // Adding categories to the list
                listCategories.Add(beverages);
                listCategories.Add(confections);
                listCategories.Add(dairy);
                listCategories.Add(grains);
                listCategories.Add(meat);
                listCategories.Add(produce);
                listCategories.Add(seafood);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listCategories;
        }
    }
}
