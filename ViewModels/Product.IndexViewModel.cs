
using phuclien_company.Models;

namespace phuclien_company.ViewModels
{
    public class ProductIndexViewModel
    {
        public required IEnumerable<ProductModel> Products { get; set; }
    }
}