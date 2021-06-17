using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.BusinessAspect;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrate;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore.Query;

namespace Business.Concrate
{
    public class DietManager : IDietService
    {
        private IDietDal _dietDal;

        public DietManager(IDietDal dietDal)
        {
            _dietDal = dietDal;
        }

        [CacheAspect(10)]
        public IDataResult<List<Diet>> GetAll()
        {
            return new SuccessDataResult<List<Diet>>(_dietDal.GetAll());
        }


        [CacheAspect(10)]
        public IDataResult<List<Diet>> GetAllDays()
        {
            return new SuccessDataResult<List<Diet>>(_dietDal.GetAllDiet());
        }

        [CacheAspect(10)]
        public IDataResult<Diet> GetById(int dietId)
        {
            return new SuccessDataResult<Diet>(_dietDal.Get(d => d.Id == dietId));
        }

        [CacheAspect(10)]
        public IDataResult<List<DietDto>> GetAllDietDto()
        {
            return new SuccessDataResult<List<DietDto>>(_dietDal.GetDietDto());
        }

        [CacheAspect(10)]
        public IDataResult<List<DietDto>> GetAllDietDtoByMethod(int methodId)
        {
            return new SuccessDataResult<List<DietDto>>(_dietDal.GetDietDto(m => m.MethodId == methodId));
        }

        [CacheRemoveAspect("Get")]
        [SecuredOperation("admin,doc")]
        public IResult Add(Diet diet)
        {
            _dietDal.Add(diet);
            return new SuccessResult();
        }


        [CacheRemoveAspect("Get")]
        [SecuredOperation("doc")]
        public IResult Delete(Diet diet)
        {
            _dietDal.Delete(diet);
            return new SuccessResult();
        }

        [CacheRemoveAspect("Get")]
        [SecuredOperation("doc")]
        public IResult Update(Diet diet)
        {
            _dietDal.Update(diet);
            return new SuccessResult();
        }

    }
}
