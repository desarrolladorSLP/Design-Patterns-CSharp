using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {
		private readonly Dictionary<string, double> symbolTable = new Dictionary<string, double>();

		public double this[string key]
		{
			get { return GetVariable(key); }
			set { SetVariable(key, value); }
		}
		private Context SetVariable(string name, double value)
		{
			symbolTable.Add(name, value);
			return this;
		}
		private double GetVariable(string key)
		{
			double value;
			if (!symbolTable.TryGetValue(key, out value))
			{
				throw new UndefiniedSymbolException(key);
			}
			return value;		
		}
	}
	public class UndefiniedSymbolException : KeyNotFoundException
	{
		public UndefiniedSymbolException(string variableName) : base("Undefined symbol: " + variableName) { }
	}
}
