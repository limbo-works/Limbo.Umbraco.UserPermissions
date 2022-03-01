﻿using System.Collections.Generic;
using Limbo.Umbraco.Access.UserActions.Models;
using Umbraco.Core.Models.Membership;

namespace Limbo.Umbraco.Access.Rules.Allow.Models.Content {
    public class AllowContentLevelAccessRule : AllowContentAccessRule {
        public AllowContentLevelAccessRule(string name, IEnumerable<IUserGroup> userGroups, IEnumerable<ContentUserAction> userActions, int level) : base(name, userGroups, userActions) {
            Level = level;
        }

        public int Level { get; set; }
    }
}
