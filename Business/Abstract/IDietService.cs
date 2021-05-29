using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface IDietService
    {
        IDataResult<List<Diet>> GetAll();
        IDataResult<List<Diet>> GetAllDays();
        IDataResult<Diet> GetById(int dietId);
        IResult Add(Diet diet);
        IResult Delete(Diet diet);
        IResult Update(Diet diet);
    }
}
