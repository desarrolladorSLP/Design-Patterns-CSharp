using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns_CSharp
{
    public interface Expression
    {
		double Evaluate(Context context);
    }
}
