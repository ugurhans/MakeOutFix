using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class EfDietDal : EfEntityRepositoryBase<Diet, MakeOutFixContext>, IDietDal
    {
        public List<Diet> GetDietsDay(Expression<Func<Diet, bool>> filter = null)
        {
            using (MakeOutFixContext context = new MakeOutFixContext())
            {

                var diet = context.Diets.Include(d => d.Days).Include(d => d.Patient).ToList();

                return diet.ToList();

            }

        }
    }
}
