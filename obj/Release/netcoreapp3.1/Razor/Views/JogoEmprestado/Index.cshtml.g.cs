#pragma checksum "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e5e33263d06ab75831b603b945e640ea23fd79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JogoEmprestado_Index), @"mvc.1.0.view", @"/Views/JogoEmprestado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e5e33263d06ab75831b603b945e640ea23fd79", @"/Views/JogoEmprestado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ec2847f99c773a94e7324b1723982a2af8f790", @"/Views/_ViewImports.cshtml")]
    public class Views_JogoEmprestado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JogoEmprestado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Lista de Jogos Emprestados</h1>

<a href=""/JogoEmprestado/Save"" class=""btn btn-primary""  style=""margin-top: 25px;"">Adicionar Emprestimo</a>

<table class=""table"" style=""margin-top: 50px;"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Data Emprestimo</th>
            <th>Jogo</th>
            <th>Amigo</th>
            <th>Devolvido?</th>
            <th> - </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
         foreach (var item in Model)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
           Write(item.IdJogoEmprestado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
           Write(item.DataEmprestimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
           Write(item.IdJogo.NomeJogo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
           Write(item.IdAmigo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
           Write(item.Devolvido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 815, "\"", 865, 2);
            WriteAttributeValue("", 822, "/JogoEmprestado/Edit/", 822, 21, true);
#nullable restore
#line 27 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
WriteAttributeValue("", 843, item.IdJogoEmprestado, 843, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 920, "\"", 972, 2);
            WriteAttributeValue("", 927, "/JogoEmprestado/Delete/", 927, 23, true);
#nullable restore
#line 28 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
WriteAttributeValue("", 950, item.IdJogoEmprestado, 950, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> |\r\n                <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1085, 2);
            WriteAttributeValue("", 1037, "/JogoEmprestado/Devolucao/", 1037, 26, true);
#nullable restore
#line 29 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
WriteAttributeValue("", 1063, item.IdJogoEmprestado, 1063, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Devolução</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\filipe.soares.lopes\Documents\pessoal\Invillia\DesafioDotNet\Views\JogoEmprestado\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JogoEmprestado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
