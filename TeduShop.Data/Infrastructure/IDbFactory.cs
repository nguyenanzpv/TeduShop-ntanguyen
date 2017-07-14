using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory:IDisposable//doi tuong giao tiep dung de khoi tao cac doi tuong entity
    {
        TeduShopDbContext Init();
    }
}
