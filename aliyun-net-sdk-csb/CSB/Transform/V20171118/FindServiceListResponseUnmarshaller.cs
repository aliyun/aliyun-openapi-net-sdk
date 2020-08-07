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
    public class FindServiceListResponseUnmarshaller
    {
        public static FindServiceListResponse Unmarshall(UnmarshallerContext context)
        {
			FindServiceListResponse findServiceListResponse = new FindServiceListResponse();

			findServiceListResponse.HttpResponse = context.HttpResponse;
			findServiceListResponse.Message = context.StringValue("FindServiceList.Message");
			findServiceListResponse.Code = context.IntegerValue("FindServiceList.Code");
			findServiceListResponse.RequestId = context.StringValue("FindServiceList.RequestId");

			FindServiceListResponse.FindServiceList_Data data = new FindServiceListResponse.FindServiceList_Data();
			data.CurrentPage = context.IntegerValue("FindServiceList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindServiceList.Data.PageNumber");
			data.Total = context.IntegerValue("FindServiceList.Data.Total");

			List<FindServiceListResponse.FindServiceList_Data.FindServiceList_Service> data_serviceList = new List<FindServiceListResponse.FindServiceList_Data.FindServiceList_Service>();
			for (int i = 0; i < context.Length("FindServiceList.Data.ServiceList.Length"); i++) {
				FindServiceListResponse.FindServiceList_Data.FindServiceList_Service service = new FindServiceListResponse.FindServiceList_Data.FindServiceList_Service();
				service.Alias = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].Alias");
				service.AllVisiable = context.BooleanValue("FindServiceList.Data.ServiceList["+ i +"].AllVisiable");
				service.CreateTime = context.LongValue("FindServiceList.Data.ServiceList["+ i +"].CreateTime");
				service.CsbId = context.LongValue("FindServiceList.Data.ServiceList["+ i +"].CsbId");
				service.Description = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].Description");
				service.Id = context.LongValue("FindServiceList.Data.ServiceList["+ i +"].Id");
				service.InterfaceName = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].InterfaceName");
				service.ModifiedTime = context.LongValue("FindServiceList.Data.ServiceList["+ i +"].ModifiedTime");
				service.OrderInfo = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].OrderInfo");
				service.OwnerId = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].OwnerId");
				service.PrincipalName = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].PrincipalName");
				service.ProjectId = context.LongValue("FindServiceList.Data.ServiceList["+ i +"].ProjectId");
				service.ProjectName = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].ProjectName");
				service.Scope = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].Scope");
				service.ServiceName = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].ServiceName");
				service.ServiceVersion = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].ServiceVersion");
				service.SkipAuth = context.BooleanValue("FindServiceList.Data.ServiceList["+ i +"].SkipAuth");
				service.StatisticName = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].StatisticName");
				service.Status = context.IntegerValue("FindServiceList.Data.ServiceList["+ i +"].Status");
				service.UserId = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].UserId");
				service.CasTargets = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].CasTargets");
				service.RouteConfJson = context.StringValue("FindServiceList.Data.ServiceList["+ i +"].RouteConfJson");
				service.Qps = context.IntegerValue("FindServiceList.Data.ServiceList["+ i +"].Qps");

				data_serviceList.Add(service);
			}
			data.ServiceList = data_serviceList;
			findServiceListResponse.Data = data;
        
			return findServiceListResponse;
        }
    }
}
