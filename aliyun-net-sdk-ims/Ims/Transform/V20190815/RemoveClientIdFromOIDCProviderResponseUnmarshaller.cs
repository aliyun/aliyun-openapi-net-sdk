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
    public class RemoveClientIdFromOIDCProviderResponseUnmarshaller
    {
        public static RemoveClientIdFromOIDCProviderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveClientIdFromOIDCProviderResponse removeClientIdFromOIDCProviderResponse = new RemoveClientIdFromOIDCProviderResponse();

			removeClientIdFromOIDCProviderResponse.HttpResponse = _ctx.HttpResponse;
			removeClientIdFromOIDCProviderResponse.RequestId = _ctx.StringValue("RemoveClientIdFromOIDCProvider.RequestId");

			RemoveClientIdFromOIDCProviderResponse.RemoveClientIdFromOIDCProvider_OIDCProvider oIDCProvider = new RemoveClientIdFromOIDCProviderResponse.RemoveClientIdFromOIDCProvider_OIDCProvider();
			oIDCProvider.UpdateDate = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.UpdateDate");
			oIDCProvider.Description = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.Description");
			oIDCProvider.OIDCProviderName = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.OIDCProviderName");
			oIDCProvider.CreateDate = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.CreateDate");
			oIDCProvider.Arn = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.Arn");
			oIDCProvider.IssuerUrl = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.IssuerUrl");
			oIDCProvider.Fingerprints = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.Fingerprints");
			oIDCProvider.ClientIds = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.ClientIds");
			oIDCProvider.GmtCreate = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.GmtCreate");
			oIDCProvider.GmtModified = _ctx.StringValue("RemoveClientIdFromOIDCProvider.OIDCProvider.GmtModified");
			oIDCProvider.IssuanceLimitTime = _ctx.LongValue("RemoveClientIdFromOIDCProvider.OIDCProvider.IssuanceLimitTime");
			removeClientIdFromOIDCProviderResponse.OIDCProvider = oIDCProvider;
        
			return removeClientIdFromOIDCProviderResponse;
        }
    }
}
