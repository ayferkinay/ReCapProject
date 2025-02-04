﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        //  IDataResult<T> buradaki t List<Car> olan kısma tekabül ediyor
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByColorId(int colorId);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int id);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

       
    }
}