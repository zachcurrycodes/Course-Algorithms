#pragma checksum "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\AngularTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e0dbf8649891296828f49d66152f6cf0165b47f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Exercises_Views_AngularTest_Index), @"mvc.1.0.view", @"/Areas/Exercises/Views/AngularTest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Exercises/Views/AngularTest/Index.cshtml", typeof(AspNetCore.Areas_Exercises_Views_AngularTest_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0dbf8649891296828f49d66152f6cf0165b47f", @"/Areas/Exercises/Views/AngularTest/Index.cshtml")]
    public class Areas_Exercises_Views_AngularTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AngularTestJScontroller.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\AngularTest\Index.cshtml"
  
    ViewData["Title"] = "Angular Testing";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(98, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<h2>");
            EndContext();
            BeginContext(111, 17, false);
#line 9 "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\AngularTest\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(128, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(140, 19, false);
#line 10 "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\AngularTest\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(159, 1109, true);
            WriteLiteral(@"</h3>

<div>
    <div ng-app=""myApp"" ng-controller=""myAppCtrl"">
        {{ firstName + "" "" + lastName }}
        <br />
        <p>
            <input type=""text"" ng-model=""inputdata"" />
            <br />
            Output: {{inputdata}}
            <br />
            From controller: {{somestring}}
            <br />
            test: {{employeeModel}}<br />
            FirstName: {{employeeModel.firstName}}<br />
            LastName: {{employeeModel.lastName}}
            <br />
            <input type=""submit"" ng-click=""update(inputdata)"" value=""Update"" />
            <br />
            <br />
            <button ng-click=""findIt()"">Find Name</button><br />
            Name: {{user.name}}
            <br />
        <p>
            <div ng-hide=""allusers == ''"">
                <table>
                    <thead><tr><th>Column 1</th></tr></thead>
                    <tr ng-repeat=""user in allusers"">
                        <td>{{user.name}}</td>
                    </tr>
   ");
            WriteLiteral("             </table>\r\n            </div>\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(1268, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08c20454c570482abd9436f74ee43f9a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1323, 176, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var myApp = angular.module(\'myApp\', []);\r\n\r\n    myApp.controller(\'myAppCtrl\', function ($scope, $http) {\r\n        $scope.employeeModel = ");
            EndContext();
            BeginContext(1500, 31, false);
#line 54 "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\AngularTest\Index.cshtml"
                          Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 64, true);
            WriteLiteral(";\r\n        myAngularJStest($scope, $http);\r\n    });\r\n\r\n</script>");
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
