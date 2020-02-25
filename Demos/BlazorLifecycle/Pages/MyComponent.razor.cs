using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLifecycle.Pages
{
	public partial class MyComponent
	{
		protected List<string> log = new List<string>();

		[Parameter]
		public int SomeValue { get; set; }

		protected override void OnInitialized()
		{
			log.Add("OnInitialized");
			base.OnInitialized();
		}

		protected override void OnParametersSet()
		{
			log.Add("OnParametersSet");
			base.OnParametersSet();
		}

		protected override bool ShouldRender()
		{
			log.Add("ShouldRender");
			return true; // base.ShouldRender();
		}

		protected override void OnAfterRender(bool firstRender)
		{
			log.Add("OnAfterRender");
			base.OnAfterRender(firstRender);
		}

		public override async Task SetParametersAsync(ParameterView parameters)
		{
			log.Add("SetParametersAsync - start");
			await base.SetParametersAsync(parameters);
			log.Add("SetParametersAsync - end");
		}
	}
}
