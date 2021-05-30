using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrate;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IDietService
    {
        IDataResult<List<Diet>> GetAll();
        IDataResult<List<Diet>> GetAllDays();
        IDataResult<Diet> GetById(int dietId);

        IDataResult<List<DietDto>> GetAllDietDto();
        IDataResult<List<DietDto>> GetAllDietDtoByMethod(int methodId);

        IResult Add(Diet diet);
        IResult Delete(Diet diet);
        IResult Update(Diet diet);
    }
}
