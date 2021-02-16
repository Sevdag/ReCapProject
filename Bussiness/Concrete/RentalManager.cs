﻿using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bussiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null && _rentalDal.GetCarDetails(p => p.CarId == rental.CarId).Count > 0)
            {
                return new ErrorResult(Messages.InvalidRent);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Rental>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentDetailDto>> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            return new SuccessDataResult<List<RentDetailDto>>(_rentalDal.GetCarDetails(filter), Messages.InvalidRent);
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
