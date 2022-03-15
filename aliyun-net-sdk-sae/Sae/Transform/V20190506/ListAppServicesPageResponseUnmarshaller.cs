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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListAppServicesPageResponseUnmarshaller
    {
        public static ListAppServicesPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppServicesPageResponse listAppServicesPageResponse = new ListAppServicesPageResponse();

			listAppServicesPageResponse.HttpResponse = _ctx.HttpResponse;
			listAppServicesPageResponse.RequestId = _ctx.StringValue("ListAppServicesPage.RequestId");
			listAppServicesPageResponse.Message = _ctx.StringValue("ListAppServicesPage.Message");
			listAppServicesPageResponse.TraceId = _ctx.StringValue("ListAppServicesPage.TraceId");
			listAppServicesPageResponse.ErrorCode = _ctx.StringValue("ListAppServicesPage.ErrorCode");
			listAppServicesPageResponse.Code = _ctx.StringValue("ListAppServicesPage.Code");
			listAppServicesPageResponse.Success = _ctx.BooleanValue("ListAppServicesPage.Success");

			List<ListAppServicesPageResponse.ListAppServicesPage_DataItem> listAppServicesPageResponse_data = new List<ListAppServicesPageResponse.ListAppServicesPage_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAppServicesPage.Data.Length"); i++) {
				ListAppServicesPageResponse.ListAppServicesPage_DataItem dataItem = new ListAppServicesPageResponse.ListAppServicesPage_DataItem();
				dataItem.CurrentPage = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].CurrentPage");
				dataItem.TotalSize = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].TotalSize");
				dataItem.PageNumber = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].PageNumber");
				dataItem.PageSize = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].PageSize");

				List<ListAppServicesPageResponse.ListAppServicesPage_DataItem.ListAppServicesPage_MscAgentServiceResponse> dataItem_result = new List<ListAppServicesPageResponse.ListAppServicesPage_DataItem.ListAppServicesPage_MscAgentServiceResponse>();
				for (int j = 0; j < _ctx.Length("ListAppServicesPage.Data["+ i +"].Result.Length"); j++) {
					ListAppServicesPageResponse.ListAppServicesPage_DataItem.ListAppServicesPage_MscAgentServiceResponse mscAgentServiceResponse = new ListAppServicesPageResponse.ListAppServicesPage_DataItem.ListAppServicesPage_MscAgentServiceResponse();
					mscAgentServiceResponse.EdasAppName = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].Result["+ j +"].EdasAppName");
					mscAgentServiceResponse.Version = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].Result["+ j +"].Version");
					mscAgentServiceResponse.InstanceNum = _ctx.LongValue("ListAppServicesPage.Data["+ i +"].Result["+ j +"].InstanceNum");
					mscAgentServiceResponse.EdasAppId = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].Result["+ j +"].EdasAppId");
					mscAgentServiceResponse.ServiceName = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].Result["+ j +"].ServiceName");
					mscAgentServiceResponse.Group = _ctx.StringValue("ListAppServicesPage.Data["+ i +"].Result["+ j +"].Group");

					dataItem_result.Add(mscAgentServiceResponse);
				}
				dataItem.Result = dataItem_result;

				listAppServicesPageResponse_data.Add(dataItem);
			}
			listAppServicesPageResponse.Data = listAppServicesPageResponse_data;
        
			return listAppServicesPageResponse;
        }
    }
}
