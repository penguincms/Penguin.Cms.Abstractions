using System.Collections;

namespace Penguin.Cms.Abstractions.Interfaces
{
    /// <summary>
    /// Generates any kind of default object
    /// </summary>
    public interface IGenerateDefaultEntities
    {
        /// <summary>
        /// Should return an IEnumerable with entities
        /// </summary>
        /// <returns>An IEnumerable with entities</returns>
        IEnumerable Generate();
    }
}