using Facepunch;
namespace HelloWorldRust
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
