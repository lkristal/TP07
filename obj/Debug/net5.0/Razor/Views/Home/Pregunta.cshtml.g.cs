#pragma checksum "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2560eda40b23f351ea21aa5d225f4f0116b959f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pregunta), @"mvc.1.0.view", @"/Views/Home/Pregunta.cshtml")]
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
#line 1 "C:\Users\lkris\TP7\Views\_ViewImports.cshtml"
using TP7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lkris\TP7\Views\_ViewImports.cshtml"
using TP7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2560eda40b23f351ea21aa5d225f4f0116b959f7", @"/Views/Home/Pregunta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e2dee2682a229adccc76d28c7514d60cd2d99bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pregunta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-2 col-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12 p-2\"><a");
            BeginWriteAttribute("href", " href=\'", 122, "\'", 160, 1);
#nullable restore
#line 4 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue("", 129, Url.Action("Comodin50","Home"), 129, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\'", 161, "\'", 248, 4);
            WriteAttributeValue("", 169, "btn", 169, 3, true);
#nullable restore
#line 4 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue(" ", 172, ViewBag.Player.Comodin50 ? "btn-success" : "btn-danger", 173, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 231, "btn-lg", 232, 7, true);
            WriteAttributeValue(" ", 238, "btn-block", 239, 10, true);
            EndWriteAttribute();
            WriteLiteral(">50/50</a></div>\r\n            <div class=\"col-md-12 p-2\"><a");
            BeginWriteAttribute("href", " href=\'", 308, "\'", 351, 1);
#nullable restore
#line 5 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue("", 315, Url.Action("ComodinSaltear","Home"), 315, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\'", 352, "\'", 444, 4);
            WriteAttributeValue("", 360, "btn", 360, 3, true);
#nullable restore
#line 5 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue(" ", 363, ViewBag.Player.ComodinSaltear ? "btn-success" : "btn-danger", 364, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 427, "btn-lg", 428, 7, true);
            WriteAttributeValue(" ", 434, "btn-block", 435, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Saltear Pregunta</a></div>\r\n            <div class=\"col-md-12 p-2\">\r\n                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\'", 552, "\'", 648, 4);
            WriteAttributeValue("", 560, "btn", 560, 3, true);
#nullable restore
#line 7 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue(" ", 563, ViewBag.Player.ComodinDobleChance ? "btn-success" : "btn-danger", 564, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 631, "btn-lg", 632, 7, true);
            WriteAttributeValue(" ", 638, "btn-block", 639, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""modal"" data-target=""#ComodinDobleChance"">
                    Doble Chance
                </button>        
            </div>
        </div>
    </div>

    <div class=""col-md-9 col-12"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""jumbotron"">
                    <h1 class=""display-4"">");
#nullable restore
#line 19 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                                     Write(ViewBag.Pregunta.TextoPregunta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                 foreach (Respuesta item in ViewBag.Respuestas)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 p-2\">\r\n");
#nullable restore
#line 25 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                          
                            if (ViewBag.DescartarRespuestas == null || !ViewBag.DescartarRespuestas.Contains(item.OpcionRespuesta))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\'", 1506, "\'", 1589, 1);
#nullable restore
#line 28 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue("", 1513, Url.Action("PreguntaRespondida","Home", new {Opcion1=item.OpcionRespuesta}), 1513, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-lg btn-block\">");
#nullable restore
#line 28 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                                                                                                                                                           Write(item.OpcionRespuesta);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 28 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                                                                                                                                                                                   Write(item.TextoRespuesta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 29 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-1\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 m-1 btn btn-sm btn-dark text-center\">POZO</div>\r\n");
#nullable restore
#line 40 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                 foreach (Pozo item in ViewBag.ListaPozo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\'", 2122, "\'", 2215, 6);
            WriteAttributeValue("", 2130, "col-md-12", 2130, 9, true);
            WriteAttributeValue(" ", 2139, "m-1", 2140, 4, true);
            WriteAttributeValue(" ", 2143, "btn", 2144, 4, true);
            WriteAttributeValue(" ", 2147, "btn-md", 2148, 7, true);
#nullable restore
#line 42 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue(" ", 2154, item.ValorSeguro ? "btn-info" : "btn-warning", 2155, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2203, "text-center", 2204, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 43 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                         if (ViewBag.ImportePozo == item.Importe)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/img/arrow-right-square-fill.svg\">\r\n");
#nullable restore
#line 46 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 47 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                   Write(item.Importe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Button trigger modal -->


<!-- Modal -->
<div class=""modal fade"" id=""ComodinDobleChance"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Comod??n Doble Chance</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2560eda40b23f351ea21aa5d225f4f0116b959f711902", async() => {
                WriteLiteral("\r\n                <div class=\"btn-group-toggle\" data-toggle=\"buttons\">\r\n");
#nullable restore
#line 70 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                         foreach (Respuesta item in ViewBag.Respuestas)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label class=\"btn btn-primary w-100 mt-1\" onclick=\"ChangeColorSelected()\"");
                BeginWriteAttribute("id", " id=\"", 3464, "\"", 3497, 2);
                WriteAttributeValue("", 3469, "Label", 3469, 5, true);
#nullable restore
#line 72 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue("", 3474, item.OpcionRespuesta, 3474, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"checkbox\" autocomplete=\"off\"");
                BeginWriteAttribute("name", " name=\"", 3574, "\"", 3602, 1);
#nullable restore
#line 73 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue("", 3581, item.OpcionRespuesta, 3581, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3603, "\"", 3636, 2);
                WriteAttributeValue("", 3608, "Check", 3608, 5, true);
#nullable restore
#line 73 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
WriteAttributeValue("", 3613, item.OpcionRespuesta, 3613, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \r\n                                    ");
#nullable restore
#line 74 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                               Write(item.OpcionRespuesta);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 74 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                                                       Write(item.TextoRespuesta);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </label>\r\n");
#nullable restore
#line 76 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 68 "C:\Users\lkris\TP7\Views\Home\Pregunta.cshtml"
AddHtmlAttributeValue("", 3133, Url.Action("ResponderDobleChance","Home"), 3133, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-success"">Arriesgar</button>
      </div>
    </div>
  </div>
</div>

<script>
    function ChangeColorSelected()
    {
        if ($(""#CheckA"").prop('checked'))
        {
            $(""#LabelA"").removeClass('btn-primary');
            $(""#LabelA"").addClass('btn-success');
        }
        else
        {
            $(""#LabelA"").removeClass('btn-success');
            $(""#LabelA"").addClass('btn-primary');
        }
        if ($(""#CheckB"").prop('checked'))
        {
            $(""#LabelB"").removeClass('btn-primary');
            $(""#LabelB"").addClass('btn-success');
        }
        else
        {
            $(""#LabelB"").removeClass('btn-success');
            $(""#LabelB"").addClass('btn-primary');
        }


    }
</script>");
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
