using Penguin.Cms.Abstractions.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Penguin.Cms.Abstractions
{
    /// <summary>
    /// A base class for generating default entities of a type
    /// </summary>
    /// <typeparam name="T">The type of entity that this generator produces</typeparam>
    public abstract class DefaultEntityGenerator<T> : IGenerateDefaultEntities<T>
    {
        /// <summary>
        /// Generate the entities
        /// </summary>
        /// <returns>The default entities</returns>
        public abstract IEnumerable<T> Generate();

        IEnumerable IGenerateDefaultEntities.Generate()
        {
            foreach (object o in Generate())
            {
                yield return o;
            }
        }
    }
}