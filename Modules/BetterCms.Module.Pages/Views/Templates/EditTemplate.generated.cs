﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages.ViewModels.Templates;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Templates\EditTemplate.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Templates/EditTemplate.cshtml")]
    public partial class _Views_Templates_EditTemplate_cshtml : System.Web.Mvc.WebViewPage<TemplateEditViewModel>
    {
        public _Views_Templates_EditTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Templates\EditTemplate.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-tab-header bcms-js-tab-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Templates\EditTemplate.cshtml"
                                                                              Write(PagesGlobalization.EditTemplate_BasicPropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Templates\EditTemplate.cshtml"
                                                                  Write(PagesGlobalization.EditTemplate_RegionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-3\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Templates\EditTemplate.cshtml"
                                                                  Write(PagesGlobalization.EditTemplate_OptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-window-tabbed-options\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 25 "..\..\Views\Templates\EditTemplate.cshtml"
   Write(Html.MessagesBox("bcms-edit-template-messages"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 26 "..\..\Views\Templates\EditTemplate.cshtml"
        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Templates\EditTemplate.cshtml"
         using (Html.BeginForm<TemplatesController>(c => c.RegisterTemplate((TemplateEditViewModel)null), FormMethod.Post, new { @id = "bcms-template-form", @class = "bcms-ajax-form" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-form-block-holder\"");

WriteLiteral(">\r\n                    <div>\r\n                        <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Templates\EditTemplate.cshtml"
                                                        Write(PagesGlobalization.Template_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 33 "..\..\Views\Templates\EditTemplate.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.Template_Title_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 35 "..\..\Views\Templates\EditTemplate.cshtml"
                           Write(Html.TextBoxFor(model => model.Name, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 36 "..\..\Views\Templates\EditTemplate.cshtml"
                           Write(Html.BcmsValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n         " +
"               <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Templates\EditTemplate.cshtml"
                                                        Write(PagesGlobalization.Template_Url_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 42 "..\..\Views\Templates\EditTemplate.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.Template_Url_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 44 "..\..\Views\Templates\EditTemplate.cshtml"
                           Write(Html.TextBoxFor(model => model.Url, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 45 "..\..\Views\Templates\EditTemplate.cshtml"
                           Write(Html.BcmsValidationMessageFor(m => m.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n         " +
"               <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\Templates\EditTemplate.cshtml"
                                                        Write(PagesGlobalization.TemplatePreviewImageUrl_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 51 "..\..\Views\Templates\EditTemplate.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.TemplatePreviewImageUrl_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 53 "..\..\Views\Templates\EditTemplate.cshtml"
                           Write(Html.TextBoxFor(model => model.PreviewImageUrl, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 54 "..\..\Views\Templates\EditTemplate.cshtml"
                           Write(Html.BcmsValidationMessageFor(m => m.PreviewImageUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n\r\n                    <div>\r\n                        <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Templates\EditTemplate.cshtml"
                                                        Write(PagesGlobalization.TemplatePreviewImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 62 "..\..\Views\Templates\EditTemplate.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.TemplateImagePreview_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"bcms-preview-module-image\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" id=\"bcms-template-preview-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3695), Tuple.Create("\"", 3723)
            
            #line 65 "..\..\Views\Templates\EditTemplate.cshtml"
, Tuple.Create(Tuple.Create("", 3701), Tuple.Create<System.Object, System.Int32>(Model.PreviewImageUrl
            
            #line default
            #line hidden
, 3701), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                                </div>\r\n                            </div>\r\n" +
"                        </div>\r\n                    </div>\r\n                </di" +
"v>\r\n            </div>\r\n");

            
            #line 72 "..\..\Views\Templates\EditTemplate.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 74 "..\..\Views\Templates\EditTemplate.cshtml"
           Write(Html.Partial("Partial/EditTemplateRegions"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 76 "..\..\Views\Templates\EditTemplate.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-3\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 78 "..\..\Views\Templates\EditTemplate.cshtml"
           Write(Html.Partial(PagesConstants.OptionsGridTemplate, new EditableGridViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 80 "..\..\Views\Templates\EditTemplate.cshtml"

            
            
            #line default
            #line hidden
            
            #line 81 "..\..\Views\Templates\EditTemplate.cshtml"
       Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 81 "..\..\Views\Templates\EditTemplate.cshtml"
                                              
            
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\Templates\EditTemplate.cshtml"
       Write(Html.HiddenFor(model => model.Version));

            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\Templates\EditTemplate.cshtml"
                                                   
            
            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\Templates\EditTemplate.cshtml"
       Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\Templates\EditTemplate.cshtml"
                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
