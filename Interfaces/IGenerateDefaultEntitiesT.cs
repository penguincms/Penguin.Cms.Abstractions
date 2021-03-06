﻿using System.Collections.Generic;

namespace Penguin.Cms.Abstractions.Interfaces
{
    /// <summary>
    /// Generates default entities of a specific type
    /// </summary>
    /// <typeparam name="T">The type this generator creates</typeparam>
    public interface IGenerateDefaultEntities<T> : IGenerateDefaultEntities
    {
        /// <summary>
        /// Returns an IEnumerable of generated entities
        /// </summary>
        /// <returns>An IEnumerable of generated entities</returns>
        new IEnumerable<T> Generate();
    }
}