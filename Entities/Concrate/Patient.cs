using Core.Entities;

namespace Entities.Concrate
{
    public class Patient : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int IllnessId { get; set; }

    }
}