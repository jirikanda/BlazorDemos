using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentCommunication.Pages.Sample6
{
	public class ValueState
	{
		public int Value { get; }

		public ValueState(int value)
		{
			this.Value = value;
		}
	}
}
