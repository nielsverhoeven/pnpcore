﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class Feature : BaseDataModel<IFeature>, IFeature
    {
        // Property that uniquely identifies this model instance is a guid named Id
        public Guid DefinitionId { get => GetValue<Guid>(); set => SetValue(value); }

        //TODO: To get the displayname, needs to explicitly use this in select clase
        public string DisplayName { get => GetValue<string>(); set => SetValue(value); }

        // Implement they Key property to use the guid ID:
        [KeyProperty("DefinitionId")]
        public override object Key { get => this.DefinitionId; set => this.DefinitionId = Guid.Parse(value.ToString()); }
    }
}
