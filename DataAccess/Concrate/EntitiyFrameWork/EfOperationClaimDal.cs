using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrate;
using DataAccess.Abstract;
using DataAccess.Concrate.EntitiyFrameWork;

namespace DataAccess.Concrate.EntityFrameWork
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, MakeOutFixContext>, IOperationClaimDal
    {
    }
}
