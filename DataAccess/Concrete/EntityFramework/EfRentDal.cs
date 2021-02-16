using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal: EfEntityRepositoryBase<Rental, RecapContext>, IBrandDal
    {
    }
}
