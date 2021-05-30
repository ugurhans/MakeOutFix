using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrate;

namespace Business.Concrate
{
    public class IllnessManager : IIllnessService
    {
        private IIllnessDal _illnessDal;

        public IllnessManager(IIllnessDal illnessDal)
        {
            _illnessDal = illnessDal;
        }

        public IDataResult<List<Illness>> GetAll()
        {
            return new SuccessDataResult<List<Illness>>(_illnessDal.GetAll());
        }

        public IDataResult<Illness> GetById(int illnessId)
        {
            return new SuccessDataResult<Illness>(_illnessDal.Get(i => i.Id == illnessId));
        }

        public IResult Add(Illness illness)
        {
            _illnessDal.Add(illness);
            return new SuccessResult();
        }

        public IResult Delete(Illness illness)
        {
            _illnessDal.Delete(illness);
            return new SuccessResult();
        }

        public IResult Update(Illness illness)
        {
            _illnessDal.Update(illness);
            return new SuccessResult();
        }
    }
}
