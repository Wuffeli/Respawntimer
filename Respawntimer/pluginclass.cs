using Synapse.Api.Plugin;
using Synapse.Api;
using Synapse;
using System;

namespace Respawntimer
{
    [PluginInformation(
        Author = "Wuffeli",
        Description = "This will show, how long it will take until you respawn",
        LoadPriority = 0,
        Name = "Respawntimer",
        SynapseMajor = 2,
        SynapseMinor = 6,
        SynapsePatch = 1,
        Version = "V1.0.0"
        )]
    public class pluginclass : AbstractPlugin
    {
        public override void Load()
        {
            base.Load();
            Server.Get.Events.Player.PlayerDeathEvent += Player_PlayerDeathEvent;
        }
        private void Player_PlayerDeathEvent(Synapse.Api.Events.SynapseEventArguments.PlayerDeathEventArgs ev)
        {
            var respawntime = Round.Get.NextRespawn;
            ev.Victim.SendBroadcast(10, $"You will respawn in {System.Math.Round(respawntime)} seconds!");
        }
    }
}