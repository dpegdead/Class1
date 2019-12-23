using Facepunch;
namespace HelloWorldRust Oxide.Plugins
{
    [Info("Hello World Rust", "DPEG", "0.1")]
    public class HelloWorld : RustPlugin
    {
        void Init()
        {
            Puts("Init!");
        }


    }
}
