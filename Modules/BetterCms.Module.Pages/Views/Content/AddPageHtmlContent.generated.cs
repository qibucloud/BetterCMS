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
    
    #line 1 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/AddPageHtmlContent.cshtml")]
    public partial class _Views_Content_AddPageHtmlContent_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public _Views_Content_AddPageHtmlContent_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\n    <a");

WriteLiteral(" class=\"bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                            Write(PagesGlobalization.AddPageContent_RegularContentTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n    <a");

WriteLiteral(" class=\"bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                Write(PagesGlobalization.EditPageContent_AdvancedOptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n</div>\n");

            
            #line 14 "..\..\Views\Content\AddPageHtmlContent.cshtml"
   ViewBag.CanEdit = (ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent); 
            
            #line default
            #line hidden
WriteLiteral("\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Views\Content\AddPageHtmlContent.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 18 "..\..\Views\Content\AddPageHtmlContent.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Content\AddPageHtmlContent.cshtml"
         using (Html.BeginForm<ContentController>(c => c.SavePageHtmlContent(null), FormMethod.Post, new { @id = "bcms-content-form", @class = "bcms-ajax-form" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/EditHtmlContent", Model));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsPageContentId" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ContentId, new { @id = "bcmsContentId" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 24 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ParentPageContentId, new { @id = "bcmsParentPageContentId" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 25 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.PageId));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.RegionId, new { @id = "bcmsContentToRegionId" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n");

            
            #line 29 "..\..\Views\Content\AddPageHtmlContent.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/EditHtmlContentJsCss", Model));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n");

            
            #line 33 "..\..\Views\Content\AddPageHtmlContent.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
