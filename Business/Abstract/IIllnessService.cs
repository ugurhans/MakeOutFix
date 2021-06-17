using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface IIllnessService
    {

        IDataResult<List<Illness>> GetAll();
        IDataResult<Illness> GetById(int illnessId);
        IResult Add(Illness illness);
        IResult Delete(Illness illness);
        IResult Update(Illness illness);
    }
}
