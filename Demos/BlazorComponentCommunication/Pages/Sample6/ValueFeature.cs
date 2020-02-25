using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentCommunication.Pages.Sample6
{
	public class ValueFeature : Feature<ValueState>
	{
		public override string GetName() => "Value";
		protected override ValueState GetInitialState() => new ValueState(0);
	}
}
