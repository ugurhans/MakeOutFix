using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrate;
using Entities.Dtos;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class EfDayDal : EfEntityRepositoryBase<Day, MakeOutFixContext>, IDayDal
    {

    }
}
