// <copyright file="OAuthBearerAuthenticationOptions.cs" company="Microsoft Open Technologies, Inc.">
// Copyright 2011-2013 Microsoft Open Technologies, Inc. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using Microsoft.Owin.Infrastructure;
using Microsoft.Owin.Security.Infrastructure;

namespace Microsoft.Owin.Security.OAuth
{
    public class OAuthBearerAuthenticationOptions : AuthenticationOptions
    {
        public OAuthBearerAuthenticationOptions()
            : base("Bearer")
        {
            SystemClock = new SystemClock();
        }

        public string Realm { get; set; }

        public IOAuthBearerAuthenticationProvider Provider { get; set; }

        public ISecureDataHandler<AuthenticationTicket> AccessTokenHandler { get; set; }

        public IAuthenticationTokenProvider AccessTokenProvider { get; set; }

        public ISystemClock SystemClock { get; set; }
    }
}
