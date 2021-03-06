﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenGraphMetaDataProjection.cs" company="Devbridge Group LLC">
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
using System.Web.Mvc;

using BetterCms.Core.DataContracts;
using BetterCms.Core.Modules.Projections;

namespace BetterCms.Module.OpenGraphIntegration.Projections
{
    public class OpenGraphMetaDataProjection : HtmlElementProjection
    {
        private readonly string property;
        private readonly string content;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGraphMetaDataProjection" /> class.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <param name="content">The content.</param>
        public OpenGraphMetaDataProjection(string property, string content)
            : base("meta", true)
        {
            this.property = string.Format("{0}{1}", OpenGrachIntegrationModuleConstants.OpenGraphPropertyPrefix, property);
            this.content = content;
        }

        /// <summary>
        /// Called before render methods sends element to response output.
        /// </summary>
        /// <param name="controlRenderer">The html control renderer.</param>
        /// <param name="page">The page.</param>
        /// <param name="html">The html helper.</param>
        protected override void OnPreRender(HtmlControlRenderer controlRenderer, IPage page, HtmlHelper html)
        {
            controlRenderer.Attributes["property"] = property;
            controlRenderer.Attributes["content"] = content;
        }

        protected bool Equals(OpenGraphMetaDataProjection other)
        {
            return string.Equals(property, other.property) && string.Equals(content, other.content);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((OpenGraphMetaDataProjection)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((property != null ? property.GetHashCode() : 0) * 397) ^ (content != null ? content.GetHashCode() : 0);
            }
        }
    }
}