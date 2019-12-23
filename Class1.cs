using Facepunch;
using Oxide;
using System;

namespace Oxide.Plugins
{
    [Info("DPEG PLUGIN", "DPEG", "0.1")]
    [Description("A Plugin Made By DPEG")]
    class Class1 : CovalencePlugin
    {
        private void Init()
        {
            Puts("Initiated");
            Puts("Welcome To Server DPEG");

        }

        private void Init()
        {
            permission.RegisterPermission("loottest.use", this);
        }

        [Command("loot test"), Permission("loottest.use")]
        private void LootTestCommand(BasePlayer player, string command, string[] args)
        {
            player.Reply("Command Unavailable");
        }

        [Command("Ping")]
        private void PingCommand(BasePlayer player, string command, string[] args)
        {
            player.Reply("Pong");
        }
    }
}
