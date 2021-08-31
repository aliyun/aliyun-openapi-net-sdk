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
    public class GetServiceListPageResponseUnmarshaller
    {
        public static GetServiceListPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceListPageResponse getServiceListPageResponse = new GetServiceListPageResponse();

			getServiceListPageResponse.HttpResponse = _ctx.HttpResponse;
			getServiceListPageResponse.Code = _ctx.IntegerValue("GetServiceListPage.Code");
			getServiceListPageResponse.Message = _ctx.StringValue("GetServiceListPage.Message");
			getServiceListPageResponse.Success = _ctx.BooleanValue("GetServiceListPage.Success");

			GetServiceListPageResponse.GetServiceListPage_Data data = new GetServiceListPageResponse.GetServiceListPage_Data();
			data.Size = _ctx.IntegerValue("GetServiceListPage.Data.Size");
			data.TotalElements = _ctx.IntegerValue("GetServiceListPage.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("GetServiceListPage.Data.TotalPages");

			List<GetServiceListPageResponse.GetServiceListPage_Data.GetServiceListPage_MseServiceResponse> data_content = new List<GetServiceListPageResponse.GetServiceListPage_Data.GetServiceListPage_MseServiceResponse>();
			for (int i = 0; i < _ctx.Length("GetServiceListPage.Data.Content.Length"); i++) {
				GetServiceListPageResponse.GetServiceListPage_Data.GetServiceListPage_MseServiceResponse mseServiceResponse = new GetServiceListPageResponse.GetServiceListPage_Data.GetServiceListPage_MseServiceResponse();
				mseServiceResponse.ServiceId = _ctx.StringValue("GetServiceListPage.Data.Content["+ i +"].ServiceId");
				mseServiceResponse.ServiceName = _ctx.StringValue("GetServiceListPage.Data.Content["+ i +"].ServiceName");
				mseServiceResponse.Version = _ctx.StringValue("GetServiceListPage.Data.Content["+ i +"].Version");
				mseServiceResponse.Group = _ctx.StringValue("GetServiceListPage.Data.Content["+ i +"].Group");
				mseServiceResponse.EdasAppId = _ctx.StringValue("GetServiceListPage.Data.Content["+ i +"].EdasAppId");
				mseServiceResponse.EdasAppName = _ctx.StringValue("GetServiceListPage.Data.Content["+ i +"].EdasAppName");
				mseServiceResponse.InstanceNum = _ctx.IntegerValue("GetServiceListPage.Data.Content["+ i +"].InstanceNum");
				mseServiceResponse.RegisterType = _ctx.StringValue("GetServiceListPage.Data.Content["+ i +"].RegisterType");

				data_content.Add(mseServiceResponse);
			}
			data.Content = data_content;
			getServiceListPageResponse.Data = data;
        
			return getServiceListPageResponse;
        }
    }
}
