#pragma checksum "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\Cool\GetFriends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348341382d28b9c571a2fe3e8eeddbf372597b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cool_GetFriends), @"mvc.1.0.view", @"/Views/Cool/GetFriends.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cool/GetFriends.cshtml", typeof(AspNetCore.Views_Cool_GetFriends))]
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
#line 1 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\_ViewImports.cshtml"
using ContactApp;

#line default
#line hidden
#line 2 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\_ViewImports.cshtml"
using ContactApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348341382d28b9c571a2fe3e8eeddbf372597b5e", @"/Views/Cool/GetFriends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8862c9788ec967dbf67313c45fd8428552e6819", @"/Views/_ViewImports.cshtml")]
    public class Views_Cool_GetFriends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactApp.Models.ContactViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\Cool\GetFriends.cshtml"
  
    ViewData["Title"] = "GetFriends";

#line default
#line hidden
            BeginContext(89, 25, true);
            WriteLiteral("\r\n<h2>GetFriends</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\Cool\GetFriends.cshtml"
   
    var bestFriends = Model.contactsList.Where(x => x.IsCloseFriend == true).ToList();

    foreach(var item in bestFriends)
    {

#line default
#line hidden
            BeginContext(254, 13, true);
            WriteLiteral("        <li> ");
            EndContext();
            BeginContext(268, 14, false);
#line 13 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\Cool\GetFriends.cshtml"
        Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(282, 3, true);
            WriteLiteral(" , ");
            EndContext();
            BeginContext(286, 13, false);
#line 13 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\Cool\GetFriends.cshtml"
                          Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(299, 15, true);
            WriteLiteral(" , Phonenumber:");
            EndContext();
            BeginContext(315, 16, false);
#line 13 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\Cool\GetFriends.cshtml"
                                                       Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(331, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\Riste\source\repos\ContactApp\ContactApp\Views\Cool\GetFriends.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactApp.Models.ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
