﻿// <copyright file="IncreaseStatsAction.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlayerActions.Character
{
    using System.Linq;
    using MUnique.OpenMU.AttributeSystem;

    /// <summary>
    /// Action to increase stat attributes.
    /// </summary>
    public class IncreaseStatsAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncreaseStatsAction"/> class.
        /// </summary>
        public IncreaseStatsAction()
        {
        }

        /// <summary>
        /// Increases the specified stat attribute by one point, if enough points are available.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="statAttributeDefinition">The stat attribute definition.</param>
        public void IncreaseStats(Player player, AttributeDefinition statAttributeDefinition)
        {
            if (player.SelectedCharacter.LevelUpPoints > 0)
            {
                var attributeDef = player.SelectedCharacter.CharacterClass.StatAttributes.FirstOrDefault(a => a.Attribute == statAttributeDefinition);
                if (attributeDef != null && attributeDef.IncreasableByPlayer)
                {
                    player.Attributes[attributeDef.Attribute]++;
                    player.SelectedCharacter.LevelUpPoints--;
                    player.PlayerView.StatIncreaseResult(statAttributeDefinition, true);
                    return;
                }
            }

            player.PlayerView.StatIncreaseResult(statAttributeDefinition, false);
        }
    }
}
