#pragma checksum "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51ee298ec0ec58cdd9c07282a6390a59338b8a4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ee298ec0ec58cdd9c07282a6390a59338b8a4a", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51ee298ec0ec58cdd9c07282a6390a59338b8a4a2726", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51ee298ec0ec58cdd9c07282a6390a59338b8a4a3749", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n\r\n    <h3>ID : ");
#nullable restore
#line 11 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
        Write(ViewBag.Cart.cart_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>Name : ");
#nullable restore
#line 12 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
          Write(ViewBag.Cart.cart_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>Type : ");
#nullable restore
#line 13 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
          Write(ViewBag.Cart.shopping_type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>Items : ");
#nullable restore
#line 14 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
           Write(ViewBag.Cart.no_of_items);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
                WriteLiteral("\r\n<ul>\r\n    <h3>Type of items:</h3>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
        if (ViewBag.Cart.type_of_items != null) {

            foreach (var cart in ViewBag.Cart.type_of_items) {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <li>");
#nullable restore
#line 24 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
       Write(cart);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li> ");
#nullable restore
#line 24 "C:\Users\107012\source\repos\Asp.NetCoreEmpty2\Asp.NetCoreEmpty2\Views\Home\Details.cshtml"
                       }
                   
         
         } 

#line default
#line hidden
#nullable disable
                WriteLiteral("</ul>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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