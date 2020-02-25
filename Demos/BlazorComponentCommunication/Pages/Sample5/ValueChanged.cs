using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentCommunication.Pages.Sample5
{
	public class ValueChanged
	{
		public int Value { get; }

		public ValueChanged(int value)
		{
			Value = value;
		}
	}
}
