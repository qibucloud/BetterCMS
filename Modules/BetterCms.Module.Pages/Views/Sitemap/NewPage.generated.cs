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
    
    #line 1 "..\..\Views\Sitemap\NewPage.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Sitemap\NewPage.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Sitemap\NewPage.cshtml"
    using BetterCms.Module.Pages.ViewModels.Sitemap;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Sitemap\NewPage.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Sitemap\NewPage.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Sitemap/NewPage.cshtml")]
    public partial class _Views_Sitemap_NewPage_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Sitemap_NewPage_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"bcms-sitemaps-arrow-left\"");

WriteLiteral(" data-bind=\"css: { \'bcms-sitemaps-arrow-inactive\': !slider.canSlideLeft() }, clic" +
"k: slider.slideLeft, visible: slider.showSliders\"");

WriteLiteral("></a>\r\n        <!-- ko foreach: tabs -->\r\n        <a");

WriteLiteral(" class=\"bcms-tab-item\"");

WriteLiteral(" data-bind=\"text: newPageViewModel.sitemap.title(), css: { \'bcms-active\': isActiv" +
"e }, click: activate, attr: { id: tabId }, visible: isVisible\"");

WriteLiteral("></a>\r\n        <!-- /ko -->\r\n        <a");

WriteLiteral(" class=\"bcms-sitemaps-arrow-right\"");

WriteLiteral(" data-bind=\"css: { \'bcms-sitemaps-arrow-inactive\': !slider.canSlideRight() }, cli" +
"ck: slider.slideRight, visible: slider.showSliders\"");

WriteLiteral("></a>\r\n    </div>\n</div>\n\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(" id=\"bcms-sitemap-addnewpage\"");

WriteLiteral(" data-bind=\"with: activeNewPageViewModel\"");

WriteLiteral(">\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Views\Sitemap\NewPage.cshtml"
Write(Html.SiteSettingsMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(" style=\"display: block; height: 100%;\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"bcms-columns-container\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"bcms-sitemap-filter-holder\"");

WriteLiteral(" data-bind=\"with: sitemap\"");

WriteLiteral(">\n                <div");

WriteLiteral(" class=\"bcms-language-bar\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: showLanguages, with: language\"");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\"bcms-filter-text bcms-table-middle-box\"");

WriteLiteral(">Edit sitemap in language:</div>\n                    <div");

WriteLiteral(" class=\"bcms-table-middle-box\"");

WriteLiteral(">\n                        <select");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" data-bind=\"options: languages, optionsText: \'value\', optionsValue: \'key\', value:" +
" languageId\"");

WriteLiteral("></select>\n                    </div>\n                </div>\n\n                <di" +
"v");

WriteLiteral(" class=\"bcms-expand-link-holder\"");

WriteLiteral(" ");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: expandAll\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Sitemap\NewPage.cshtml"
                                                                          Write(NavigationGlobalization.Sitemap_Button_ExpandAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: collapseAll\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\Sitemap\NewPage.cshtml"
                                                                            Write(NavigationGlobalization.Sitemap_Button_CollapseAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                </div>\n            </div>\n            <div");

WriteLiteral(" class=\"bcms-leftcol bcms-leftcol-helper\"");

WriteLiteral(">\n                <div");

WriteLiteral(" class=\"bcms-sidebar-info-block\"");

WriteLiteral(">\n                    <!-- ko if: !linkIsDropped() -->\n                    <div>");

            
            #line 36 "..\..\Views\Sitemap\NewPage.cshtml"
                    Write(NavigationGlobalization.Sitemap_AddNewPageDialog_PageNodeHeader);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <!-- ko with: pageLink -->\n                    <div");

WriteLiteral(" data-bind=\"draggable: $parentContext\"");

WriteLiteral(">\n                        <div");

WriteLiteral(" class=\"bcms-dropable-page-box\"");

WriteLiteral(" style=\"position: relative; z-index: 0;\"");

WriteLiteral(" data-bind=\"css: { \'bcms-placement-node-drag\': isBeingDragged() }\"");

WriteLiteral(">\n                            <div");

WriteLiteral(" class=\"bcms-drop-button\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Sitemap\NewPage.cshtml"
                                                     Write(NavigationGlobalization.Sitemap_AddNewPageDialog_DragButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Sitemap\NewPage.cshtml"
                                                        Write(NavigationGlobalization.Sitemap_AddNewPageDialog_PageName);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                            <div");

WriteLiteral(" class=\"bcms-dropable-text\"");

WriteLiteral(" data-bind=\"text: title()\"");

WriteLiteral("></div>\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Sitemap\NewPage.cshtml"
                                                        Write(NavigationGlobalization.Sitemap_AddNewPageDialog_PageUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                            <div");

WriteLiteral(" class=\"bcms-dropable-text\"");

WriteLiteral(" data-bind=\"text: url()\"");

WriteLiteral("></div>\n                        </div>\n                    </div>\n               " +
"     <div");

WriteLiteral(" class=\"bcms-placement-dropzone\"");

WriteLiteral(" data-bind=\"visible: isBeingDragged()\"");

WriteLiteral("></div>\n                    <!-- /ko -->\n                    <div>");

            
            #line 49 "..\..\Views\Sitemap\NewPage.cshtml"
                    Write(NavigationGlobalization.Sitemap_AddNewPageDialog_PageNodeFooter);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <!-- /ko -->\n                    <!-- ko if: linkIsDro" +
"pped() -->\n                    <div>");

            
            #line 52 "..\..\Views\Sitemap\NewPage.cshtml"
                    Write(NavigationGlobalization.Sitemap_AddNewPageDialog_UndoMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <!-- /ko -->\n                    <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" data-bind=\"click: skipClicked, visible: !linkIsDropped()\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Sitemap\NewPage.cshtml"
                                                                                                    Write(NavigationGlobalization.Sitemap_AddNewPageDialog_SkipButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                </div>\n            </div>\n            <div");

WriteLiteral(" class=\"bcms-rightcol\"");

WriteLiteral(">\n                <div");

WriteLiteral(" class=\"bcms-placement-holder bcms-sitemap-newpage\"");

WriteLiteral(">\n                    ");

WriteLiteral("\n");

            
            #line 60 "..\..\Views\Sitemap\NewPage.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Sitemap\NewPage.cshtml"
                     using (Html.BeginForm<SitemapController>(f => f.SaveSitemap(null), FormMethod.Post, new { @class = "bcms-sitemap-form bcms-ajax-form" }))
                    {
                        
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Sitemap\NewPage.cshtml"
                   Write(Html.Partial("Partial/Sitemap", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Sitemap\NewPage.cshtml"
                                                                                    
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");

            
            #line 70 "..\..\Views\Sitemap\NewPage.cshtml"
Write(Html.Partial("Partial/SitemapTemplate", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
