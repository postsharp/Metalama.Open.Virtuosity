// This is an open-source Metalama example. See https://github.com/postsharp/Metalama.Samples for more.

using Metalama.Open.Virtuosity.Demo;
using Moq;

var mock = new Mock<Foo>();

mock.Setup( foo => foo.Bar() ).Returns( "Mocked!" );

// If the mock succeeded, this should print "Mocked!".
Console.WriteLine( mock.Object.Bar() );