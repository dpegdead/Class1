using Facepunch;
using Oxide.Rust;
using Oxide.Core;
using Oxide.References;
using Oxide.Rust;
using Oxide.Plugins;

namespace HelloWorldRust
{
    [Info("Hello World Rust", "DPEG", "0.1")]
    class HelloWorld : RustPlugin
    {
        void Init()
        {
            Puts("Init!");
        }


    }
}
