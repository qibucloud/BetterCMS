﻿using System.Runtime.Serialization;

namespace BetterCms.Module.Api.Operations.Pages.Sitemap.Nodes
{
    [DataContract]
    public class GetSitemapNodesResponse :  ListResponseBase<SitemapNodeModel>
    {
    }
}