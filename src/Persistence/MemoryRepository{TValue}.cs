﻿// <copyright file="MemoryRepository{TValue}.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A repository wich lives on memory only.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public class MemoryRepository<TValue> : IRepository<TValue>
    {
        private readonly IDictionary<Guid, TValue> values = new Dictionary<Guid, TValue>();

        /// <summary>
        /// Adds an item to the repository.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="obj">The item.</param>
        public void Add(Guid key, TValue obj)
        {
            this.values.Add(key, obj);
        }

        /// <inheritdoc/>
        public TValue GetById(Guid id)
        {
            this.values.TryGetValue(id, out TValue obj);
            return obj;
        }

        /// <inheritdoc/>
        object IRepository.GetById(Guid id)
        {
            return this.GetById(id);
        }

        /// <inheritdoc/>
        public bool Delete(object obj)
        {
            var key = this.values.Where(kvp => kvp.Value.Equals(obj)).Select(kvp => kvp.Key).FirstOrDefault();
            return this.values.Remove(key);
        }

        /// <inheritdoc/>
        public bool Delete(Guid id)
        {
            return this.values.Remove(id);
        }

        /// <inheritdoc/>
        public IEnumerable<TValue> GetAll()
        {
            return this.values.Values;
        }
    }
}
