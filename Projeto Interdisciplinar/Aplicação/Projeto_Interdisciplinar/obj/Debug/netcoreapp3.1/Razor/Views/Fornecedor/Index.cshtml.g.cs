#pragma checksum "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff70ed12de6499aed83d59d27af629081dbfc7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedor_Index), @"mvc.1.0.view", @"/Views/Fornecedor/Index.cshtml")]
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
#line 1 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\_ViewImports.cshtml"
using Projeto_Interdisciplinar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\_ViewImports.cshtml"
using Projeto_Interdisciplinar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff70ed12de6499aed83d59d27af629081dbfc7d", @"/Views/Fornecedor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678544a5e5799dcd7feb130b242ea914d904ae08", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FornecedorViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/consulta.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ff70ed12de6499aed83d59d27af629081dbfc7d4317", async() => {
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
            WriteLiteral(@"

<br />
<h1>Listagem de Fornecedores</h1>
<br />
<a href=""/Fornecedor/create"" class=""btn btn-secondary"">Novo Registro</a>
<br />
<br />
<br />
<table class=""table table-striped col-md-12"">
    <tr>
        <th>Ações</th>
        <th>Nome</th>
        <th>E-mail</th>
        <th>Telefone</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
     foreach (var fornecedor in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        <a");
            BeginWriteAttribute("href", " href=\"", 505, "\"", 552, 2);
            WriteAttributeValue("", 512, "/Fornecedor/Visualizar?id=", 512, 26, true);
#nullable restore
#line 24 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
WriteAttributeValue("", 538, fornecedor.Id, 538, 14, false);

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
            BeginWriteAttribute("href", " href=\"", 1011, "\"", 1052, 2);
            WriteAttributeValue("", 1018, "/Fornecedor/Edit?id=", 1018, 20, true);
#nullable restore
#line 32 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
WriteAttributeValue("", 1038, fornecedor.Id, 1038, 14, false);

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
            BeginWriteAttribute("href", " href=\"", 1785, "\"", 1847, 4);
            WriteAttributeValue("", 1792, "javascript:apagarRegistro(", 1792, 26, true);
#nullable restore
#line 39 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
WriteAttributeValue("", 1818, fornecedor.Id, 1818, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1832, ",", 1832, 1, true);
            WriteAttributeValue(" ", 1833, "\'Fornecedor\')", 1834, 14, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""23"" height=""23"" fill=""currentColor"" class=""bi bi-x-circle-fill"" viewBox=""0 0 16 16"">
                <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM5.354 4.646a.5.5 0 1 0-.708.708L7.293 8l-2.647 2.646a.5.5 0 0 0 .708.708L8 8.707l2.646 2.647a.5.5 0 0 0 .708-.708L8.707 8l2.647-2.646a.5.5 0 0 0-.708-.708L8 7.293 5.354 4.646z""></path>
            </svg>
            &nbsp;Apagar
        </a>
    </td>
    <td>");
#nullable restore
#line 46 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
   Write(fornecedor.NomeFornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 47 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
   Write(fornecedor.EmailFornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 48 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
   Write(fornecedor.TelefoneFornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n</tr>");
#nullable restore
#line 49 "C:\Users\081210009\Downloads\Projeto_Interdisciplinar\Projeto Interdisciplinar\Aplicação\Projeto_Interdisciplinar\Views\Fornecedor\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<br />\n<br />\n<br />\n\n<script>\n    function apagarRegistro(id, controller) {\n        if (confirm(\'Confirma a exclusão do registro?\'))\n            location.href = controller + \'/Delete?id=\' + id;\n    }\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FornecedorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
