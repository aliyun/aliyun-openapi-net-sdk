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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSagStaticRouteListResponseUnmarshaller
    {
        public static DescribeSagStaticRouteListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagStaticRouteListResponse describeSagStaticRouteListResponse = new DescribeSagStaticRouteListResponse();

			describeSagStaticRouteListResponse.HttpResponse = context.HttpResponse;
			describeSagStaticRouteListResponse.RequestId = context.StringValue("DescribeSagStaticRouteList.RequestId");

			List<DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_StaticRoute> describeSagStaticRouteListResponse_staticRoutes = new List<DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_StaticRoute>();
			for (int i = 0; i < context.Length("DescribeSagStaticRouteList.StaticRoutes.Length"); i++) {
				DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_StaticRoute staticRoute = new DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_StaticRoute();
				staticRoute.PortName = context.StringValue("DescribeSagStaticRouteList.StaticRoutes["+ i +"].PortName");
				staticRoute.DestinationCidr = context.StringValue("DescribeSagStaticRouteList.StaticRoutes["+ i +"].DestinationCidr");
				staticRoute.NextHop = context.StringValue("DescribeSagStaticRouteList.StaticRoutes["+ i +"].NextHop");
				staticRoute.Vlan = context.StringValue("DescribeSagStaticRouteList.StaticRoutes["+ i +"].Vlan");

				describeSagStaticRouteListResponse_staticRoutes.Add(staticRoute);
			}
			describeSagStaticRouteListResponse.StaticRoutes = describeSagStaticRouteListResponse_staticRoutes;

			List<DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_TaskState> describeSagStaticRouteListResponse_taskStates = new List<DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagStaticRouteList.TaskStates.Length"); i++) {
				DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_TaskState taskState = new DescribeSagStaticRouteListResponse.DescribeSagStaticRouteList_TaskState();
				taskState.State = context.StringValue("DescribeSagStaticRouteList.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagStaticRouteList.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagStaticRouteList.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagStaticRouteList.TaskStates["+ i +"].CreateTime");

				describeSagStaticRouteListResponse_taskStates.Add(taskState);
			}
			describeSagStaticRouteListResponse.TaskStates = describeSagStaticRouteListResponse_taskStates;
        
			return describeSagStaticRouteListResponse;
        }
    }
}
