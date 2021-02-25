using ShowcaseWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowcaseWeb.Domain
{
    public interface IProductService
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(int productId);
    }
}
