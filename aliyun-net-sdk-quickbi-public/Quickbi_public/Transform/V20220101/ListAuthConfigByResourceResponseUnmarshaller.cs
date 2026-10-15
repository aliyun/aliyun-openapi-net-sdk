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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListAuthConfigByResourceResponseUnmarshaller
    {
        public static ListAuthConfigByResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAuthConfigByResourceResponse listAuthConfigByResourceResponse = new ListAuthConfigByResourceResponse();

			listAuthConfigByResourceResponse.HttpResponse = _ctx.HttpResponse;
			listAuthConfigByResourceResponse.RequestId = _ctx.StringValue("ListAuthConfigByResource.RequestId");
			listAuthConfigByResourceResponse.Success = _ctx.BooleanValue("ListAuthConfigByResource.Success");

			List<ListAuthConfigByResourceResponse.ListAuthConfigByResource_Data> listAuthConfigByResourceResponse_result = new List<ListAuthConfigByResourceResponse.ListAuthConfigByResource_Data>();
			for (int i = 0; i < _ctx.Length("ListAuthConfigByResource.Result.Length"); i++) {
				ListAuthConfigByResourceResponse.ListAuthConfigByResource_Data data = new ListAuthConfigByResourceResponse.ListAuthConfigByResource_Data();
				data.GmtCreate = _ctx.StringValue("ListAuthConfigByResource.Result["+ i +"].GmtCreate");
				data.Scope = _ctx.IntegerValue("ListAuthConfigByResource.Result["+ i +"].Scope");
				data.ExpireDate = _ctx.StringValue("ListAuthConfigByResource.Result["+ i +"].ExpireDate");
				data.ResourceId = _ctx.StringValue("ListAuthConfigByResource.Result["+ i +"].ResourceId");
				data.AuthorizedId = _ctx.StringValue("ListAuthConfigByResource.Result["+ i +"].AuthorizedId");
				data.AuthorizedName = _ctx.StringValue("ListAuthConfigByResource.Result["+ i +"].AuthorizedName");
				data.ResourceType = _ctx.StringValue("ListAuthConfigByResource.Result["+ i +"].ResourceType");

				List<string> data_authorities = new List<string>();
				for (int j = 0; j < _ctx.Length("ListAuthConfigByResource.Result["+ i +"].Authorities.Length"); j++) {
					data_authorities.Add(_ctx.StringValue("ListAuthConfigByResource.Result["+ i +"].Authorities["+ j +"]"));
				}
				data.Authorities = data_authorities;

				listAuthConfigByResourceResponse_result.Add(data);
			}
			listAuthConfigByResourceResponse.Result = listAuthConfigByResourceResponse_result;
        
			return listAuthConfigByResourceResponse;
        }
    }
}
