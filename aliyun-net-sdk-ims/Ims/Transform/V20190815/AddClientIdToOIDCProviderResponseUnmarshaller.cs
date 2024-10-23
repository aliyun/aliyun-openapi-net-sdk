/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class AddClientIdToOIDCProviderResponseUnmarshaller
    {
        public static AddClientIdToOIDCProviderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddClientIdToOIDCProviderResponse addClientIdToOIDCProviderResponse = new AddClientIdToOIDCProviderResponse();

			addClientIdToOIDCProviderResponse.HttpResponse = _ctx.HttpResponse;
			addClientIdToOIDCProviderResponse.RequestId = _ctx.StringValue("AddClientIdToOIDCProvider.RequestId");

			AddClientIdToOIDCProviderResponse.AddClientIdToOIDCProvider_OIDCProvider oIDCProvider = new AddClientIdToOIDCProviderResponse.AddClientIdToOIDCProvider_OIDCProvider();
			oIDCProvider.UpdateDate = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.UpdateDate");
			oIDCProvider.Description = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.Description");
			oIDCProvider.OIDCProviderName = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.OIDCProviderName");
			oIDCProvider.CreateDate = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.CreateDate");
			oIDCProvider.Arn = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.Arn");
			oIDCProvider.IssuerUrl = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.IssuerUrl");
			oIDCProvider.Fingerprints = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.Fingerprints");
			oIDCProvider.ClientIds = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.ClientIds");
			oIDCProvider.GmtCreate = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.GmtCreate");
			oIDCProvider.GmtModified = _ctx.StringValue("AddClientIdToOIDCProvider.OIDCProvider.GmtModified");
			oIDCProvider.IssuanceLimitTime = _ctx.LongValue("AddClientIdToOIDCProvider.OIDCProvider.IssuanceLimitTime");
			addClientIdToOIDCProviderResponse.OIDCProvider = oIDCProvider;
        
			return addClientIdToOIDCProviderResponse;
        }
    }
}
