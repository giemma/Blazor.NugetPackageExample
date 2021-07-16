using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.MyNugetPackage
{
    public partial class Component1
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        protected async void ClickMe()
        {
            await JSRuntime.InvokeVoidAsync("showAlert", "Hi!");
        }
    }
}
