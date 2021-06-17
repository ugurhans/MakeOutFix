using Core.Entities;

namespace Entities.Concrate
{
    public class Illness : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
