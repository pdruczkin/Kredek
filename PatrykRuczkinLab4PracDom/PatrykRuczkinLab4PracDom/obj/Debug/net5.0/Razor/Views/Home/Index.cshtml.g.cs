#pragma checksum "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb2a3828be391bcb1a481334669039af59975887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\_ViewImports.cshtml"
using PatrykRuczkinLab4PracDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\_ViewImports.cshtml"
using PatrykRuczkinLab4PracDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb2a3828be391bcb1a481334669039af59975887", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b5ace07aac0032db3554a714d3aeb7fd5f360a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PatrykRuczkinLab4PracDom.Models.RecipeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ksi????ka Patryka";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ksi????ka Patryka</h1>\r\n");
#nullable restore
#line 8 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
  
    if (ViewBag.username != null && ViewBag.username != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Witaj ");
#nullable restore
#line 11 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
             Write(ViewBag.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 12 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3></h3>\r\n\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb2a3828be391bcb1a481334669039af599758874832", async() => {
                WriteLiteral("Dodaj");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Nazwa\r\n            </th>\r\n            <th>\r\n                Cena\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Szczeg????y", "RecipeById", new { id = item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\developer\.NET\Kredek\patryk_ruczkin_cpc2021-2\PatrykRuczkinLab4PracDom\PatrykRuczkinLab4PracDom\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PatrykRuczkinLab4PracDom.Models.RecipeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
