﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Content
{
    using System;
    using System.Collections.Generic;
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
    
    #line 1 "..\..\Views\Content\ChildContentOptions.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\ChildContentOptions.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\ChildContentOptions.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Content\ChildContentOptions.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/ChildContentOptions.cshtml")]
    public partial class ChildContentOptions : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Option.ContentOptionValuesViewModel>
    {
        public ChildContentOptions()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Views\Content\ChildContentOptions.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Views\Content\ChildContentOptions.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Content\ChildContentOptions.cshtml"
         if (Model != null)
        {
            using (Html.BeginForm<ContentController>(c => c.ChildContentOptions(null, null, null), FormMethod.Post,
                new
                {
                    @id = "bcms-options-form",
                    @class = "bcms-ajax-form",
                    data_readonly = Model.IsReadOnly.ToString().ToLower()
                }))
            {
                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Content\ChildContentOptions.cshtml"
           Write(Html.Partial(PagesConstants.OptionValuesGridTemplate));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Content\ChildContentOptions.cshtml"
                                                                      

                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Content\ChildContentOptions.cshtml"
           Write(Html.HiddenFor(model => model.OptionValuesContainerId));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Content\ChildContentOptions.cshtml"
                                                                       
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591