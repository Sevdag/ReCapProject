using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
   public interface ICustomerService
    {

        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetCarsByBrandId(int id);
        IDataResult<List<Customer>> GetCarsByColorId(int id);
        IDataResult<Customer> GetById(int id);
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        //IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
