#pragma checksum "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aca8d94c31224baa10ae41c3d22a995e2c2ec199"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contato.cshtml", typeof(AspNetCore.Views_Home_Contato))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca8d94c31224baa10ae41c3d22a995e2c2ec199", @"/Views/Home/Contato.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
  
    ViewData["Title"] = "Contato";

#line default
#line hidden
            BeginContext(43, 1271, true);
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    # Outros contatos
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div> 
                </div> 
            </aside>
            ");
            WriteLiteral("<aside class=\"col-sm-6\">\r\n\r\n                <h4 class=\"subtitle-doc\">\r\n                    # Contato\r\n                </h4>\r\n                <div>\r\n\r\n                    <article class=\"card\">\r\n                        <div class=\"card-body p-5\">\r\n");
            EndContext();
#line 41 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_S"] != null)
                            {

#line default
#line hidden
            BeginContext(1406, 63, true);
            WriteLiteral("                                <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(1470, 17, false);
#line 43 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                          Write(ViewData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(1487, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 44 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
#line 45 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_E"] != null)
                            {

#line default
#line hidden
            BeginContext(1616, 62, true);
            WriteLiteral("                                <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(1679, 27, false);
#line 47 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                         Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 48 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
            BeginContext(1743, 612, true);
            WriteLiteral(@"                            <form role=""form"" method=""post"" action=""/Home/ContatoAcao"">
                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" id=""nome"" class=""form-control"" name=""nome""");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2355, "\"", 2369, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", "\r\n                                               required=\"", 2370, "\"", 2429, 0);
            EndWriteAttribute();
            BeginContext(2430, 615, true);
            WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""email"" id=""email""");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 3045, "\"", 3059, 0);
            EndWriteAttribute();
            BeginContext(3060, 1078, true);
            WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%""></textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            </form>
                        </div> 
                    </article> 

                </div>

       ");
            WriteLiteral("     </aside>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
