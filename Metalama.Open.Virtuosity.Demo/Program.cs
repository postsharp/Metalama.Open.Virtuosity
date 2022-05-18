// Copyright (c) SharpCrafters s.r.o. All rights reserved.
// This project is not open source. Please see the LICENSE.md file in the repository root for details.

using Metalama.Open.Virtuosity.Demo;
using Moq;

var mock = new Mock<Foo>();

mock.Setup( foo => foo.Bar() ).Returns( "Mocked!" );

// If the mock succeeded, this should print "Mocked!".
Console.WriteLine( mock.Object.Bar() );
