#pragma checksum "C:\Users\User\Desktop\RepositorioPessoal\WebApplication1\Views\Shared\_ModalExcluirNotaScript.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed25e1387127604715415e380c2b6b010c717a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalExcluirNotaScript), @"mvc.1.0.view", @"/Views/Shared/_ModalExcluirNotaScript.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed25e1387127604715415e380c2b6b010c717a1", @"/Views/Shared/_ModalExcluirNotaScript.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ModalExcluirNotaScript : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script>
    function ConfirmarExclusao(notaId) {
        $("".modal"").modal();
        $("".btnExcluir"").on('click', function () {
            $.ajax({
                url: '/Nota/ExcluirNota',
                method: 'POST',
                data: { notaId: notaId },
                success: function (data) {
                    location.reload(true);
                }
            });
        });
        $("".btnFechar"").on('click', function () {
            notaId = null;
            $("".modal"").modal('hide');
        })
    }

    function ConfirmarExclusaoComRedirect(notaId, repositorioId) {
        $("".modal"").modal();
        $("".btnExcluir"").on('click', function () {
            $.ajax({
                url: '/Nota/ExcluirNota',
                method: 'POST',
                data: { notaId: notaId },
                success: function (data) {
                    location.replace(`/Nota/ExibirNotas?repositorioId=${repositorioId}`);
                }
            });

      ");
            WriteLiteral("     \r\n        });\r\n        $(\".btnFechar\").on(\'click\', function () {\r\n            notaId = null;\r\n            $(\".modal\").modal(\'hide\');\r\n        })\r\n    }\r\n</script>\r\n");
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
