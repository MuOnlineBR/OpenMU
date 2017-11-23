﻿// <copyright file="ExitGate.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.DataModel.Configuration
{
    /// <summary>
    /// Defines a gate through which a player enters a map.
    /// </summary>
    public class ExitGate : Gate
    {
        /// <summary>
        /// Gets or sets the direction to which the player looks when he enters the map.
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Gets or sets the map which will be entered.
        /// </summary>
        public virtual GameMapDefinition Map { get; set; }
    }
}
