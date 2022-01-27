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
        public static DescribeRouterInterfacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRouterInterfacesResponse describeRouterInterfacesResponse = new DescribeRouterInterfacesResponse();

			describeRouterInterfacesResponse.HttpResponse = _ctx.HttpResponse;
			describeRouterInterfacesResponse.RequestId = _ctx.StringValue("DescribeRouterInterfaces.RequestId");
			describeRouterInterfacesResponse.PageNumber = _ctx.IntegerValue("DescribeRouterInterfaces.PageNumber");
			describeRouterInterfacesResponse.PageSize = _ctx.IntegerValue("DescribeRouterInterfaces.PageSize");
			describeRouterInterfacesResponse.TotalCount = _ctx.IntegerValue("DescribeRouterInterfaces.TotalCount");

			List<DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType> describeRouterInterfacesResponse_routerInterfaceSet = new List<DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType>();
			for (int i = 0; i < _ctx.Length("DescribeRouterInterfaces.RouterInterfaceSet.Length"); i++) {
				DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType routerInterfaceType = new DescribeRouterInterfacesResponse.DescribeRouterInterfaces_RouterInterfaceType();
				routerInterfaceType.HealthCheckTargetIp = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HealthCheckTargetIp");
				routerInterfaceType.CreationTime = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].CreationTime");
				routerInterfaceType.Status = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Status");
				routerInterfaceType.Spec = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Spec");
				routerInterfaceType.OppositeInterfaceId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceId");
				routerInterfaceType.RouterInterfaceId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterInterfaceId");
				routerInterfaceType.ChargeType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ChargeType");
				routerInterfaceType.OppositeRouterType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRouterType");
				routerInterfaceType.OppositeInterfaceOwnerId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceOwnerId");
				routerInterfaceType.Description = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Description");
				routerInterfaceType.Name = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Name");
				routerInterfaceType.OppositeRouterId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRouterId");
				routerInterfaceType.OppositeInterfaceSpec = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceSpec");
				routerInterfaceType.RouterId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterId");
				routerInterfaceType.OppositeInterfaceBusinessStatus = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceBusinessStatus");
				routerInterfaceType.ConnectedTime = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ConnectedTime");
				routerInterfaceType.OppositeInterfaceStatus = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceStatus");
				routerInterfaceType.HealthCheckSourceIp = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HealthCheckSourceIp");
				routerInterfaceType.EndTime = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].EndTime");
				routerInterfaceType.OppositeRegionId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRegionId");
				routerInterfaceType.OppositeAccessPointId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeAccessPointId");
				routerInterfaceType.BusinessStatus = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].BusinessStatus");
				routerInterfaceType.Role = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Role");
				routerInterfaceType.RouterType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterType");
				routerInterfaceType.AccessPointId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].AccessPointId");

				describeRouterInterfacesResponse_routerInterfaceSet.Add(routerInterfaceType);
			}
			describeRouterInterfacesResponse.RouterInterfaceSet = describeRouterInterfacesResponse_routerInterfaceSet;
        
			return describeRouterInterfacesResponse;
        }
    }
}
