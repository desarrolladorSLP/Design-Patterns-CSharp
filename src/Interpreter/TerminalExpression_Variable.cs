using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interpreter
{
	public class TerminalExpression_Variable : Expression
	{
		public string Name { get; private set; }

		public TerminalExpression_Variable(string name)
		{
			Name = name;
		}
		public double Evaluate(Context context)
		{
			return context[Name];
		}
	}
}
