using Oxide.Rust;
using Facepunch;
using Oxide;

namespace Oxide.Plugins
{
    [Info("DPEG PLUGIN", "DPEG", "0.1")]
    [Description("A Plugin Made By DPEG")]
    class Class1 : RustPlugin
    {
        private void Init()
        {
            Puts("Initiated");
        }
    }
}
