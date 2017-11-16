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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeRouterInterfacesForGlobalResponseUnmarshaller
    {
        public static DescribeRouterInterfacesForGlobalResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouterInterfacesForGlobalResponse describeRouterInterfacesForGlobalResponse = new DescribeRouterInterfacesForGlobalResponse();

			describeRouterInterfacesForGlobalResponse.HttpResponse = context.HttpResponse;
			describeRouterInterfacesForGlobalResponse.RequestId = context.StringValue("DescribeRouterInterfacesForGlobal.RequestId");
			describeRouterInterfacesForGlobalResponse.Code = context.StringValue("DescribeRouterInterfacesForGlobal.Code");
			describeRouterInterfacesForGlobalResponse.Message = context.StringValue("DescribeRouterInterfacesForGlobal.Message");
			describeRouterInterfacesForGlobalResponse.Desc = context.StringValue("DescribeRouterInterfacesForGlobal.Desc");
			describeRouterInterfacesForGlobalResponse.Success = context.BooleanValue("DescribeRouterInterfacesForGlobal.Success");
			describeRouterInterfacesForGlobalResponse.PageSize = context.IntegerValue("DescribeRouterInterfacesForGlobal.PageSize");
			describeRouterInterfacesForGlobalResponse.PageNumber = context.IntegerValue("DescribeRouterInterfacesForGlobal.PageNumber");
			describeRouterInterfacesForGlobalResponse.TotalCount = context.IntegerValue("DescribeRouterInterfacesForGlobal.TotalCount");

			List<DescribeRouterInterfacesForGlobalResponse.DescribeRouterInterfacesForGlobal_RouterInterfaceType> describeRouterInterfacesForGlobalResponse_routerInterfaceSet = new List<DescribeRouterInterfacesForGlobalResponse.DescribeRouterInterfacesForGlobal_RouterInterfaceType>();
			for (int i = 0; i < context.Length("DescribeRouterInterfacesForGlobal.RouterInterfaceSet.Length"); i++) {
				DescribeRouterInterfacesForGlobalResponse.DescribeRouterInterfacesForGlobal_RouterInterfaceType routerInterfaceType = new DescribeRouterInterfacesForGlobalResponse.DescribeRouterInterfacesForGlobal_RouterInterfaceType();
				routerInterfaceType.BusinessStatus = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].BusinessStatus");
				routerInterfaceType.AccessPointId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].AccessPointId");
				routerInterfaceType.ChargeType = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].ChargeType");
				routerInterfaceType.ConnectedTime = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].ConnectedTime");
				routerInterfaceType.CreationTime = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].CreationTime");
				routerInterfaceType.RouterInterfaceId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].RouterInterfaceId");
				routerInterfaceType.OppositeInterfaceBusinessStatus = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeInterfaceBusinessStatus");
				routerInterfaceType.OppositeInterfaceId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeInterfaceId");
				routerInterfaceType.OppositeInterfaceOwnerId = context.LongValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeInterfaceOwnerId");
				routerInterfaceType.OppositeInterfaceSpec = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeInterfaceSpec");
				routerInterfaceType.OppositeInterfaceStatus = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeInterfaceStatus");
				routerInterfaceType.OppositeRegionId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeRegionId");
				routerInterfaceType.OppositeAccessPointId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeAccessPointId");
				routerInterfaceType.OppositeRouterId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeRouterId");
				routerInterfaceType.OppositeRouterType = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeRouterType");
				routerInterfaceType.OppositeVpcInstanceId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].OppositeVpcInstanceId");
				routerInterfaceType.RegionId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].RegionId");
				routerInterfaceType.Role = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].Role");
				routerInterfaceType.RouterId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].RouterId");
				routerInterfaceType.RouterType = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].RouterType");
				routerInterfaceType.Spec = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].Spec");
				routerInterfaceType.Status = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].Status");
				routerInterfaceType.VpcInstanceId = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].VpcInstanceId");
				routerInterfaceType.Name = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].Name");
				routerInterfaceType.Description = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].Description");
				routerInterfaceType.HealthCheckSourceIp = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].HealthCheckSourceIp");
				routerInterfaceType.HealthCheckTargetIp = context.StringValue("DescribeRouterInterfacesForGlobal.RouterInterfaceSet["+ i +"].HealthCheckTargetIp");

				describeRouterInterfacesForGlobalResponse_routerInterfaceSet.Add(routerInterfaceType);
			}
			describeRouterInterfacesForGlobalResponse.RouterInterfaceSet = describeRouterInterfacesForGlobalResponse_routerInterfaceSet;
        
			return describeRouterInterfacesForGlobalResponse;
        }
    }
}