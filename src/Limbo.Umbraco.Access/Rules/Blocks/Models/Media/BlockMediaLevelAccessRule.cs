﻿using System.Collections.Generic;
using Limbo.Umbraco.Access.UserActions.Models;
using Umbraco.Core.Models.Membership;

namespace Limbo.Umbraco.Access.Rules.Blocks.Models.Media {
    public class BlockMediaLevelAccessRule : BlockMediaAccessRule {
        public BlockMediaLevelAccessRule(string name, IEnumerable<IUserGroup> userGroups, IEnumerable<MediaUserAction> userActions, int level) : base(name, userGroups, userActions) {
            Level = level;
        }

        public int Level { get; set; }
    }
}
