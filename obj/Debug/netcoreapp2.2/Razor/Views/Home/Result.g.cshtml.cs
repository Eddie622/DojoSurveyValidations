#pragma checksum "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurveyValidations\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e58f94a80acd2f5d6493f4c3bbae25ba99f600f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurveyValidations\Views\_ViewImports.cshtml"
using DojoSurveyValidations;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurveyValidations\Views\_ViewImports.cshtml"
using DojoSurveyValidations.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e58f94a80acd2f5d6493f4c3bbae25ba99f600f", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a083a02d55da6e5f7c5dfa6b3e462f77f713a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoSurveyValidations.Models.Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 32, true);
            WriteLiteral("\r\n<h1>Results!</h1>\r\n\r\n<p>Name: ");
            EndContext();
            BeginContext(77, 10, false);
#line 5 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurveyValidations\Views\Home\Result.cshtml"
    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(87, 24, true);
            WriteLiteral("</p>\r\n<p>Dojo Location: ");
            EndContext();
            BeginContext(112, 14, false);
#line 6 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurveyValidations\Views\Home\Result.cshtml"
             Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(126, 28, true);
            WriteLiteral("</p>\r\n<p>Favorite Language: ");
            EndContext();
            BeginContext(155, 14, false);
#line 7 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurveyValidations\Views\Home\Result.cshtml"
                 Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(169, 18, true);
            WriteLiteral("</p>\r\n<p>Comment: ");
            EndContext();
            BeginContext(188, 13, false);
#line 8 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurveyValidations\Views\Home\Result.cshtml"
       Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(201, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoSurveyValidations.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
