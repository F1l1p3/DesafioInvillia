#pragma checksum "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9311a053b4a7bf3180587bc2e6179a172ffc310"
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
#line 1 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\_ViewImports.cshtml"
using DesafioDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\_ViewImports.cshtml"
using DesafioDotNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9311a053b4a7bf3180587bc2e6179a172ffc310", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ec2847f99c773a94e7324b1723982a2af8f790", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Bem vindo</h1>
    <p> Sistema de emprestimo de jogos </p>
</div>

<div style=""text-align: center;"">
    <div style=""display: inline-block;"" class=""card"">
        <div class=""card-body"">
            <h5 class=""card-title"">Jogos cadastrados</h5>
            <p class=""card-text"">");
#nullable restore
#line 14 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\Home\Index.cshtml"
                            Write(ViewBag.JogosCadastrados);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <a href=""/Jogo/Index"" class=""btn btn-primary"">Ver</a>
        </div>
    </div>

    <div style=""display: inline-block;"" class=""card"">
        <div class=""card-body"">
            <h5 class=""card-title"">Jogos Emprestados</h5>
            <p class=""card-text"">");
#nullable restore
#line 22 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\Home\Index.cshtml"
                            Write(ViewBag.JogosEmprestados);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <a href=""/JogoEmprestado/Index"" class=""btn btn-primary"">Ver</a>
        </div>
    </div>

    <div style=""display: inline-block;"" class=""card"">
        <div class=""card-body"">
            <h5 class=""card-title"">Amigos cadastrados</h5>
            <p class=""card-text"">");
#nullable restore
#line 30 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\Home\Index.cshtml"
                            Write(ViewBag.AmigosCadastrados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"/Amigo/Index\" class=\"btn btn-primary\">Ver</a>\r\n        </div>\r\n    </div>\r\n</div>");
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
