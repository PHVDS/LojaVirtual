#pragma checksum "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a25b64664ac94a731342d24620c9e9adb39ba52f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu__Submenu), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/_Submenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/_Submenu.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu__Submenu))]
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
#line 3 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#line 8 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 9 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 10 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25b64664ac94a731342d24620c9e9adb39ba52f", @"/Views/Shared/Components/Menu/_Submenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8a29b42ba5db06f7db8a4e3f9711dddd8cfcee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu__Submenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListagemCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
  
    var TodasCategorias = (List<Categoria>)ViewData["TodasCategorias"];
    var CategoriaPai = (Categoria)ViewData["CategoriaPai"];

    var CategoriasFilho = TodasCategorias.Where(a => a.CategoriaPaiId == CategoriaPai.Id);

#line default
#line hidden
            BeginContext(237, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
 if (CategoriasFilho.Count() > 0)
{

#line default
#line hidden
            BeginContext(277, 43, true);
            WriteLiteral("    <li class=\"dropdown-submenu\">\r\n        ");
            EndContext();
            BeginContext(320, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25b64664ac94a731342d24620c9e9adb39ba52f6468", async() => {
                BeginContext(452, 17, false);
#line 12 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                                                                      Write(CategoriaPai.Nome);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                                           WriteLiteral(CategoriaPai.Slug);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(473, 38, true);
            WriteLiteral("\r\n        <ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 14 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
             foreach (var categoriaF in CategoriasFilho)
            {
                

#line default
#line hidden
#line 16 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                 if (TodasCategorias.Where(a => a.CategoriaPaiId == categoriaF.Id).Count() > 0)
                {
                    ViewData.Remove("CategoriaPai");
                    //Apresentação do Submenu Recursivo
                    

#line default
#line hidden
            BeginContext(832, 142, false);
#line 20 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
               Write(await Html.PartialAsync("~/Views/Shared/Components/Menu/_Submenu.cshtml", new ViewDataDictionary(ViewData) { { "CategoriaPai", categoriaF } }));

#line default
#line hidden
            EndContext();
#line 20 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                                                                                                   ;
                }
                else
                {

#line default
#line hidden
            BeginContext(1037, 46, true);
            WriteLiteral("                    <li class=\"dropdown-item\">");
            EndContext();
            BeginContext(1083, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25b64664ac94a731342d24620c9e9adb39ba52f11188", async() => {
                BeginContext(1177, 15, false);
#line 24 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                                                                      Write(categoriaF.Nome);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                                             WriteLiteral(categoriaF.Slug);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1196, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 25 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                }

#line default
#line hidden
#line 25 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1237, 26, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n");
            EndContext();
#line 29 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1275, 30, true);
            WriteLiteral("    <li class=\"dropdown-item\">");
            EndContext();
            BeginContext(1305, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25b64664ac94a731342d24620c9e9adb39ba52f14926", async() => {
                BeginContext(1401, 17, false);
#line 32 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                                                        Write(CategoriaPai.Nome);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                             WriteLiteral(CategoriaPai.Slug);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1422, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 33 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\LojaVirtual\src\Views\Shared\Components\Menu\_Submenu.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
