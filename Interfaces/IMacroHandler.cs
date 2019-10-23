using Penguin.DependencyInjection.Abstractions.Interfaces;
using System.Collections.Generic;

namespace Penguin.Cms.Abstractions.Interfaces
{
    public interface IMacroProvider : ISelfRegistering
    {
        List<Macro> GetMacros(object requester);
    }
}