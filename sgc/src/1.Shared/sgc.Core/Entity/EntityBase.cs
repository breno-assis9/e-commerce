namespace sgc.Core.Entity
{
    public abstract class EntityBase
    {
        protected EntityBase(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; protected set; }
    }
}
