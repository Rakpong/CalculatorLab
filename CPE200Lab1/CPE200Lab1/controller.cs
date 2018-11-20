using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
	public class controller
	{
		CalculatorEngine engine1;
		RPNCalculatorEngine engine2;
		public controller()
		{
			engine1 = new CalculatorEngine();
			engine2 = new RPNCalculatorEngine();
		}

		public string Calculate(string str)
		{
			return engine1.calculate(str);
		}

		public string RPNcalculate(string str)
		{
			return engine2.calculate(str);
		} 

	}
}
