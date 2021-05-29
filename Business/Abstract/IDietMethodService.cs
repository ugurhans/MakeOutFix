using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface IDietMethodService
    {
        IDataResult<List<DietMethod>> GetAll();
        IDataResult<DietMethod> GetById(int dietMethodId);
        IResult Add(DietMethod dietMethod);
        IResult Delete(DietMethod dietMethod);
        IResult Update(DietMethod dietMethod);
    }
}
