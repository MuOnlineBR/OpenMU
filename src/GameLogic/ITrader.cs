﻿// <copyright file="ITrader.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic
{
    /// <summary>
    /// Interface of a trader.
    /// </summary>
    public interface ITrader
    {
        /// <summary>
        /// Gets the character name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the traders level.
        /// </summary>
        int Level { get; }

        /// <summary>
        /// Gets or sets the current trading partner.
        /// </summary>
        ITrader TradingPartner { get; set; }

        /// <summary>
        /// Gets or sets the money which is currently in the trade.
        /// </summary>
        int TradingMoney { get; set; }

        /// <summary>
        /// Gets or sets the short guild identifier.
        /// </summary>
        ushort ShortGuildID { get; set; }

        /// <summary>
        /// Gets the inventory.
        /// </summary>
        IStorage Inventory { get; }

        /// <summary>
        /// Gets the temporary storage, which holds the items of the trade.
        /// </summary>
        IStorage TemporaryStorage { get; }

        /// <summary>
        /// Gets or sets the backup inventory.
        /// </summary>
        BackupItemStorage BackupInventory { get; set; }

        /// <summary>
        /// Gets or sets the available money.
        /// </summary>
        int Money { get; set; }

        /// <summary>
        /// Gets the state of the player.
        /// </summary>
        StateMachine PlayerState { get; }
    }
}
