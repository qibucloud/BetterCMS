﻿using System.Linq;

using BetterCms.Core.DataAccess.DataContext;
using BetterCms.Core.Mvc.Commands;

using BetterCms.Module.Root.Mvc;
using BetterCms.Module.Root.Mvc.Grids.Extensions;
using BetterCms.Module.Root.Mvc.Grids.GridOptions;
using BetterCms.Module.Root.ViewModels.SiteSettings;

using BetterCms.Module.Users.ViewModels.Role;

using NHibernate.Linq;

namespace BetterCms.Module.Users.Commands.Role.GetRoles
{
    public class GetRolesCommand : CommandBase, ICommand<SearchableGridOptions, SearchableGridViewModel<RoleViewModel>>
    {
        public SearchableGridViewModel<RoleViewModel> Execute(SearchableGridOptions request)
        {
            var roles = Repository
               .AsQueryable<Models.Role>()
               .Select(role => new RoleViewModel
                   {
                       Id = role.Id,
                       Version = role.Version,
                       Name = role.DisplayName ?? role.Name,
                       IsSystematic = role.IsSystematic
                   });

            if (!string.IsNullOrWhiteSpace(request.SearchQuery))
            {
                roles = roles.Where(a => a.Name.Contains(request.SearchQuery));
            }

            request.SetDefaultSortingOptions("Name");
            var count = roles.ToRowCountFutureValue();
            roles = roles.AddSortingAndPaging(request);

            return new SearchableGridViewModel<RoleViewModel>(roles.ToFuture().ToList(), request, count.Value);
        }
    }
}