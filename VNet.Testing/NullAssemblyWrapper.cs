using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// ReSharper disable InconsistentNaming

namespace VNet.Testing
{
    public class NullAssemblyWrapper : IAssembly
    {
	    public Assembly Assembly { get; init; }

        private ICollection<Type> _types;

        public NullAssemblyWrapper()
        {
            _types = new List<Type>();
            this.Assembly = null;
        }

		public Assembly GetExecutingAssembly()
        {
            return null;
        }

        public IEnumerable<Type> GetTypes()
        {
            return _types.ToArray();
        }
    }
}
