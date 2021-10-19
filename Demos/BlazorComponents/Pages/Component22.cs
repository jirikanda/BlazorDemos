using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorComponents.Pages
{
    [Route("/component22/{Username}/{Identifikator:int?}")]
    public class Component22 : ComponentBase
    {
        [Parameter] public string Username { get; set; }
        [Parameter] public int? Identifikator { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(100, "h1");
            builder.AddContent(101, "No razor file");
            builder.CloseElement();

            builder.OpenElement(200, "p");
            builder.AddAttribute(201, "class", "username");
            builder.AddContent(202, "Username: ");
            builder.AddContent(203, Username);
            builder.CloseElement();

            builder.OpenElement(300, "p");
            builder.AddAttribute(301, "class", "identifikator");
            builder.AddContent(302, "Identifikator: ");
            builder.AddContent(303, Identifikator);
            builder.CloseElement();

            //builder.OpenRegion(400);
            //base.BuildRenderTree() - discussion!
            //builder.CloseRegion();
        }
    }
}