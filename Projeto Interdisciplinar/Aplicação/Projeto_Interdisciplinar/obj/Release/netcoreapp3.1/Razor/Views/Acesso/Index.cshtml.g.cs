#pragma checksum "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325a6db89c403fe12b24241fdbe644e5b7cda039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acesso_Index), @"mvc.1.0.view", @"/Views/Acesso/Index.cshtml")]
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
#line 1 "D:\Outros\Projeto_Interdisciplinar\Views\_ViewImports.cshtml"
using Projeto_Interdisciplinar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Outros\Projeto_Interdisciplinar\Views\_ViewImports.cshtml"
using Projeto_Interdisciplinar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325a6db89c403fe12b24241fdbe644e5b7cda039", @"/Views/Acesso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678544a5e5799dcd7feb130b242ea914d904ae08", @"/Views/_ViewImports.cshtml")]
    public class Views_Acesso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UsuarioViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/consulta.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Acesso/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
   ViewData["Title"] = "Controle de Acesso"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "325a6db89c403fe12b24241fdbe644e5b7cda0394332", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "325a6db89c403fe12b24241fdbe644e5b7cda0395444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<br />
<h1>Controle de Acesso</h1>
<br />
<a href=""/Acesso/create"" class=""btn btn-secondary"">Novo Registro</a>
<br />
<br />
<br />
<table class=""table table-striped col-md-12"">
    <tr>
        <th>Ações</th>
        <th>Imagem</th>
        <th>Usuário</th>
        <th>Perfil</th>
    </tr>
");
#nullable restore
#line 21 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
     foreach (UsuarioViewModel u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 566, "\"", 600, 2);
            WriteAttributeValue("", 573, "/Acesso/Visualizar?id=", 573, 22, true);
#nullable restore
#line 25 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
WriteAttributeValue("", 595, u.Id, 595, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""23"" height=""23"" fill=""currentColor"" class=""bi bi-eye-fill"" viewBox=""0 0 16 16"">
                        <path d=""M10.5 8a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0z"" />
                        <path d=""M0 8s3-5.5 8-5.5S16 8 16 8s-3 5.5-8 5.5S0 8 0 8zm8 3.5a3.5 3.5 0 1 0 0-7 3.5 3.5 0 0 0 0 7z"" />
                    </svg>
                    &nbsp;Visualizar
                </a>
                &nbsp;&nbsp;&nbsp;
                <a");
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1151, 2);
            WriteAttributeValue("", 1130, "/Acesso/Edit?id=", 1130, 16, true);
#nullable restore
#line 33 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
WriteAttributeValue("", 1146, u.Id, 1146, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""23"" height=""23"" fill=""currentColor"" class=""bi bi-pencil-fill"" viewBox=""0 0 16 16"">
                        <path d=""M12.854.146a.5.5 0 0 0-.707 0L10.5 1.793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z""></path>
                    </svg>
                    &nbsp;Editar
                </a>
                &nbsp;&nbsp;&nbsp;
                <a");
            BeginWriteAttribute("href", " href=\"", 1940, "\"", 1978, 3);
            WriteAttributeValue("", 1947, "javascript:apagarUsuario(", 1947, 25, true);
#nullable restore
#line 40 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
WriteAttributeValue("", 1972, u.Id, 1972, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1977, ")", 1977, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""23"" height=""23"" fill=""currentColor"" class=""bi bi-x-circle-fill"" viewBox=""0 0 16 16"">
                        <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM5.354 4.646a.5.5 0 1 0-.708.708L7.293 8l-2.647 2.646a.5.5 0 0 0 .708.708L8 8.707l2.646 2.647a.5.5 0 0 0 .708-.708L8.707 8l2.647-2.646a.5.5 0 0 0-.708-.708L8 7.293 5.354 4.646z""></path>
                    </svg>
                    &nbsp;Apagar
                </a>
            </td>
            <td><img ");
            WriteLiteral(" alt=\"Foto Usuário\" style=\"width: 20px; height: 20px\"></td>\n            <td>");
#nullable restore
#line 48 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
           Write(u.LoginUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 49 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
           Write(u.Perfil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 51 "D:\Outros\Projeto_Interdisciplinar\Views\Acesso\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<br />\n<br />\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UsuarioViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
