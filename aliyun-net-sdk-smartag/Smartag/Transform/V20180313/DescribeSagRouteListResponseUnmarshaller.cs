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
    public class DescribeSagRouteListResponseUnmarshaller
    {
        public static DescribeSagRouteListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagRouteListResponse describeSagRouteListResponse = new DescribeSagRouteListResponse();

			describeSagRouteListResponse.HttpResponse = context.HttpResponse;
			describeSagRouteListResponse.RequestId = context.StringValue("DescribeSagRouteList.RequestId");

			List<DescribeSagRouteListResponse.DescribeSagRouteList_Route> describeSagRouteListResponse_routes = new List<DescribeSagRouteListResponse.DescribeSagRouteList_Route>();
			for (int i = 0; i < context.Length("DescribeSagRouteList.Routes.Length"); i++) {
				DescribeSagRouteListResponse.DescribeSagRouteList_Route route = new DescribeSagRouteListResponse.DescribeSagRouteList_Route();
				route.PortName = context.StringValue("DescribeSagRouteList.Routes["+ i +"].PortName");
				route.RouteProtocol = context.StringValue("DescribeSagRouteList.Routes["+ i +"].RouteProtocol");
				route.DestinationCidr = context.StringValue("DescribeSagRouteList.Routes["+ i +"].DestinationCidr");
				route.NextHop = context.StringValue("DescribeSagRouteList.Routes["+ i +"].NextHop");
				route.Cost = context.StringValue("DescribeSagRouteList.Routes["+ i +"].Cost");

				List<string> route_conflictCidrs = new List<string>();
				for (int j = 0; j < context.Length("DescribeSagRouteList.Routes["+ i +"].ConflictCidrs.Length"); j++) {
					route_conflictCidrs.Add(context.StringValue("DescribeSagRouteList.Routes["+ i +"].ConflictCidrs["+ j +"]"));
				}
				route.ConflictCidrs = route_conflictCidrs;

				describeSagRouteListResponse_routes.Add(route);
			}
			describeSagRouteListResponse.Routes = describeSagRouteListResponse_routes;
        
			return describeSagRouteListResponse;
        }
    }
}
