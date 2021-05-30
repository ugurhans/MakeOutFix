using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities;
using Entities.Concrate;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IDietDal : IEntityRepository<Diet>
    {
        List<DietDto> GetDietDto(Expression<Func<DietDto, bool>> filter = null);

    }
}
