#pragma checksum "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4b5413e4248f0b56a11b52d5ee3851e1a62c5f179a9390a090fc2fda85641ecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4b5413e4248f0b56a11b52d5ee3851e1a62c5f179a9390a090fc2fda85641ecd", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c06ff15e14ca265ac02581f11c2f1df170b78788319fee00ba39468599e4f228", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
       IEnumerable<SalesWebMVC.Models.SalesRecord>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>");
            Write(
#nullable restore
#line 7 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
     ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5413e4248f0b56a11b52d5ee3851e1a62c5f179a9390a090fc2fda85641ecd5616", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 483, "", 510, 1);
                WriteAttributeValue("", 490, 
#nullable restore
#line 15 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                                                                                  ViewData["minDate"]

#line default
#line hidden
#nullable disable
                , 490, 20, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 714, "", 741, 1);
                WriteAttributeValue("", 721, 
#nullable restore
#line 19 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                                                                                  ViewData["maxDate"]

#line default
#line hidden
#nullable disable
                , 721, 20, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            Write(
#nullable restore
#line 28 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                                               Model.Sum(obj => obj.Amount).ToString("F2")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 35 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                         Html.DisplayNameFor(model => model.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 38 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                         Html.DisplayNameFor(model => model.Date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 41 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                         Html.DisplayNameFor(model => model.Seller)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 44 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                         Html.DisplayNameFor(model => model.Seller.Department)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 47 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                         Html.DisplayNameFor(model => model.Amount)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 50 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                         Html.DisplayNameFor(model => model.Status)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 59 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                             Html.DisplayFor(modelItem => item.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 62 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                             Html.DisplayFor(modelItem => item.Date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 65 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                             Html.DisplayFor(modelItem => item.Seller.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 68 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                             Html.DisplayFor(modelItem => item.Seller.Department.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 71 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                             Html.DisplayFor(modelItem => item.Amount)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 74 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                             Html.DisplayFor(modelItem => item.Status)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\celio.porto\Documents\Plano de treinamento estagiarios\davi.giovani\Curso C#\Seção 18 - Projeto ASP .NET Core MVC\SalesWebMVC\SalesWebMVC\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>Data[\"Title\"]</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMVC.Models.SalesRecord>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
