#pragma checksum "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7df86528b698a70c74d4fa4fce602c8160bf2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Viewtask), @"mvc.1.0.view", @"/Views/Employee/Viewtask.cshtml")]
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
#line 1 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\_ViewImports.cshtml"
using LoginPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\_ViewImports.cshtml"
using LoginPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7df86528b698a70c74d4fa4fce602c8160bf2c", @"/Views/Employee/Viewtask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb4a92aafd7518594c36387f2d98063768a88b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Viewtask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "empop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
  
    ViewData["Title"] = "Display Data";
    string[] TableHeaders = new string[] {
                    "Task Name",
                    "Start Date",
                    "End Date",
                    "Task Duration",
                    "Team Name",
                    "Task Summary",
                    "Task Details",
                    "Risk Details",
                    "Risk Solution" };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7df86528b698a70c74d4fa4fce602c8160bf2c6716", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        body {
            background-image: url(../../images/bg1.jpg);
        }
        * {
            box-sizing: border-box;
        }
        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            padding-top: 100px; /* Location of the box */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
        }

        button {
            background-color: #04AA6D;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor:");
                WriteLiteral(@" pointer;
            opacity: 0.9;
        }

        /* Modal Content */
        .modal-content {
            margin: auto;
            padding: 20px;
            border: 1px solid #888;
            width: 30%;
            font-size: large;
        }

        .close {
            position: absolute;
            right: 35px;
            top: 15px;
            font-size: 40px;
            font-weight: bold;
            color: #f1f1f1;
        }

        .close2 {
            color: #aaaaaa;
            float: right;
            font-size: 30px;
            font-weight: bold;
            padding-left: 300px;
        }

        /* The Close Button */
        .close1 {
            color: #aaaaaa;
            float: right;
            font-size: 30px;
            font-weight: bold;
            padding-left: 300px;
        }

        hr {
            border: 1px solid #f1f1f1;
            margin-bottom: 25px;
        }

        .deletebtn {
            background-color:");
                WriteLiteral(@" #f44336;
        }

        .cancelbtn {
            background-color: lawngreen;
            color: black;
        }

        .cancelbtn, .deletebtn {
            float: left;
            width: 50%;
        }

        button:hover {
            opacity: 1;
        }

        .close1:hover,
        .close1:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }

        .close:hover,
        .close:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }

        .close2:hover,
        .close2:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }

        .container {
            padding: 16px;
            text-align: center;
        }

        .clearfix::after {
            content: """";
            clear: both;
            display: table;
        }
    </style>
    <script lang=""javascript"">
        functi");
                WriteLiteral(@"on view(p) {
            location.href = ""Details/"" + p;
        }
        function edit(p) {
            location.href = ""Edit/"" + p;
        }
        function del(p) {
            $(document).ready(function () {
                $(""#id01"").show();
            });
            document.getElementById('mydltbtn').onclick = function () {
                window.location.href = ""Delete\\"" + p;
            };
        }
        function create() {
            location.href = ""Createtask"";
        }
    </script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7df86528b698a70c74d4fa4fce602c8160bf2c11407", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\r\n            <div class=\"container\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7df86528b698a70c74d4fa4fce602c8160bf2c11863", async() => {
                    WriteLiteral("Employee Management System");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7df86528b698a70c74d4fa4fce602c8160bf2c14182", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7df86528b698a70c74d4fa4fce602c8160bf2c16021", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item ml-auto\">\r\n\r\n                        </li>\r\n\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7df86528b698a70c74d4fa4fce602c8160bf2c17963", async() => {
                    WriteLiteral("Logout");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <div id=""id01"" class=""modal"">
        <span onclick=""document.getElementById('id01').style.display='none'"" class=""close"" title=""Close Modal"">×</span>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7df86528b698a70c74d4fa4fce602c8160bf2c19998", async() => {
                    WriteLiteral(@"
            <div class=""container"">
                <h1>Delete Task</h1>
                <p>Are you sure you want to delete this task?</p>

                <div class=""clearfix"">
                    <button type=""button"" onclick=""document.getElementById('id01').style.display='none'"" class=""btn btn-success btn-lg"">Cancel</button>
                    <button type=""button"" id=""mydltbtn"" class=""btn btn-danger btn-lg"">Delete</button>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
    <button style=""float:left;"" class=""btn btn-info"" onclick=""create()"">Create New Task</button>
    <a href=""/Employee/ExporttoExcel"" style=""float:right;"">Export</a>
    <h1 style=""font-family:'Baskerville Old Face';"">Your Tasks</h1>
    <div id=""myModal"" class=""modal"">
        <div class=""modal-content"">
            <span class=""close1"">&times;</span>
            <p>Task has been added.</p>
        </div>
    </div>
    <div id=""myModal1"" class=""modal"">
        <div class=""modal-content"">
            <span class=""close2"">&times;</span>
            <p>Task has been updated.</p>
        </div>
    </div>
    <div class=""table"">
        <table class=""table table-bordered table-hover"">
            <thead>
                <tr>
");
#nullable restore
#line 220 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                      
                        foreach (var head in TableHeaders)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 224 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                           Write(head);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 226 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                        }


                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 233 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                  
                    if (Model != null)
                    {
                        foreach (var Data in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 239 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Taskname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 240 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Startdate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 241 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Enddate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 242 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Duration);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 243 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Teamname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 244 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Summary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 245 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Taskdetails);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 246 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Riskdetails);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 247 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                               Write(Data.Risksolution);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td><button class=\"btn btn-outline-secondary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 8214, "\"", 8238, 3);
                WriteAttributeValue("", 8224, "view(", 8224, 5, true);
#nullable restore
#line 248 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
WriteAttributeValue("", 8229, Data.id, 8229, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8237, ")", 8237, 1, true);
                EndWriteAttribute();
                WriteLiteral(">View</button></td>\r\n                                <td><button class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 8327, "\"", 8351, 3);
                WriteAttributeValue("", 8337, "edit(", 8337, 5, true);
#nullable restore
#line 249 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
WriteAttributeValue("", 8342, Data.id, 8342, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8350, ")", 8350, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</button></td>\r\n                                <td><button class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 8439, "\"", 8462, 3);
                WriteAttributeValue("", 8449, "del(", 8449, 4, true);
#nullable restore
#line 250 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
WriteAttributeValue("", 8453, Data.id, 8453, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8461, ")", 8461, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</button></td>\r\n                            </tr>\r\n");
#nullable restore
#line 252 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 259 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
  
    if (TempData["msgcr"] != null)
    {
        if (TempData["msgcr"].ToString() == "Yes")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <script>
                var modal = document.getElementById(""myModal"");
                var span = document.getElementsByClassName(""close1"")[0];
                modal.style.display = ""block"";
                span.onclick = function () {
                    modal.style.display = ""none"";
                }
            </script>
");
#nullable restore
#line 272 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
        }
        if (TempData["msgcr"].ToString() == "No")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n                alert(\"Team addition failed\")\r\n            </script>\r\n");
#nullable restore
#line 278 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            var modal = document.getElementById(\"myModal\");\r\n            modal.style.display = \"none\";\r\n        </script>\r\n");
#nullable restore
#line 286 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
    }
    TempData["msgcr"] = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 289 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
  
    if (TempData["msged"] != null)
    {
        if (TempData["msged"].ToString() == "Yes")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <script>
                var modal = document.getElementById(""myModal1"");
                var span = document.getElementsByClassName(""close2"")[0];
                modal.style.display = ""block"";
                span.onclick = function () {
                    modal.style.display = ""none"";
                }
            </script>
");
#nullable restore
#line 302 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
        }
        if (TempData["msged"].ToString() == "No")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n                alert(\"Team addition failed\")\r\n            </script>\r\n");
#nullable restore
#line 308 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            var modal = document.getElementById(\"myModal1\");\r\n            modal.style.display = \"none\";\r\n        </script>\r\n");
#nullable restore
#line 316 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Employee\Viewtask.cshtml"
    }
    TempData["msged"] = null;

#line default
#line hidden
#nullable disable
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
