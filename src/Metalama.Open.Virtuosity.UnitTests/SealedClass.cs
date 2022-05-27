// This is an open-source Metalama example. See https://github.com/postsharp/Metalama.Samples for more.

#pragma warning disable CA1822 // Mark members as static

namespace Metalama.Open.Virtuosity.Tests.Struct
{
    // Transformed (sealed removed).
    [VirtualizeAttribute]
    internal sealed class SealedClass
    {
        // Transformed.
        public void M() { }
    }
}