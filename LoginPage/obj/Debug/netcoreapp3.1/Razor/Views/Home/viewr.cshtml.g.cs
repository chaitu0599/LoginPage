#pragma checksum "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "557686c8498ec8a3a9c8e0b10253175fecc4cbef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_viewr), @"mvc.1.0.view", @"/Views/Home/viewr.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557686c8498ec8a3a9c8e0b10253175fecc4cbef", @"/Views/Home/viewr.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb4a92aafd7518594c36387f2d98063768a88b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_viewr : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
  
    ViewData["Title"] = "Display Data";
    string[] TableHeaders = new string[] {
                    "Name",
                    "Date of Birth",
                    "Father's Name",
                    "Mother's Name",
                    "Address",
                    "Salary",
                    "Fresher",
                    "Role",
                    "Notes"};
    

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557686c8498ec8a3a9c8e0b10253175fecc4cbef6653", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <style>
        body {
            background-image: url(../../images/bg.jpg);
        }
        * {
            box-sizing: border-box;
        }

        /* Set a style for all buttons */
        button {
            background-color: #04AA6D;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            opacity: 0.9;
        }

            button:hover {
                opacity: 1;
            }

        /* Float cancel and delete buttons and add an equal width */
        .cancelbtn, .deletebtn {
            float: left;
            width: 50%;
        }

        /* Add a color to the cancel button */
        .cancelbtn {
            background-color: #ccc;
            color: black;
        }

        /* Add a color to the delete button */
        .deletebtn {
            background-");
                WriteLiteral(@"color: #f44336;
        }

        /* Add padding and center-align text to the container */
        .container {
            padding: 16px;
            text-align: center;
        }

        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0);
            background-color: rgba(0,0,0,0.4);
            padding-top: 50px;
        }

        /* Modal Content/Box */
        .modal-content {
            background-color: #fefefe;
            margin: 5% auto 15% auto; /* 5% from the top, 15% from the bottom and centered */
            border: 1px solid #888;
            width: 30%; /* Could be more or less, depending on screen size ");
                WriteLiteral(@"*/
        }

        /* Style the horizontal ruler */
        hr {
            border: 1px solid #f1f1f1;
            margin-bottom: 25px;
        }

        /* The Modal Close Button (x) */
        .close {
            position: absolute;
            right: 35px;
            top: 15px;
            font-size: 40px;
            font-weight: bold;
            color: #f1f1f1;
        }

            .close:hover,
            .close:focus {
                color: #f44336;
                cursor: pointer;
            }

        /* Clear floats */
        .clearfix::after {
            content: """";
            clear: both;
            display: table;
        }
    </style>
    <script lang=""javascript"">
        function del(p) {
            $(document).ready(function () {
                $(""#id01"").show();
            });
            document.getElementById('mydltbtn').onclick = function () {
                window.location.href = ""Delete\\"" + p;
            };
        }
   ");
                WriteLiteral("     function edit(p) {\r\n            window.location.href = \"Edit\\\\\" + p;\r\n        }\r\n    </script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557686c8498ec8a3a9c8e0b10253175fecc4cbef10918", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\r\n            <div class=\"container\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557686c8498ec8a3a9c8e0b10253175fecc4cbef11374", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557686c8498ec8a3a9c8e0b10253175fecc4cbef13693", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557686c8498ec8a3a9c8e0b10253175fecc4cbef15532", async() => {
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
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item ml-auto\">\r\n\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557686c8498ec8a3a9c8e0b10253175fecc4cbef17470", async() => {
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
    <div class=""row"">
        <div class=""col-md-6"">
            <h1 style=""font-family:'Baskerville Old Face'; float:right;"">All Employees</h1>
        </div>
        <div class=""col-md-6"">
            <input class=""form-control"" style=""width:50%; float:right;"" id=""myInput"" type=""text"" placeholder=""Search.."">
        </div>
    </div>
    <a style=""float:left;"" href=""/Home/ExporttoExcel"">Export</a>
    <div id=""id01"" class=""modal"">
        <span onclick=""document.getElementById('id01').style.display='none'"" class=""close"" title=""Close Modal"">×</span>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557686c8498ec8a3a9c8e0b10253175fecc4cbef19939", async() => {
                    WriteLiteral(@"
            <div class=""container"">
                <h1>Delete Employee</h1>
                <p>Are you sure you want to delete this employee?</p>

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
                WriteLiteral("\r\n    </div>\r\n    <div class=\"table\">\r\n        <table class=\"table table-bordered table-hover\">\r\n            <thead>\r\n                <tr>\r\n");
#nullable restore
#line 184 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                      
                        foreach (var head in TableHeaders)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 188 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                           Write(head);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 190 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                        }


                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody id=\"myTable\">\r\n");
#nullable restore
#line 197 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                  
                    if (Model != null)
                    {
                        foreach (var Data in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 203 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 204 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.dob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 205 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.father);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 206 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.mother);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 207 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 208 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.salary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 209 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.fresher);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 210 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.role);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 211 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                               Write(Data.notes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td><button class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 7511, "\"", 7535, 3);
                WriteAttributeValue("", 7521, "edit(", 7521, 5, true);
#nullable restore
#line 212 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
WriteAttributeValue("", 7526, Data.id, 7526, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7534, ")", 7534, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</button></td>\r\n                                <td><button class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 7623, "\"", 7646, 3);
                WriteAttributeValue("", 7633, "del(", 7633, 4, true);
#nullable restore
#line 213 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
WriteAttributeValue("", 7637, Data.id, 7637, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7645, ")", 7645, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</button></td>\r\n                            </tr>\r\n");
#nullable restore
#line 215 "C:\Users\chait\Desktop\LoginPage\LoginPage\Views\Home\viewr.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n\r\n");
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
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $(""#myInput"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#myTable tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>
");
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
