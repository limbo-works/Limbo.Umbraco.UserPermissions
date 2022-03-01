﻿using System.Collections.Generic;
using Limbo.Umbraco.Access.Rules.Bases.Models;
using Limbo.Umbraco.Access.UserActions.Models;
using Umbraco.Core.Models.Membership;

namespace Limbo.Umbraco.Access.Rules.Limits.Models.Content {
    public class LimitContentAccessRule : ContentAccessRuleBase {
        public LimitContentAccessRule(string name, IEnumerable<IUserGroup> userGroups, IEnumerable<ContentUserAction> userActions) : base(name, userGroups, userActions) {
        }
    }
}
