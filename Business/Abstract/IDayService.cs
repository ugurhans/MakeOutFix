using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Business.Abstract
{
    public interface IDayService
    {
        IDataResult<List<Day>> GetAll();
        IDataResult<Day> GetById(int dayId);
        IResult Add(Day day);
        IResult Delete(Day day);
        IResult Update(Day day);
    }
}
