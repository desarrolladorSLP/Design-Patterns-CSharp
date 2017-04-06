using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interpreter
{
    public interface Expression
    {
		double Evaluate(Context context);
    }
}
