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
    public class ListOIDCProvidersResponseUnmarshaller
    {
        public static ListOIDCProvidersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOIDCProvidersResponse listOIDCProvidersResponse = new ListOIDCProvidersResponse();

			listOIDCProvidersResponse.HttpResponse = _ctx.HttpResponse;
			listOIDCProvidersResponse.RequestId = _ctx.StringValue("ListOIDCProviders.RequestId");
			listOIDCProvidersResponse.IsTruncated = _ctx.BooleanValue("ListOIDCProviders.IsTruncated");
			listOIDCProvidersResponse.Marker = _ctx.StringValue("ListOIDCProviders.Marker");

			List<ListOIDCProvidersResponse.ListOIDCProviders_OIDCProvider> listOIDCProvidersResponse_oIDCProviders = new List<ListOIDCProvidersResponse.ListOIDCProviders_OIDCProvider>();
			for (int i = 0; i < _ctx.Length("ListOIDCProviders.OIDCProviders.Length"); i++) {
				ListOIDCProvidersResponse.ListOIDCProviders_OIDCProvider oIDCProvider = new ListOIDCProvidersResponse.ListOIDCProviders_OIDCProvider();
				oIDCProvider.UpdateDate = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].UpdateDate");
				oIDCProvider.Description = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].Description");
				oIDCProvider.OIDCProviderName = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].OIDCProviderName");
				oIDCProvider.CreateDate = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].CreateDate");
				oIDCProvider.Arn = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].Arn");
				oIDCProvider.IssuerUrl = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].IssuerUrl");
				oIDCProvider.Fingerprints = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].Fingerprints");
				oIDCProvider.ClientIds = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].ClientIds");
				oIDCProvider.GmtCreate = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].GmtCreate");
				oIDCProvider.GmtModified = _ctx.StringValue("ListOIDCProviders.OIDCProviders["+ i +"].GmtModified");
				oIDCProvider.IssuanceLimitTime = _ctx.LongValue("ListOIDCProviders.OIDCProviders["+ i +"].IssuanceLimitTime");

				listOIDCProvidersResponse_oIDCProviders.Add(oIDCProvider);
			}
			listOIDCProvidersResponse.OIDCProviders = listOIDCProvidersResponse_oIDCProviders;
        
			return listOIDCProvidersResponse;
        }
    }
}
