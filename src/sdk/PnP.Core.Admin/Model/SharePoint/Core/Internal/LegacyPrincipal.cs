﻿using System.Collections.Generic;

namespace PnP.Core.Admin.Model.SharePoint
{
    internal class LegacyPrincipal : ILegacyPrincipal
    {
        public string AppIdentifier { get; set; }

        public string ServerRelativeUrl { get; set; }

        public string AbsoluteUrl { get; set; }

        public string Title { get; set; }
        
        public bool AllowAppOnly { get; set; }
        
        public IEnumerable<ILegacySiteCollectionPermission> SiteCollectionScopedPermissions { get; set; }
        
        public IEnumerable<ILegacyTenantPermission> TenantScopedPermissions { get; set; }
    }
}
