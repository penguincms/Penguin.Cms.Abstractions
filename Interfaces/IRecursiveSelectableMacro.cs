using System.Collections.Generic;

namespace Penguin.Cms.Abstractions.Interfaces
{
    public interface IRecursiveSelectableMacro
    {
        IList<IRecursiveSelectableMacro> Children { get; }

        string DisplayName { get; set; }

        string MacroBody { get; }
    }
}