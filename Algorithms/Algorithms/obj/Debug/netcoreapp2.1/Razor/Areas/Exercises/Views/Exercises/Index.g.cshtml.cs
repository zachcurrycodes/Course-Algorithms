#pragma checksum "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\Exercises\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59a656143da52ba8724961a0199093f1fe0bfd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Exercises_Views_Exercises_Index), @"mvc.1.0.view", @"/Areas/Exercises/Views/Exercises/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Exercises/Views/Exercises/Index.cshtml", typeof(AspNetCore.Areas_Exercises_Views_Exercises_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59a656143da52ba8724961a0199093f1fe0bfd4", @"/Areas/Exercises/Views/Exercises/Index.cshtml")]
    public class Areas_Exercises_Views_Exercises_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\Exercises\Index.cshtml"
  
    ViewData["Title"] = "Exercises";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(99, 17, false);
#line 6 "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\Exercises\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(116, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(128, 19, false);
#line 7 "C:\zCode\Course-Algorithms\Algorithms\Algorithms\Areas\Exercises\Views\Exercises\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(147, 336, true);
            WriteLiteral(@"</h3>
<div>
    <div ng-app=""myApp"" ng-controller=""ExcerisesJSCtrl"">


        Dropdown:
        <select>
            <option value=""volvo"">Volvo</option>
            <option value=""saab"">Saab</option>
            <option value=""mercedes"">Mercedes</option>
            <option value=""audi"">Audi</option>
        </select>

");
            EndContext();
            BeginContext(564, 215, true);
            WriteLiteral("\r\n        <select [ngModel]=\"selectedDevice\" (ngModelChange)=\"onChange($event)\" name=\"sel2\">\r\n            <option [value]=\"i\" *ngFor=\"let i of devices\">{{i}}</option>\r\n        </select>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(843, 529, true);
            WriteLiteral(@"
<script>
    var myApp = angular.module('myApp', []);
    var devices;
    var selectedDevice;

    myApp.controller('ExcerisesJSCtrl', function ($event) {
        ExerciseDropDown($event);
    });


    function ExerciseDropDown(newValue) {
        devices = 'one two three'.split(' ');

        selectedDevice = 'two';

        onChange(newValue) {
            console.log(newValue);
            this.selectedDevice = newValue;
            // ... do other stuff here ...
        };
    };



</script>");
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
