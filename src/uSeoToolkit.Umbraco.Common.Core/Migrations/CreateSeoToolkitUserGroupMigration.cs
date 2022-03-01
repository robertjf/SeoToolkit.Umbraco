﻿using Umbraco.Cms.Core.Models.Membership;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Infrastructure.Migrations;
using uSeoToolkit.Umbraco.Common.Core.Sections;

namespace uSeoToolkit.Umbraco.Common.Core.Migrations
{
    public class CreateSeoToolkitUserGroupMigration : MigrationBase
    {
        private const string UserGroupAlias = "uSeoToolkit";

        private readonly IShortStringHelper _shortStringHelper;
        private readonly IUserService _userService;

        public CreateSeoToolkitUserGroupMigration(
            IMigrationContext context,
            IShortStringHelper shortStringHelper,
            IUserService userService)
           : base(context)
        {
            _shortStringHelper = shortStringHelper;
            _userService = userService;
        }

        protected override void Migrate()
        {
            if (_userService.GetUserGroupByAlias(UserGroupAlias) != null)
                return;

            var userGroup = new UserGroup(_shortStringHelper)
            {
                Alias = UserGroupAlias,
                Name = "SEO Toolkit",
                Icon = "icon-globe-alt",
            };

            userGroup.AddAllowedSection(USeoToolkitSection.SectionAlias);

            _userService.Save(userGroup);
        }
    }
}