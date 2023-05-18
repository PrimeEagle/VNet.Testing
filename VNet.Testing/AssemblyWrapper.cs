using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace VNet.Testing
{
	[ExcludeFromCodeCoverage]
    public class AssemblyWrapper : IAssembly
    {
        public Assembly Assembly { get; init; }

        public AssemblyWrapper(Assembly assembly)
        {
            this.Assembly = assembly;
        }

        public IEnumerable<Type> GetTypes()
        {
            return this.Assembly.GetTypes();
        }

        public Assembly GetExecutingAssembly()
        {
            return this.Assembly;
        }
    }
}