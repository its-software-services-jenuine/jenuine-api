using System.Collections.Generic;
using Its.Jenuiue.Api.ModelsViews;

namespace Its.Jenuiue.Api.Actions
{
    public interface IActionQuery
    {
        public List<T> Apply<T>(T param, BaseModelView queryParam);
    }
}
