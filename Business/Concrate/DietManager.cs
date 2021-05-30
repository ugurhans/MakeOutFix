using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
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

        public IDataResult<List<Diet>> GetAll()
        {
            return new SuccessDataResult<List<Diet>>(_dietDal.GetAll());
        }

        public IDataResult<List<Diet>> GetAllDays()
        {
            return new SuccessDataResult<List<Diet>>(_dietDal.GetAllDiet());
        }

        public IDataResult<Diet> GetById(int dietId)
        {
            return new SuccessDataResult<Diet>(_dietDal.Get(d => d.Id == dietId));
        }

        public IDataResult<List<DietDto>> GetAllDietDto()
        {
            return new SuccessDataResult<List<DietDto>>(_dietDal.GetDietDto());
        }

        public IDataResult<List<DietDto>> GetAllDietDtoByMethod(int methodId)
        {
            return new SuccessDataResult<List<DietDto>>(_dietDal.GetDietDto(m => m.MethodId == methodId));
        }

        public IResult Add(Diet diet)
        {
            _dietDal.Add(diet);
            return new SuccessResult();
        }

        public IResult Delete(Diet diet)
        {
            _dietDal.Delete(diet);
            return new SuccessResult();
        }

        public IResult Update(Diet diet)
        {
            _dietDal.Update(diet);
            return new SuccessResult();
        }

        public IDataResult<Diet> AddDiet(DietDto dietDto)
        {
            var diet = new Diet()
            {
                DietMethodId = dietDto.MethodId,
                Name = dietDto.Name,
                Days = dietDto.Days
            };
            _dietDal.Add(diet);
            return new SuccessDataResult<Diet>(diet, "Added Diet");
        }
    }
}
