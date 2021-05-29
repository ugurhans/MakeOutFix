using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class EfIllnessDal : EfEntityRepositoryBase<Illness, MakeOutFixContext>, IIllnessDal
    {
    }
}
