using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrate;
using DataAccess.Abstract;
using DataAccess.Concrate.EntitiyFrameWork;
using Entities.DTOs;

namespace DataAccess.Concrate.EntityFrameWork
{
    public class EfUserDal : EfEntityRepositoryBase<User, MakeOutFixContext>, IUserDal
    {



    }
}
