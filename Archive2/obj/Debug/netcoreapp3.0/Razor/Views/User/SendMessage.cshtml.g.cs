#pragma checksum "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SendMessage), @"mvc.1.0.view", @"/Views/User/SendMessage.cshtml")]
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
#line 1 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\_ViewImports.cshtml"
using Archive2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\_ViewImports.cshtml"
using Archive2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d53", @"/Views/User/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e686de7ce6e2b4c2b71065f22d651816412f73e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<modelfor_archive.Models.Messages>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("for", new global::Microsoft.AspNetCore.Html.HtmlString("form1Example13"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "title", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("MessageText"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MessageText", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("message-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
  
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        background-image: url('../sendandview/img/gggg.jpg');
        background-repeat: repeat;
        background-size: cover;
        background-position: center center;
    }

    body {
        height: 100%;
        margin: 0;
        padding: 0;
    }

    .image-container {
        height: 100%;
    }

    .full-screen-image {
        width: 100%;
        height: 100%;
        object-fit: cover;
        position: fixed;
    }

    .form-container {
        height: 480px;
        display: flex;
        align-items: center;
        justify-content: center;
        margin: 0 auto;
        display: flex;
        flex-direction: column;
        align-items: center;
        width: 400px
    }

    .form-group input {
        flex: 1;
    }

    .form-label {
        font-size: 14px;
    }

    .form-control-lg {
        font-size: 14px;
    }
    /* center the send button */
    form button[type=""submit""] {
        display: block;
      ");
            WriteLiteral(@"  margin: 0 auto;
        text-align: center;
    }
</style>
<style>
    /* Styles for the modal */
    .modal {
        display: none;
        position: fixed;
        z-index: 1;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        overflow: auto;
        background-color: rgba(0, 0, 0, 0.4);
    }

    .modal-content {
        background-color: #fefefe;
        margin: 15% auto;
        padding: 20px;
        border: 1px solid #888;
        width: 10%;
    }

    .close {
        color: #aaa;
        float: right;
        font-size: 28px;
        font-weight: bold;
        cursor: pointer;
    }

        .close:hover,
        .close:focus {
            color: black;
            text-decoration: none;
            cursor: pointer;
        }
</style>


<style>
    /* Styles for the modal */
    .modal {
        display: none;
        position: fixed;
        z-index: 1;
        left: 0;
        top: 0;
        width: 100%;
    ");
            WriteLiteral(@"    height: 100%;
        overflow: auto;
        background-color: rgba(0, 0, 0, 0.4);
    }



    .close {
        color: #aaa;
        float: right;
        font-size: 28px;
        font-weight: bold;
        cursor: pointer;
    }

    .selected-options-modal-list {
        padding: 0;
    }

    .selected-option-item {
        display: flex;
        align-items: center;
        justify-content: space-between;
        margin-bottom: 8px;
    }

        .selected-option-item span {
            cursor: pointer;
        }

    .modal-content {
        background-color: #fefefe;
        margin: 15% auto;
        padding: 20px;
        border: 1px solid #888;
        width: 60%; /* Adjust the width as per your preference */
    }

    .remove-option {
        text-align: center;
    }
</style>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.13/css/select2.min.css"" />
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jq");
            WriteLiteral(@"uery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.13/js/select2.min.js""></script>

<header style=""text-align: center"">
    <h1 style=""color:#99561B"">Send Message</h1>
</header>

<section class=""vh-100"">
    <div class=""form-outline mb-4"">
        <div class=""form-container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d5313729", async() => {
                WriteLiteral("\r\n                <div>\r\n                    <!-- Title -->\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d5314125", async() => {
                    WriteLiteral("Title");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 168 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d5315913", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 169 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 169 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                                                                                                                  WriteLiteral(Model.Title);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <span class=\"text-danger\">");
#nullable restore
#line 170 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                                             Write(Html.ValidationMessageFor(model => model.Title, ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    </div>\r\n\r\n                    <br />\r\n\r\n                    <!-- Destinations -->\r\n                    <select style=\"border-radius: 8px;\" id=\"dropdown\" required>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d5319918", async() => {
                    WriteLiteral("Select an option");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 178 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                         foreach (var email in ViewBag.UsersList)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d5321525", async() => {
#nullable restore
#line 180 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                                              Write(email);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 180 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                               WriteLiteral(email);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 181 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>

                    <script>
                        $(document).ready(function () {
                            $('#dropdown').select2();
                        });
                    </script>

                    <!-- The modal -->
                    <div id=""modal"" class=""modal"">
                        <div class=""modal-content"">
                            <span class=""close"">&times;</span>
                            <h2>Selected Options:</h2>
                            <ul id=""selected-options-modal"" class=""selected-options-modal-list""></ul>
                        </div>
                    </div>

                    <button id=""add-option-btn"" type=""button"" style=""border-radius: 10px; background-color: #99561B; border-color: white; color: white;"">Add</button>

                    <button id=""show-options-btn"" style=""width: 140px; height: 40px; border: hidden; color: #99561B; font-weight: bold; border-radius: 10px; "" type=""button"">Selected Users<");
                WriteLiteral(@"/button>
                    <br />
                    <br />
                    <!-- The content of the letter -->
                    <div class=""form-group"">
                        <label class=""form-label"" for=""form1Example23"">The content of the letter</label>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b85ae48c5e1a116a3d5b2417acb8fbcc7ae5d5325166", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 207 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MessageText);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 207 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
AddHtmlAttributeValue("", 5943, Model.MessageText, 5943, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.Name = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <span class=\"text-danger\">");
#nullable restore
#line 208 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                                             Write(Html.ValidationMessageFor(model => model.MessageText, ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                    </div>
                    <!-- Attachments -->
                    <div class=""form-group"">
                        <label class=""form-label"" for=""form1Example23"">Attachments</label>
                        <input id=""attachmentInput"" type=""file"" class=""form-control"" name=""AttFile"" multiple accept="".jpg,.jpeg,.png,.pdf,.doc,.docx"" />
                        <span class=""text-danger"" id=""attachmentValidationMessage"">");
#nullable restore
#line 214 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\SendMessage.cshtml"
                                                                              Write(Html.ValidationMessageFor(model => model.Attachments, ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        <span class=""text-danger"" id=""attachmentSizeValidationMessage""></span>
                    </div>

                    <script>
                        var attachmentInput = document.getElementById('attachmentInput');
                        var attachmentValidationMessage = document.getElementById('attachmentValidationMessage');
                        var attachmentSizeValidationMessage = document.getElementById('attachmentSizeValidationMessage');

                        attachmentInput.addEventListener('change', function () {
                            var files = attachmentInput.files;
                            var allowedExtensions = ['.jpg', '.jpeg', '.png'];
                            var maxSize = 10 * 1024 * 1024; // 10 MB in bytes

                            for (var i = 0; i < files.length; i++) {
                                var file = files[i];
                                var fileExtension = '.' + file.name.split('.').pop().toLowerCase(");
                WriteLiteral(@");

                                if (allowedExtensions.indexOf(fileExtension) === -1) {
                                    attachmentValidationMessage.innerText = 'Only image, PDF, or DOC files are allowed.';
                                    attachmentInput.value = ''; // Reset the file input value
                                    return;
                                }

                                if (file.size > maxSize) {
                                    attachmentSizeValidationMessage.innerText = 'File size should not exceed 10 MB.';
                                    attachmentInput.value = ''; // Reset the file input value
                                    return;
                                }
                            }

                            attachmentValidationMessage.innerText = '';
                            attachmentSizeValidationMessage.innerText = '';
                        });
                    </script>


                    <!-- Hidd");
                WriteLiteral(@"en input to store selected options -->
                    <input id=""selected-options-input"" type=""hidden"" name=""MessageDestinationVisible"" />
                    <br />
                    <br />
                    <!-- Submit button -->
                    <div style=""text-align: center"">
                        <input type=""submit"" class=""btn btn-success mb-4 form-control"" value=""Send""
                               style=""text-align: center;  height: 50px; width: 120px; background-color: #99561B;border-color: white; border-radius: 25px; color: white; padding: 10px 20px;"" />
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</section>

<script>
    const dropdown = document.getElementById('dropdown');
    const addOptionButton = document.getElementById('add-option-btn');
    const showOptionsButton = document.getElementById('show-options-btn');
    const selectedOptionsModal = document.getElementById('selected-options-modal');
    const modal = document.getElementById('modal');
    const closeIcon = document.getElementsByClassName('close')[0];
    const selectedOptionsInput = document.getElementById('selected-options-input');
    const form = document.getElementById('message-form');

    let selectedOptions = [];

    // Event listener for the Add Option button
    addOptionButton.addEventListener('click', () => {
        const selectedOption = dropdown.value;
        if (selectedOption && !selectedOptions.includes(selectedOption)) {
            selectedOptions.push(selectedOption);
            const optionItem = document.createElement('li');
            optionItem.classList.add(");
            WriteLiteral(@"'selected-option-item');
            optionItem.innerHTML = `
                                            <span>${selectedOption}</span>
                                            <span class=""remove-option"" data-option=""${selectedOption}"">&times;</span>
                                        `;
            selectedOptionsModal.appendChild(optionItem);
        }
    });

    // Event listener for the Show Selected Options button
    showOptionsButton.addEventListener('click', () => {
        modal.style.display = 'block';
    });

    // Event listener for the Close icon in the modal
    closeIcon.addEventListener('click', () => {
        modal.style.display = 'none';
    });

    // Event listener for removing selected options
    selectedOptionsModal.addEventListener('click', (event) => {
        if (event.target.className === 'remove-option') {
            const optionToRemove = event.target.dataset.option;
            const optionItem = event.target.parentNode;
            const ");
            WriteLiteral(@"optionIndex = selectedOptions.indexOf(optionToRemove);
            if (optionIndex !== -1) {
                selectedOptions.splice(optionIndex, 1);
                optionItem.parentNode.removeChild(optionItem);
            }
        }
    });

    // Event listener for form submission
    form.addEventListener('submit', (event) => {
        if (selectedOptions.length === 0) {
            event.preventDefault(); // Prevent form submission
            alert('Please select at least one user from the list.');
        } else {
            const existingOptionsInput = document.querySelector('input[name=""MessageDestinationVisible""]');
            if (existingOptionsInput) {
                existingOptionsInput.parentNode.removeChild(existingOptionsInput);
            }

            const optionsInput = document.createElement('input');
            optionsInput.type = 'hidden';
            optionsInput.name = 'MessageDestinationVisible';
            optionsInput.value = selectedOptions.join(',')");
            WriteLiteral(@";
            form.appendChild(optionsInput);
        }
    });

    closeIcon.addEventListener('click', () => {
        modal.style.display = 'none';
    });

    // Event listener for clicks outside the modal
    window.addEventListener('click', (event) => {
        if (event.target === modal) {
            modal.style.display = 'none';
        }
    });

    // Function to filter the dropdown options based on user input
    const filterOptions = (event) => {
        const searchTerm = event.target.value.toLowerCase();
        const options = Array.from(dropdown.options);
        options.forEach((option) => {
            if (option.value.toLowerCase().includes(searchTerm)) {
                option.style.display = '';
            } else {
                option.style.display = 'none';
            }
        });
    };

    // Event listener for the dropdown search input
    dropdown.addEventListener('input', filterOptions);

    selectedOptionsModal.addEventListener('click', (e");
            WriteLiteral(@"vent) => {
        if (event.target.className === 'remove-option') {
            const optionToRemove = event.target.dataset.option;
            const optionItem = event.target.parentNode;
            const optionIndex = selectedOptions.indexOf(optionToRemove);
            if (optionIndex !== -1) {
                selectedOptions.splice(optionIndex, 1);
                optionItem.parentNode.removeChild(optionItem);
            }
        }
    });
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<modelfor_archive.Models.Messages> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
