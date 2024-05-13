using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace BlazorLifecycle4.Pages.Components
{
    public sealed partial class DemoComponent : ComponentBase, IDisposable, IAsyncDisposable
    {
        [Inject] private ILogger<DemoComponent> Logger { get; set; }

        [Parameter] public int Value { get; set; }

        // použito jen pro přiřazení v Demo04
        [Parameter] public CultureInfo Culture { get; set; }

		// všechny virtuální metody životního cyklu logují své volání (viditelné v Output okně při debuggingu)
		// přidány metody Dispose, DisposeAsync (vč. interfaces)        

		public override async Task SetParametersAsync(ParameterView parameters)
        {
            LogMethodCall(nameof(SetParametersAsync) + " - start");
            await base.SetParametersAsync(parameters); // watch: parameters.ToDictionary()
            LogMethodCall(nameof(SetParametersAsync) + " - end");
        }

        protected override void OnInitialized()
        {
            LogMethodCall(nameof(OnInitialized));
            base.OnInitialized();
        }

        protected override async Task OnInitializedAsync()
        {
            LogMethodCall(nameof(OnInitializedAsync));
            //await Task.Yield();
            await base.OnInitializedAsync();
        }

        protected override void OnParametersSet()
        {
            LogMethodCall(nameof(OnParametersSet));
            base.OnParametersSet();
        }

        protected override async Task OnParametersSetAsync()
        {
            LogMethodCall(nameof(OnParametersSetAsync));
            //await Task.Yield();
            await base.OnParametersSetAsync();
        }

        protected override bool ShouldRender()
        {
            LogMethodCall(nameof(ShouldRender));
            return base.ShouldRender();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            LogMethodCall(nameof(OnAfterRender));
            base.OnAfterRender(firstRender);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            LogMethodCall(nameof(OnAfterRenderAsync));
            //await Task.Yield();
            await base.OnAfterRenderAsync(firstRender);
        }

        public void Dispose()
        {
            LogMethodCall(nameof(Dispose));
        }

        public ValueTask DisposeAsync()
        {
            LogMethodCall(nameof(DisposeAsync));
            return ValueTask.CompletedTask;
        }

        private void LogMethodCall(string methodName)
        {
            Logger.LogInformation(GetHashCode() + " " + methodName);
        }
    }
}
