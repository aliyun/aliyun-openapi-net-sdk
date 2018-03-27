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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CSB.Model.V20171118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindApproveServiceListResponseUnmarshaller
    {
        public static FindApproveServiceListResponse Unmarshall(UnmarshallerContext context)
        {
			FindApproveServiceListResponse findApproveServiceListResponse = new FindApproveServiceListResponse();

			findApproveServiceListResponse.HttpResponse = context.HttpResponse;
			findApproveServiceListResponse.Code = context.IntegerValue("FindApproveServiceList.Code");
			findApproveServiceListResponse.Message = context.StringValue("FindApproveServiceList.Message");
			findApproveServiceListResponse.RequestId = context.StringValue("FindApproveServiceList.RequestId");

			FindApproveServiceListResponse.FindApproveServiceList_Data data = new FindApproveServiceListResponse.FindApproveServiceList_Data();
			data.Total = context.IntegerValue("FindApproveServiceList.Data.Total");
			data.PageNumber = context.IntegerValue("FindApproveServiceList.Data.PageNumber");
			data.CurrentPage = context.IntegerValue("FindApproveServiceList.Data.CurrentPage");

			List<FindApproveServiceListResponse.FindApproveServiceList_Data.FindApproveServiceList_Service> data_serviceList = new List<FindApproveServiceListResponse.FindApproveServiceList_Data.FindApproveServiceList_Service>();
			for (int i = 0; i < context.Length("FindApproveServiceList.Data.ServiceList.Length"); i++) {
				FindApproveServiceListResponse.FindApproveServiceList_Data.FindApproveServiceList_Service service = new FindApproveServiceListResponse.FindApproveServiceList_Data.FindApproveServiceList_Service();
				service.AllVisiable = context.BooleanValue("FindApproveServiceList.Data.ServiceList["+ i +"].AllVisiable");
				service.CasTargets = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].CasTargets");
				service.CreateTime = context.LongValue("FindApproveServiceList.Data.ServiceList["+ i +"].CreateTime");
				service.CsbId = context.LongValue("FindApproveServiceList.Data.ServiceList["+ i +"].CsbId");
				service.Id = context.LongValue("FindApproveServiceList.Data.ServiceList["+ i +"].Id");
				service.InterfaceName = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].InterfaceName");
				service.ModifiedTime = context.LongValue("FindApproveServiceList.Data.ServiceList["+ i +"].ModifiedTime");
				service.OwnerId = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].OwnerId");
				service.PrincipalName = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].PrincipalName");
				service.ProjectId = context.LongValue("FindApproveServiceList.Data.ServiceList["+ i +"].ProjectId");
				service.ProjectName = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].ProjectName");
				service.Qps = context.IntegerValue("FindApproveServiceList.Data.ServiceList["+ i +"].Qps");
				service.Scope = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].Scope");
				service.ServiceName = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].ServiceName");
				service.ServiceVersion = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].ServiceVersion");
				service.SkipAuth = context.BooleanValue("FindApproveServiceList.Data.ServiceList["+ i +"].SkipAuth");
				service.StatisticName = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].StatisticName");
				service.Status = context.IntegerValue("FindApproveServiceList.Data.ServiceList["+ i +"].Status");
				service.UserId = context.StringValue("FindApproveServiceList.Data.ServiceList["+ i +"].UserId");

				data_serviceList.Add(service);
			}
			data.ServiceList = data_serviceList;
			findApproveServiceListResponse.Data = data;
        
			return findApproveServiceListResponse;
        }
    }
}