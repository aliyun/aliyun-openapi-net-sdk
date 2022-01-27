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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetServiceProvidersPageResponseUnmarshaller
    {
        public static GetServiceProvidersPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceProvidersPageResponse getServiceProvidersPageResponse = new GetServiceProvidersPageResponse();

			getServiceProvidersPageResponse.HttpResponse = _ctx.HttpResponse;
			getServiceProvidersPageResponse.Code = _ctx.IntegerValue("GetServiceProvidersPage.Code");
			getServiceProvidersPageResponse.Message = _ctx.StringValue("GetServiceProvidersPage.Message");
			getServiceProvidersPageResponse.Success = _ctx.BooleanValue("GetServiceProvidersPage.Success");

			GetServiceProvidersPageResponse.GetServiceProvidersPage_Data data = new GetServiceProvidersPageResponse.GetServiceProvidersPage_Data();
			data.Size = _ctx.IntegerValue("GetServiceProvidersPage.Data.Size");
			data.TotalElements = _ctx.IntegerValue("GetServiceProvidersPage.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("GetServiceProvidersPage.Data.TotalPages");

			List<GetServiceProvidersPageResponse.GetServiceProvidersPage_Data.GetServiceProvidersPage_Provider> data_content = new List<GetServiceProvidersPageResponse.GetServiceProvidersPage_Data.GetServiceProvidersPage_Provider>();
			for (int i = 0; i < _ctx.Length("GetServiceProvidersPage.Data.Content.Length"); i++) {
				GetServiceProvidersPageResponse.GetServiceProvidersPage_Data.GetServiceProvidersPage_Provider provider = new GetServiceProvidersPageResponse.GetServiceProvidersPage_Data.GetServiceProvidersPage_Provider();
				provider.Ip = _ctx.StringValue("GetServiceProvidersPage.Data.Content["+ i +"].Ip");
				provider.Port = _ctx.StringValue("GetServiceProvidersPage.Data.Content["+ i +"].Port");
				provider.SerializeType = _ctx.StringValue("GetServiceProvidersPage.Data.Content["+ i +"].SerializeType");
				provider.Timeout = _ctx.StringValue("GetServiceProvidersPage.Data.Content["+ i +"].Timeout");

				data_content.Add(provider);
			}
			data.Content = data_content;
			getServiceProvidersPageResponse.Data = data;
        
			return getServiceProvidersPageResponse;
        }
    }
}
