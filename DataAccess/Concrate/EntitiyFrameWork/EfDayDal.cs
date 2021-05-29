using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class EfDayDal : EfEntityRepositoryBase<Day, MakeOutFixContext>, IDayDal
    {
    }
}
