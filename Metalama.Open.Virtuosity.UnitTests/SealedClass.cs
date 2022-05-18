// Copyright (c) SharpCrafters s.r.o. All rights reserved.
// This project is not open source. Please see the LICENSE.md file in the repository root for details.

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