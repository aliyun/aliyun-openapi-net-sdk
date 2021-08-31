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
    public class GetServiceConsumersPageResponseUnmarshaller
    {
        public static GetServiceConsumersPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceConsumersPageResponse getServiceConsumersPageResponse = new GetServiceConsumersPageResponse();

			getServiceConsumersPageResponse.HttpResponse = _ctx.HttpResponse;
			getServiceConsumersPageResponse.Code = _ctx.IntegerValue("GetServiceConsumersPage.Code");
			getServiceConsumersPageResponse.Message = _ctx.StringValue("GetServiceConsumersPage.Message");
			getServiceConsumersPageResponse.Success = _ctx.BooleanValue("GetServiceConsumersPage.Success");

			GetServiceConsumersPageResponse.GetServiceConsumersPage_Data data = new GetServiceConsumersPageResponse.GetServiceConsumersPage_Data();
			data.Size = _ctx.IntegerValue("GetServiceConsumersPage.Data.Size");
			data.TotalElements = _ctx.IntegerValue("GetServiceConsumersPage.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("GetServiceConsumersPage.Data.TotalPages");

			List<GetServiceConsumersPageResponse.GetServiceConsumersPage_Data.GetServiceConsumersPage_Provider> data_content = new List<GetServiceConsumersPageResponse.GetServiceConsumersPage_Data.GetServiceConsumersPage_Provider>();
			for (int i = 0; i < _ctx.Length("GetServiceConsumersPage.Data.Content.Length"); i++) {
				GetServiceConsumersPageResponse.GetServiceConsumersPage_Data.GetServiceConsumersPage_Provider provider = new GetServiceConsumersPageResponse.GetServiceConsumersPage_Data.GetServiceConsumersPage_Provider();
				provider.Ip = _ctx.StringValue("GetServiceConsumersPage.Data.Content["+ i +"].Ip");
				provider.EdasAppName = _ctx.StringValue("GetServiceConsumersPage.Data.Content["+ i +"].EdasAppName");
				provider.EdassAppId = _ctx.StringValue("GetServiceConsumersPage.Data.Content["+ i +"].EdassAppId");

				data_content.Add(provider);
			}
			data.Content = data_content;
			getServiceConsumersPageResponse.Data = data;
        
			return getServiceConsumersPageResponse;
        }
    }
}
