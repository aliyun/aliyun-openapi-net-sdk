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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeRouterInterfacesResponseUnmarshaller
    {
        public static DescribeRouterInterfacesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouterInterfacesResponse describeRouterInterfacesResponse = new DescribeRouterInterfacesResponse();

			describeRouterInterfacesResponse.HttpResponse = context.HttpResponse;
			describeRouterInterfacesResponse.RequestId = context.StringValue("DescribeRouterInterfaces.RequestId");
			describeRouterInterfacesResponse.PageNumber = context.IntegerValue("DescribeRouterInterfaces.PageNumber");
			describeRouterInterfacesResponse.PageSize = context.IntegerValue("DescribeRouterInterfaces.PageSize");
			describeRouterInterfacesResponse.TotalCount = context.IntegerValue("DescribeRouterInterfaces.TotalCount");

			List<DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType> describeRouterInterfacesResponse_routerInterfaceSet = new List<DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType>();
			for (int i = 0; i < context.Length("DescribeRouterInterfaces.RouterInterfaceSet.Length"); i++) {
				DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType routerInterfaceType = new DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType();
				routerInterfaceType.RouterInterfaceId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterInterfaceId");
				routerInterfaceType.OppositeRegionId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRegionId");
				routerInterfaceType.Role = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Role");
				routerInterfaceType.Spec = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Spec");
				routerInterfaceType.Name = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Name");
				routerInterfaceType.Description = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Description");
				routerInterfaceType.RouterId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterId");
				routerInterfaceType.RouterType = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterType");
				routerInterfaceType.CreationTime = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].CreationTime");
				routerInterfaceType.EndTime = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].EndTime");
				routerInterfaceType.ChargeType = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ChargeType");
				routerInterfaceType.Status = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Status");
				routerInterfaceType.BusinessStatus = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].BusinessStatus");
				routerInterfaceType.ConnectedTime = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ConnectedTime");
				routerInterfaceType.OppositeInterfaceId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceId");
				routerInterfaceType.OppositeInterfaceSpec = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceSpec");
				routerInterfaceType.OppositeInterfaceStatus = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceStatus");
				routerInterfaceType.OppositeInterfaceBusinessStatus = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceBusinessStatus");
				routerInterfaceType.OppositeRouterId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRouterId");
				routerInterfaceType.OppositeRouterType = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRouterType");
				routerInterfaceType.OppositeInterfaceOwnerId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceOwnerId");
				routerInterfaceType.AccessPointId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].AccessPointId");
				routerInterfaceType.OppositeAccessPointId = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeAccessPointId");
				routerInterfaceType.HealthCheckSourceIp = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HealthCheckSourceIp");
				routerInterfaceType.HealthCheckTargetIp = context.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HealthCheckTargetIp");

				describeRouterInterfacesResponse_routerInterfaceSet.Add(routerInterfaceType);
			}
			describeRouterInterfacesResponse.RouterInterfaceSet = describeRouterInterfacesResponse_routerInterfaceSet;
        
			return describeRouterInterfacesResponse;
        }
    }
}
