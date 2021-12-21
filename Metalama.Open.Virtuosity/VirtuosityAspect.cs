using System;
using Metalama.Framework.Aspects;

namespace Metalama.Open.Virtuosity
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class VirtuosityAspect : Attribute, IAspect { }
}
