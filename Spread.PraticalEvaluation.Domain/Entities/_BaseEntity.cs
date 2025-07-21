namespace Spread.PraticalEvaluation.Domain.Entities
{
    public abstract class BaseEntity<TDataKeyType>
    {
        public TDataKeyType Id { get; set; }
    }
}
