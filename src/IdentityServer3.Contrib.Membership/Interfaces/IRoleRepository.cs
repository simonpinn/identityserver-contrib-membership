﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
namespace IdentityServer3.Contrib.Membership.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRoleRepository
    {
        Task<IEnumerable<string>> GetRoles(string username);
    }
}
