#pragma checksum "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa8046e8fc9a476ee6f4143b7d3e7288703f00e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_BuscaAvancada), @"mvc.1.0.view", @"/Views/Nota/BuscaAvancada.cshtml")]
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
#line 1 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa8046e8fc9a476ee6f4143b7d3e7288703f00e8", @"/Views/Nota/BuscaAvancada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_BuscaAvancada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Nota>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExibirNotas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml"
  
    ViewData["Título"] = "Resultado Da Busca";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Resultado da Busca</h1>\r\n\r\n<h3>Total de notas: ");
#nullable restore
#line 8 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml"
               Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<ul class=\"list-group\">\r\n    \r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml"
     foreach (var nota in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            <div class=\"row\">\r\n                <div class=\"col-9\">\r\n                    <div class=\"mb-3\">\r\n                        <h3 class=\"Nota-Titulo Campo-De-Busca\">");
#nullable restore
#line 19 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml"
                                                          Write(nota.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n                        <textarea class=\"form-control\" readonly spellcheck=\"false\" wrap=\"soft\" rows=\"8\" cols=\"33\">");
#nullable restore
#line 22 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml"
                                                                                                             Write(nota.Anotacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                    </div>\r\n\r\n                    \r\n\r\n                </div>\r\n            </div>\r\n        </li>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8046e8fc9a476ee6f4143b7d3e7288703f00e85730", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-repositorioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml"
                                                                         WriteLiteral(nota.RepositorioId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["repositorioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-repositorioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["repositorioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Nota\BuscaAvancada.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Nota>> Html { get; private set; }
    }
}
#pragma warning restore 1591
