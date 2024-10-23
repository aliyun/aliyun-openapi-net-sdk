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
    public class ListSAMLProvidersResponseUnmarshaller
    {
        public static ListSAMLProvidersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSAMLProvidersResponse listSAMLProvidersResponse = new ListSAMLProvidersResponse();

			listSAMLProvidersResponse.HttpResponse = _ctx.HttpResponse;
			listSAMLProvidersResponse.RequestId = _ctx.StringValue("ListSAMLProviders.RequestId");
			listSAMLProvidersResponse.IsTruncated = _ctx.BooleanValue("ListSAMLProviders.IsTruncated");
			listSAMLProvidersResponse.Marker = _ctx.StringValue("ListSAMLProviders.Marker");

			List<ListSAMLProvidersResponse.ListSAMLProviders_SAMLProvider> listSAMLProvidersResponse_sAMLProviders = new List<ListSAMLProvidersResponse.ListSAMLProviders_SAMLProvider>();
			for (int i = 0; i < _ctx.Length("ListSAMLProviders.SAMLProviders.Length"); i++) {
				ListSAMLProvidersResponse.ListSAMLProviders_SAMLProvider sAMLProvider = new ListSAMLProvidersResponse.ListSAMLProviders_SAMLProvider();
				sAMLProvider.UpdateDate = _ctx.StringValue("ListSAMLProviders.SAMLProviders["+ i +"].UpdateDate");
				sAMLProvider.Description = _ctx.StringValue("ListSAMLProviders.SAMLProviders["+ i +"].Description");
				sAMLProvider.SAMLProviderName = _ctx.StringValue("ListSAMLProviders.SAMLProviders["+ i +"].SAMLProviderName");
				sAMLProvider.CreateDate = _ctx.StringValue("ListSAMLProviders.SAMLProviders["+ i +"].CreateDate");
				sAMLProvider.Arn = _ctx.StringValue("ListSAMLProviders.SAMLProviders["+ i +"].Arn");

				listSAMLProvidersResponse_sAMLProviders.Add(sAMLProvider);
			}
			listSAMLProvidersResponse.SAMLProviders = listSAMLProvidersResponse_sAMLProviders;
        
			return listSAMLProvidersResponse;
        }
    }
}
