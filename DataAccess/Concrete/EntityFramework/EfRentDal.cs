using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal : EfEntityRepositoryBase<Rental, RecapContext>, IRentalDal
    {
        public List<RentDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cs in context.Customers
                             on r.CustomerId equals cs.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join u in context.Users
                             on cs.UserId equals u.Id
                             select new RentDetailDto
                             {
                                 RentalId = r.Id,
                                 CarName = b.BrandName,
                                 CustomerName = cs.CustomerName,
                                 UserName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
