#pragma checksum "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40557624426c88c6be7cdaf6e0a8ee93c6d9f897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acueducto_pagarConsumo), @"mvc.1.0.view", @"/Views/Acueducto/pagarConsumo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Acueducto/pagarConsumo.cshtml", typeof(AspNetCore.Views_Acueducto_pagarConsumo))]
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
#line 1 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\_ViewImports.cshtml"
using Examen2Progra4;

#line default
#line hidden
#line 2 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\_ViewImports.cshtml"
using Examen2Progra4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40557624426c88c6be7cdaf6e0a8ee93c6d9f897", @"/Views/Acueducto/pagarConsumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbeeb2d8c8a8e572b52e751e00517e1cc3fc4b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Acueducto_pagarConsumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Examen2Progra4.Models.Consumo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
  
    ViewData["Title"] = "pagarConsumo";

#line default
#line hidden
            BeginContext(101, 25, true);
            WriteLiteral("\r\n<h2>pagarConsumo</h2>\r\n");
            EndContext();
#line 8 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
 using (Html.BeginForm("pagarConsumo","Acueducto"))
{

#line default
#line hidden
            BeginContext(182, 31, true);
            WriteLiteral("    <p>\r\n        Find by name: ");
            EndContext();
            BeginContext(214, 22, false);
#line 11 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
                 Write(Html.TextBox("cedula"));

#line default
#line hidden
            EndContext();
            BeginContext(236, 60, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"search\" />\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
}

#line default
#line hidden
            BeginContext(299, 9, true);
            WriteLiteral("<p>\r\n    ");
            EndContext();
            BeginContext(308, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7425f6b6a2842ffaa91b918d07367da", async() => {
                BeginContext(331, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(345, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(438, 40, false);
#line 22 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
           Write(Html.DisplayNameFor(model => model.mesU));

#line default
#line hidden
            EndContext();
            BeginContext(478, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(534, 40, false);
#line 25 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
           Write(Html.DisplayNameFor(model => model.anoU));

#line default
#line hidden
            EndContext();
            BeginContext(574, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(630, 44, false);
#line 28 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
           Write(Html.DisplayNameFor(model => model.consumoU));

#line default
#line hidden
            EndContext();
            BeginContext(674, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(730, 43, false);
#line 31 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
           Write(Html.DisplayNameFor(model => model.cedulaU));

#line default
#line hidden
            EndContext();
            BeginContext(773, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(829, 41, false);
#line 34 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
           Write(Html.DisplayNameFor(model => model.pagoU));

#line default
#line hidden
            EndContext();
            BeginContext(870, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1005, 24, true);
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1030, 39, false);
#line 44 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.DisplayFor(modelItem => item.mesU));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1101, 39, false);
#line 47 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.DisplayFor(modelItem => item.anoU));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1172, 43, false);
#line 50 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.DisplayFor(modelItem => item.consumoU));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1247, 42, false);
#line 53 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.DisplayFor(modelItem => item.cedulaU));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1321, 40, false);
#line 56 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.DisplayFor(modelItem => item.pagoU));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1393, 109, false);
#line 59 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.ActionLink("Pagar", "Pagar","Acueducto", new {mesU=item.mesU,anoU=item.anoU, cedula=item.cedulaU },null));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1515, 71, false);
#line 60 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1599, 69, false);
#line 61 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 20, true);
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
            EndContext();
#line 64 "C:\Users\Jorge\source\repos\Examen2Progra4\Examen2Progra4\Views\Acueducto\pagarConsumo.cshtml"
}

#line default
#line hidden
            BeginContext(1691, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Examen2Progra4.Models.Consumo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
