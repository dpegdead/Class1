using Facepunch;
using Oxide.Core;
using Oxide.Plugins;

namespace HelloWorldRust
{
    [Info("Hello World Rust", "DPEG", "0.1")]
    class TestingOfDPEG : RustPlugin
    {
        void Init()
        {
            Puts("Init!");
        }


    }
}
