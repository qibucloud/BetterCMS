﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogJsModuleIncludeDescriptor.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

using BetterCms.Core.Modules;
using BetterCms.Core.Modules.Projections;
using BetterCms.Module.Blog.Content.Resources;
using BetterCms.Module.Blog.Controllers;
using BetterCms.Module.Pages.Content.Resources;
using BetterCms.Module.Root.Content.Resources;

namespace BetterCms.Module.Blog.Registration
{
    /// <summary>
    /// bcms.blog.js module descriptor.
    /// </summary>
    public class BlogJsModuleIncludeDescriptor : JsIncludeDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogJsModuleIncludeDescriptor" /> class.
        /// </summary>
        /// <param name="module">The container module.</param>
        public BlogJsModuleIncludeDescriptor(CmsModuleDescriptor module)
            : base(module, "bcms.blog")
        {
            Links = new IActionProjection[]
                        {
                            new JavaScriptModuleLinkTo<BlogController>(this, "loadSiteSettingsBlogsUrl", c => c.Index(null)),
                            new JavaScriptModuleLinkTo<BlogController>(this, "loadCreateNewPostDialogUrl", c => c.CreateBlogPost("{0}")),
                            new JavaScriptModuleLinkTo<BlogController>(this, "loadEditPostDialogUrl", c => c.EditBlogPost("{0}")),
                            new JavaScriptModuleLinkTo<AuthorController>(this, "loadAuthorsTemplateUrl", c => c.ListTemplate()),
                            new JavaScriptModuleLinkTo<AuthorController>(this, "loadAuthorsUrl", c => c.AuthorsList(null)),
                            new JavaScriptModuleLinkTo<AuthorController>(this, "deleteAuthorsUrl", c => c.DeleteAuthor(null, null)),
                            new JavaScriptModuleLinkTo<AuthorController>(this, "saveAuthorsUrl", c => c.SaveAuthor(null)),
                            new JavaScriptModuleLinkTo<OptionController>(this, "saveBlogPostSettingUrl", c => c.SaveSetting(null)),
                            new JavaScriptModuleLinkTo<OptionController>(this, "loadBlogPostSettingsUrl", c => c.Settings()),
                            new JavaScriptModuleLinkTo<OptionController>(this, "saveDefaultTemplateUrl", c => c.SaveDefaultTemplate("{0}", "{1}")),
                            new JavaScriptModuleLinkTo<BlogController>(this, "convertStringToSlugUrl", c => c.ConvertStringToSlug("{0}", "{1}", "{2}", "{3}", "{4}", null)),
                            new JavaScriptModuleLinkTo<BlogMLController>(this, "uploadBlogPostsImportFileUrl", c => c.UploadImportFile(null, null)),
                            new JavaScriptModuleLinkTo<BlogMLController>(this, "startImportUrl", c => c.StartImport(null)),
                            new JavaScriptModuleLinkTo<BlogMLController>(this, "deleteUploadedFileUrl", c => c.DeleteUploadedFile("{0}")),
                            new JavaScriptModuleLinkTo<BlogMLController>(this, "exportBlogPostsUrl", c => c.Export(null)),
                            new JavaScriptModuleLinkTo<OptionController>(this, "loadTemplatesUrl", c => c.Templates())
                        };

            Globalization = new IActionProjection[]
                        {
                            new JavaScriptModuleGlobalization(this, "createNewPostDialogTitle", () => BlogGlobalization.CreateNewPost_Dialog_Title),
                            new JavaScriptModuleGlobalization(this, "editPostDialogTitle", () => BlogGlobalization.EditPost_Dialog_Title),
                            new JavaScriptModuleGlobalization(this, "deleteBlogDialogTitle", () => BlogGlobalization.DeletePost_Dialog_Title),
                            new JavaScriptModuleGlobalization(this, "deleteAuthorDialogTitle", () => BlogGlobalization.DeleteAuthor_Confirmation_Message),
                            new JavaScriptModuleGlobalization(this, "blogPostsTabTitle", () => BlogGlobalization.SiteSettings_Blogs_PostsTab_Title),
                            new JavaScriptModuleGlobalization(this, "authorsTabTitle", () => BlogGlobalization.SiteSettings_Blogs_AuthorsTab_Title),
                            new JavaScriptModuleGlobalization(this, "settingsTabTitle", () => BlogGlobalization.SiteSettings_Blogs_SettingsTab_Title),
                            new JavaScriptModuleGlobalization(this, "datePickerTooltipTitle", () => BlogGlobalization.Date_Picker_Tooltip_Title),
                            new JavaScriptModuleGlobalization(this, "importBlogPostsTitle", () => BlogGlobalization.ImportBlogPosts_Dialog_Title),
                            new JavaScriptModuleGlobalization(this, "pleaseSelectAFile", () => BlogGlobalization.ImportBlogPosts_PleaseSelectAFile_message),
                            new JavaScriptModuleGlobalization(this, "uploadButtonTitle", () => BlogGlobalization.ImportBlogPosts_UploadButton_Title),
                            new JavaScriptModuleGlobalization(this, "importButtonTitle", () => BlogGlobalization.ImportBlogPosts_ImportButton_Title),
                            new JavaScriptModuleGlobalization(this, "closeButtonTitle", () => RootGlobalization.Button_Close),
                            new JavaScriptModuleGlobalization(this, "noBlogPostsSelectedToImport", () => BlogGlobalization.ImportBlogPosts_NoBlogPostSelected_Message),
                            new JavaScriptModuleGlobalization(this, "editModeHtmlTitle", () => RootGlobalization.ContentEditMode_Html),
                            new JavaScriptModuleGlobalization(this, "editModeMarkdownTitle", () => RootGlobalization.ContentEditMode_Markdown),
                            new JavaScriptModuleGlobalization(this, "templatesTabTitle", () => BlogGlobalization.SiteSettings_Blogs_TemplatesTab_Title),
                            new JavaScriptModuleGlobalization(this, "created", () => PagesGlobalization.Page_Created), 
                            new JavaScriptModuleGlobalization(this, "lastEdited", () => PagesGlobalization.Page_LastEdited), 
                            new JavaScriptModuleGlobalization(this, "lastEditedBy", () => PagesGlobalization.Page_LastEditedBy), 
                        };
        }
    }
}