using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrate;

namespace Business.Concrate
{
    public class DietMethodManager : IDietMethodService
    {
        private IDietMethodDal _dietMethodDal;

        public DietMethodManager(IDietMethodDal dietMethodDal)
        {
            _dietMethodDal = dietMethodDal;
        }

        public IDataResult<List<DietMethod>> GetAll()
        {
            return new SuccessDataResult<List<DietMethod>>(_dietMethodDal.GetAll());
        }

        public IDataResult<DietMethod> GetById(int dietMethodId)
        {
            return new SuccessDataResult<DietMethod>(_dietMethodDal.Get(d => d.Id == dietMethodId));
        }

        public IResult Add(DietMethod dietMethod)
        {
            _dietMethodDal.Add(dietMethod);
            return new SuccessResult();
        }

        public IResult Delete(DietMethod dietMethod)
        {
            _dietMethodDal.Delete(dietMethod);
            return new SuccessResult();
        }

        public IResult Update(DietMethod dietMethod)
        {
            _dietMethodDal.Update(dietMethod);
            return new SuccessResult();
        }
    }
}
