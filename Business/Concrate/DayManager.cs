using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrate;
using Entities.Dtos;

namespace Business.Concrate
{
    public class DayManager : IDayService
    {
        private IDayDal _dayDal;

        public DayManager(IDayDal dayDal)
        {
            _dayDal = dayDal;
        }

        public IDataResult<List<Day>> GetAll()
        {
            return new SuccessDataResult<List<Day>>(_dayDal.GetAll());
        }

        public IDataResult<Day> GetById(int dayId)
        {
            return new SuccessDataResult<Day>(_dayDal.Get(d => d.Id == dayId));
        }

        public IResult Add(Day day)
        {
            _dayDal.Add(day);
            return new SuccessResult(Messages.DayAdded);
        }



        public IResult Delete(Day day)
        {
            _dayDal.Delete(day);
            return new SuccessResult();
        }

        public IResult Update(Day day)
        {
            _dayDal.Update(day);
            return new SuccessResult();
        }
    }
}
