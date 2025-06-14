using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phuclien_company.Models;

namespace phuclien_company.FakeData
{
    public static class FakeData
    {
        public static List<ProductModel> Products = new List<ProductModel>
        {
            new ProductModel
            {
                Id = Guid.NewGuid(),
                Name = "Product 1",
                Price = 10.0m,
                Description = "Description for Product 1",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ImageUrl = "https://thietbitoanha.vn/wp-content/uploads/2024/11/guong-cau-loi-600x600.jpg"
            },
            new ProductModel
            {
                Id = Guid.NewGuid(),
                Name = "Product 2",
                Price = 20.0m,
                Description = "Description for Product 2",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ImageUrl = "https://thietbitoanha.vn/wp-content/uploads/2024/11/May-boc-giay-tu-dong-PLC-XT-46C-600x600.jpg"
            }
        };
    }
}