#pragma checksum "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da96f1982e26a13b34efbd1477e51874630868e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Produto_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Produto/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Produto_Index))]
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
#line 2 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 3 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
#line 6 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 7 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da96f1982e26a13b34efbd1477e51874630868e1", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294968c08f69b6902196a04e2ad2320ffc5ad6c2", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.PagedList<LojaVirtual.Models.ProdutoAgregador.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
            BeginContext(171, 41, true);
            WriteLiteral("\r\n<h1>Produto</h1>\r\n\r\n<!--Formulario-->\r\n");
            EndContext();
            BeginContext(212, 385, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da96f1982e26a13b34efbd1477e51874630868e16974", async() => {
                BeginContext(231, 114, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"pesquisa\"></label>\r\n        <input type=\"text\" name=\"pesquisa\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 345, "\"", 362, 1);
#line 13 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
WriteAttributeValue("", 353, pesquisa, 353, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(363, 162, true);
                WriteLiteral(" id=\"pesquisa\" class=\"form-control\" placeholder=\"Digite o nome do produto\">\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-info\">Pesquisar</button>\r\n\r\n    ");
                EndContext();
                BeginContext(525, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da96f1982e26a13b34efbd1477e51874630868e18104", async() => {
                    BeginContext(575, 9, true);
                    WriteLiteral("Cadastrar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(588, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(597, 12, true);
            WriteLiteral("\r\n\r\n<br />\r\n");
            EndContext();
#line 21 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
   await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
            BeginContext(681, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(709, 177, true);
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <br />\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(887, 38, false);
#line 30 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.First().Id));

#line default
#line hidden
            EndContext();
            BeginContext(925, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(969, 40, false);
#line 31 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.First().Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1053, 45, false);
#line 32 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.First().Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1142, 41, false);
#line 33 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.First().Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 121, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                 foreach (Produto produto in Model)
                {

#line default
#line hidden
            BeginContext(1376, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1443, 10, false);
#line 41 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                                   Write(produto.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1453, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1489, 12, false);
#line 42 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1537, 19, false);
#line 43 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.CategoriaId);

#line default
#line hidden
            EndContext();
            BeginContext(1556, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1592, 13, false);
#line 44 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(1605, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1670, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da96f1982e26a13b34efbd1477e51874630868e115749", async() => {
                BeginContext(1749, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                        WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1762, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1792, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da96f1982e26a13b34efbd1477e51874630868e118247", async() => {
                BeginContext(1866, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                      WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1877, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 50 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1956, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2015, 115, false);
#line 55 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa })));

#line default
#line hidden
            EndContext();
#line 55 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                                                                                        
}
else
{

#line default
#line hidden
            BeginContext(2144, 46, true);
            WriteLiteral("    <span>Nenhum registro cadastrado!</span>\r\n");
            EndContext();
#line 60 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Areas\Colaborador\Views\Produto\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.PagedList<LojaVirtual.Models.ProdutoAgregador.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
