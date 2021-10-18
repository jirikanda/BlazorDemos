using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Diagnostics;

namespace BlazorErrorHandling.Pages
{
    public class MyCustomErrorBoundary : ErrorBoundary /* ErrorBoundaryBase */
    {
        protected override Task OnErrorAsync(Exception exception)
        {
            Debugger.Break();
            return Task.CompletedTask; 
        }
    }
}
