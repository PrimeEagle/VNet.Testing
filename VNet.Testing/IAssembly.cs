using System;
using System.Collections.Generic;
using System.Reflection;

namespace VNet.Testing
{
	public interface IAssembly
    {
	    Assembly Assembly { get; init; }

	    IEnumerable<Type> GetTypes();
    }
}
