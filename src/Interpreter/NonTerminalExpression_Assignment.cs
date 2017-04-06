using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interpreter
{
	public class NonTerminalExpression_Assignment : Expression
	{
		private Expression left;
		private Expression right;
		public double Evaluate(Context context)
		{
			double result = right.Evaluate(context);

			//if (!(left.GetType() == typeof(Context)))
			{

			}
			//context[left.get]
			return result;
		}
	}
}
