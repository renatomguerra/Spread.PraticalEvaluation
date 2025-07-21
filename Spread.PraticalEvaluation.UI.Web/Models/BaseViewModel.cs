using AutoMapper;

namespace Spread.PraticalEvaluation.UI.Web.Models
{
    public abstract class BaseViewModel<TDataKeyType>
    {
        public TDataKeyType Id { get; set; }
    }

}
