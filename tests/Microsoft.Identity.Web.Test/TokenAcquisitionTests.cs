// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Microsoft.Identity.Web.Test
{
    public class TokenAcquisitionTests
    {


        public TokenAcquisitionTests()
        {

        }

        [Fact]
        public void GetAccessTokenForAppAsync()
        {

        }

        /*
         * One valid scope
         * multiple valid scopes
         * valid and invalid scopes
         * valid scope name but in invalid format
         * multiple invalid scopes
         * empty list
         * only scopes requested by msal?
         */


        [Fact]
        public void AddAccountToCacheFromAuthorizationCodeAsync()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetAccessTokenOnBehalfOfUserAsync()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetAccessTokenForUserAsync()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void RemoveAccountAsync()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void ReplyForbiddenWithWwwAuthenticateHeader()
        {
            throw new NotImplementedException();
        }
    }
}
