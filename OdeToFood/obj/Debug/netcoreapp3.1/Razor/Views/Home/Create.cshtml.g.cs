#pragma checksum "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cdf67f66194d9b04f9f2df9ebe5a48d9d26203b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
#line 1 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
using OdeToFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdf67f66194d9b04f9f2df9ebe5a48d9d26203b", @"/Views/Home/Create.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OdeToFood.Models.Restaurant>
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
            WriteLiteral(" \n");
#nullable restore
#line 4 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
   
     Layout = null;
 

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n <!DOCTYPE html>\n \n <html>\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cdf67f66194d9b04f9f2df9ebe5a48d9d26203b3057", async() => {
                WriteLiteral("\n     <title>Home</title>\n ");
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
            WriteLiteral("\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cdf67f66194d9b04f9f2df9ebe5a48d9d26203b4033", async() => {
                WriteLiteral("\n <div>\n     <h1>Create</h1>\n");
#nullable restore
#line 17 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
          using (Html.BeginForm())
         {

#line default
#line hidden
#nullable disable
                WriteLiteral("             <div>\n                 ");
#nullable restore
#line 20 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
            Write(Html.LabelFor(m=>m.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                 ");
#nullable restore
#line 21 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
            Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                 ");
#nullable restore
#line 22 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
            Write(Html.ValidationMessageFor(m=>m.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n             </div>\n");
                WriteLiteral("             <div>\n                 ");
#nullable restore
#line 26 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
            Write(Html.LabelFor(m=>m.Cuisine));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                 ");
#nullable restore
#line 27 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
            Write(Html.DropDownListFor(m=>m.Cuisine, Html.GetEnumSelectList(typeof(CuisineType))));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                 ");
#nullable restore
#line 28 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"
            Write(Html.ValidationMessageFor(m=>m.Cuisine));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n             </div>\n             <div>\n                 <input type=\"submit\" value=\"Save\">\n             </div>\n");
#nullable restore
#line 33 "/home/pelin/RiderProjects/OdeToFood/OdeToFood/Views/Home/Create.cshtml"

         }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n</div>\n ");
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
            WriteLiteral("\n </html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
