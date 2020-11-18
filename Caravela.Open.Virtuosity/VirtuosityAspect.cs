using System;
using Caravela.Framework.Aspects;

namespace Caravela.Open.Virtuosity
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class VirtuosityAspect : Attribute, IAspect { }
}
