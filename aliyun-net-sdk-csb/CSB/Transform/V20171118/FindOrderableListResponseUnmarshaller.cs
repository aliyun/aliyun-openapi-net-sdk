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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindOrderableListResponseUnmarshaller
    {
        public static FindOrderableListResponse Unmarshall(UnmarshallerContext context)
        {
			FindOrderableListResponse findOrderableListResponse = new FindOrderableListResponse();

			findOrderableListResponse.HttpResponse = context.HttpResponse;
			findOrderableListResponse.Code = context.IntegerValue("FindOrderableList.Code");
			findOrderableListResponse.Message = context.StringValue("FindOrderableList.Message");
			findOrderableListResponse.RequestId = context.StringValue("FindOrderableList.RequestId");

			FindOrderableListResponse.FindOrderableList_Data data = new FindOrderableListResponse.FindOrderableList_Data();
			data.CurrentPage = context.IntegerValue("FindOrderableList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindOrderableList.Data.PageNumber");

			List<FindOrderableListResponse.FindOrderableList_Data.FindOrderableList_Service> data_serviceList = new List<FindOrderableListResponse.FindOrderableList_Data.FindOrderableList_Service>();
			for (int i = 0; i < context.Length("FindOrderableList.Data.ServiceList.Length"); i++) {
				FindOrderableListResponse.FindOrderableList_Data.FindOrderableList_Service service = new FindOrderableListResponse.FindOrderableList_Data.FindOrderableList_Service();
				service.Alias = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].Alias");
				service.AllVisiable = context.BooleanValue("FindOrderableList.Data.ServiceList["+ i +"].AllVisiable");
				service.ApproveUserId = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].ApproveUserId");
				service.CasTargets = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].CasTargets");
				service.CreateTime = context.LongValue("FindOrderableList.Data.ServiceList["+ i +"].CreateTime");
				service.CsbId = context.LongValue("FindOrderableList.Data.ServiceList["+ i +"].CsbId");
				service.Id = context.LongValue("FindOrderableList.Data.ServiceList["+ i +"].Id");
				service.InterfaceName = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].InterfaceName");
				service.ModifiedTime = context.LongValue("FindOrderableList.Data.ServiceList["+ i +"].ModifiedTime");
				service.OwnerId = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].OwnerId");
				service.PrincipalName = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].PrincipalName");
				service.ProjectId = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].ProjectId");
				service.ProjectName = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].ProjectName");
				service.Scope = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].Scope");
				service.ServiceName = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].ServiceName");
				service.ServiceVersion = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].ServiceVersion");
				service.SkipAuth = context.BooleanValue("FindOrderableList.Data.ServiceList["+ i +"].SkipAuth");
				service.StatisticName = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].StatisticName");
				service.Status = context.IntegerValue("FindOrderableList.Data.ServiceList["+ i +"].Status");
				service.UserId = context.StringValue("FindOrderableList.Data.ServiceList["+ i +"].UserId");

				data_serviceList.Add(service);
			}
			data.ServiceList = data_serviceList;
			findOrderableListResponse.Data = data;
        
			return findOrderableListResponse;
        }
    }
}
