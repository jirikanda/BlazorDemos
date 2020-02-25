using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.BlazorComponentCommunication.Pages.Sample6
{
	public class IncrementValueReducer : Reducer<ValueState, IncrementValueAction>
	{
		public override ValueState Reduce(ValueState state, IncrementValueAction action)
		{
			return new ValueState(state.Value + 1);
		}
	}
}
