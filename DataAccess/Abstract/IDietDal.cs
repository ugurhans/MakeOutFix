using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
    public interface IDietDal : IEntityRepository<Diet>
    {
        List<Diet> GetDietsDay(Expression<Func<Diet, bool>> filter = null);
    }
}
