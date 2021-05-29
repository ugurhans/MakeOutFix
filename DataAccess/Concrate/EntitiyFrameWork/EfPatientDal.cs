using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class EfPatientDal : EfEntityRepositoryBase<Patient, MakeOutFixContext>, IPatientDal
    {
    }
}
