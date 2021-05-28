using Synapse.Command;
using Synapse.Api;
using System.Linq;
using System;

namespace Respawntimer
{
    [CommandInformation(
        Name = "Respawntime",
        Aliases = new string[] {"rt"},
        Description = "Shows you the time until you respawn.",
        Permission = "",
        Platforms = new[] {Platform.ClientConsole, Platform.ServerConsole},
        Usage = ".rt or .Respawntime"
        )]
    class Commands : ISynapseCommand
    {
        public CommandResult Execute(CommandContext context)
        {
            var respawntime = Round.Get.NextRespawn;
            return new CommandResult
            {
                Message = $"You will respawn in {System.Math.Round(respawntime)}"
            };
        }
    }
}
