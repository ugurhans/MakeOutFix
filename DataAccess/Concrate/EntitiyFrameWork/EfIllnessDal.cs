using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrate;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class EfIllnessDal : EfEntityRepositoryBase<Illness, MakeOutFixContext>, IIllnessDal
    {
    }
}
