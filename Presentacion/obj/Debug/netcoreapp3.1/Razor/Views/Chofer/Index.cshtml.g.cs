#pragma checksum "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e877461a21f052b9bf4840d25e2a975a097a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chofer_Index), @"mvc.1.0.view", @"/Views/Chofer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\_ViewImports.cshtml"
using Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\_ViewImports.cshtml"
using Presentacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e877461a21f052b9bf4840d25e2a975a097a68", @"/Views/Chofer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf57c469e1b8e05140e56e7f20f29b558100cc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Chofer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Presentacion.Models.ChoferModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearChofer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chofer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e877461a21f052b9bf4840d25e2a975a097a684025", async() => {
                WriteLiteral("Crear nuevo chofer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdChofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre1Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre2Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido1Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido2Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TelefonoChofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdChofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre1Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre2Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido1Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido2Chofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TelefonoChofer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.ActionLink("Modificar", "EditaChofer", "Chofer", new { item.IdChofer }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 59 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Eliminar", "Chofer", new { item.IdChofer }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\SSequeira\Source\Repos\FrontEndProyecto2\Presentacion\Views\Chofer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Presentacion.Models.ChoferModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
