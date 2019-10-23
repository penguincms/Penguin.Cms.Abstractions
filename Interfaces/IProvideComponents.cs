using Penguin.DependencyInjection.Abstractions.Interfaces;
using System.Collections.Generic;

namespace Penguin.Cms.Abstractions.Interfaces
{
    public interface IProvideComponents<out TReturn, in TParameter> : ISelfRegistering
    {
        IEnumerable<TReturn> GetComponents(TParameter Id);
    }

    public interface IProvideComponents<out TReturn> : ISelfRegistering
    {
        IEnumerable<TReturn> GetComponents();
    }
}