using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BlazorComponents.Pages
{
    public class Repeater<TItem> : ComponentBase
    {
        [Parameter, Required] public IEnumerable<TItem> Data { get; set; }
        [Parameter, Required] public RenderFragment<RepeaterItem<TItem>> ItemTemplate { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            int itemIndex = 0;
            foreach (TItem item in Data)
            {
                builder.AddContent(0, ItemTemplate(new RepeaterItem<TItem> { Index = itemIndex++, Value = item }));
            }
        }
    }

    public class RepeaterItem<TItem>
    {
        public int Index { get; init; }
        public TItem Value { get; init; }
    }
}
