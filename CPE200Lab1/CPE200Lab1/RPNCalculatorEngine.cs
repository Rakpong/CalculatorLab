using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine : TheCalculatorEngine
    {
		protected Stack<string> myStack = new Stack<string>();
		public string calculate(string str)
        {
			string[] parts = str.Split(' ');
			bool beforeOperate = false;

			foreach(string num in parts)
			{
				if (isNumber(num))
				{
					myStack.Push(num);
					
				}
				if (isOperator(num))
				{
					string first, second;
					if (myStack.Count < 2) return "E";
					second = myStack.Pop();
					first = myStack.Pop();
					myStack.Push(calculate(num, first, second));
					beforeOperate = true;
				}
				if (is_exOperator(num))
				{
					string first;
					if (myStack.Count < 1) return "E";
					first = myStack.Pop();
					myStack.Push(calculate(num, first));
					beforeOperate = true;
				}
			}
			if(myStack.Count > 1||beforeOperate == false) return "E";
			return myStack.Pop();

		}
	}
}
