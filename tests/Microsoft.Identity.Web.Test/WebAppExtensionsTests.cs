// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web.Test.Common;
using Xunit;

namespace Microsoft.Identity.Web.Test
{
    public class WebAppExtensionsTests
    {
        [Fact]
        public void AddWebAppCallsProtectedWebApi()
        {
            throw new NotImplementedException();
            //Check TokenAcquisitionService
            //CheckHttPContextAccessor
            //ConfidentialClientApplicationOptions and MicrosoftIdentityOptions with default, valid and invalid options
            //OpenIdConnectOptions
            //  scope, responsetype, initial scopes if set, if not set
            //  OnAuthorizationCodeReceived
            //  OnTokenValidated
            //  OnRedirectToIdentityProviderForSignOut
        }

        [Theory]
        [InlineData(TestConstants.AuthorityCommonTenant, TestConstants.AuthorityCommonTenantWithV2)]
        [InlineData(TestConstants.AuthorityOrganizationsUSTenant, TestConstants.AuthorityOrganizationsUSWithV2)]
        [InlineData(TestConstants.AuthorityCommonTenantWithV2, TestConstants.AuthorityCommonTenantWithV2)]
        [InlineData(TestConstants.AuthorityCommonTenantWithV2 + "/", TestConstants.AuthorityCommonTenantWithV2)]
        [InlineData(TestConstants.B2CAuthorityWithV2, TestConstants.B2CAuthorityWithV2)]
        [InlineData(TestConstants.B2CCustomDomainAuthorityWithV2, TestConstants.B2CCustomDomainAuthorityWithV2)]
        [InlineData(TestConstants.B2CAuthority, TestConstants.B2CAuthorityWithV2)]
        [InlineData(TestConstants.B2CCustomDomainAuthority, TestConstants.B2CCustomDomainAuthorityWithV2)]
        public void EnsureAuthorityIsV2_0(string initialAuthority, string expectedAuthority)
        {
            OpenIdConnectOptions options = new OpenIdConnectOptions
            {
                Authority = initialAuthority
            };

            options.Authority = AuthorityHelpers.EnsureAuthorityIsV2(options.Authority);
            Assert.Equal(expectedAuthority, options.Authority);
        }
    }
}
