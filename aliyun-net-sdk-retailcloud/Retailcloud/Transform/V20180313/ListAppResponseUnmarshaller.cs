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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListAppResponseUnmarshaller
    {
        public static ListAppResponse Unmarshall(UnmarshallerContext context)
        {
			ListAppResponse listAppResponse = new ListAppResponse();

			listAppResponse.HttpResponse = context.HttpResponse;
			listAppResponse.RequestId = context.StringValue("ListApp.RequestId");
			listAppResponse.Code = context.IntegerValue("ListApp.Code");
			listAppResponse.ErrorMsg = context.StringValue("ListApp.ErrorMsg");
			listAppResponse.TotalCount = context.IntegerValue("ListApp.TotalCount");

			List<ListAppResponse.ListApp_AppDetail> listAppResponse_data = new List<ListAppResponse.ListApp_AppDetail>();
			for (int i = 0; i < context.Length("ListApp.Data.Length"); i++) {
				ListAppResponse.ListApp_AppDetail appDetail = new ListAppResponse.ListApp_AppDetail();
				appDetail.AppId = context.LongValue("ListApp.Data["+ i +"].AppId");
				appDetail.Title = context.StringValue("ListApp.Data["+ i +"].Title");
				appDetail.Description = context.StringValue("ListApp.Data["+ i +"].Description");
				appDetail.Language = context.StringValue("ListApp.Data["+ i +"].Language");
				appDetail.OperatingSystem = context.StringValue("ListApp.Data["+ i +"].OperatingSystem");
				appDetail.BizName = context.StringValue("ListApp.Data["+ i +"].BizName");
				appDetail.ServiceType = context.StringValue("ListApp.Data["+ i +"].ServiceType");
				appDetail.DeployType = context.StringValue("ListApp.Data["+ i +"].DeployType");
				appDetail.BizTitle = context.StringValue("ListApp.Data["+ i +"].BizTitle");
				appDetail.AppStateType = context.StringValue("ListApp.Data["+ i +"].AppStateType");

				List<ListAppResponse.ListApp_AppDetail.ListApp_MiddleWareInfo> appDetail_middleWareList = new List<ListAppResponse.ListApp_AppDetail.ListApp_MiddleWareInfo>();
				for (int j = 0; j < context.Length("ListApp.Data["+ i +"].MiddleWareList.Length"); j++) {
					ListAppResponse.ListApp_AppDetail.ListApp_MiddleWareInfo middleWareInfo = new ListAppResponse.ListApp_AppDetail.ListApp_MiddleWareInfo();
					middleWareInfo.AppId = context.LongValue("ListApp.Data["+ i +"].MiddleWareList["+ j +"].AppId");
					middleWareInfo.Code = context.IntegerValue("ListApp.Data["+ i +"].MiddleWareList["+ j +"].Code");
					middleWareInfo.Name = context.StringValue("ListApp.Data["+ i +"].MiddleWareList["+ j +"].Name");

					appDetail_middleWareList.Add(middleWareInfo);
				}
				appDetail.MiddleWareList = appDetail_middleWareList;

				listAppResponse_data.Add(appDetail);
			}
			listAppResponse.Data = listAppResponse_data;
        
			return listAppResponse;
        }
    }
}
