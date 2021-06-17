using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities;
using Entities.Concrate;

namespace DataAccess.Abstract
{
    public interface IPatientDal : IEntityRepository<Patient>
    {
    }
}
