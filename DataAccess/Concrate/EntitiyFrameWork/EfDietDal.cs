using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrate;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class EfDietDal : EfEntityRepositoryBase<Diet, MakeOutFixContext>, IDietDal
    {
        public List<Diet> GetAllDiet(Expression<Func<Diet, bool>> filter = null)
        {
            using (MakeOutFixContext context = new MakeOutFixContext())
            {

                var diet = context.Diets.Include(d => d.Days);

                return diet.ToList();

            }
        }

        public List<DietDto> GetDietDto(Expression<Func<DietDto, bool>> filter = null)
        {
            using (MakeOutFixContext context = new MakeOutFixContext())
            {
                var result = from d in context.Diets
                             join dm in context.DietMethods
                                 on d.DietMethodId equals dm.Id
                             select new DietDto()
                             {
                                 DietMethodName = dm.Name,
                                 Name = d.Name,
                                 Days = d.Days,
                                 MethodId = dm.Id
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

    }
}
