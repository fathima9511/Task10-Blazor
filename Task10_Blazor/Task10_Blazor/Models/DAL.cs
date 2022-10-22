using System.Collections.Generic;
using System.Linq;

namespace Task10_Blazor.Models
{
	public class DAL
	{
        BlazorDBContext db = new BlazorDBContext();

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}
