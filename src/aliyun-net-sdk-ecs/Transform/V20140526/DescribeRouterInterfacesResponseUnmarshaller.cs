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
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeRouterInterfacesResponseUnmarshaller
    {
        public static DescribeRouterInterfacesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeRouterInterfacesResponse describeRouterInterfacesResponse = new DescribeRouterInterfacesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeRouterInterfaces.RequestId"),
                PageNumber = context.IntegerValue("DescribeRouterInterfaces.PageNumber"),
                PageSize = context.IntegerValue("DescribeRouterInterfaces.PageSize"),
                TotalCount = context.IntegerValue("DescribeRouterInterfaces.TotalCount")
            };
            List<DescribeRouterInterfacesResponse.RouterInterfaceType> routerInterfaceSet = new List<DescribeRouterInterfacesResponse.RouterInterfaceType>();
			for (int i = 0; i < context.Length("DescribeRouterInterfaces.RouterInterfaceSet.Length"); i++) {
                DescribeRouterInterfacesResponse.RouterInterfaceType routerInterfaceType = new DescribeRouterInterfacesResponse.RouterInterfaceType()
                {
                    RouterInterfaceId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].RouterInterfaceId"),
                    OppositeRegionId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeRegionId"),
                    Role = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].Role"),
                    Spec = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].Spec"),
                    Name = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].Name"),
                    Description = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].Description"),
                    RouterId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].RouterId"),
                    RouterType = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].RouterType"),
                    CreationTime = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].CreationTime"),
                    Status = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].Status"),
                    BusinessStatus = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].BusinessStatus"),
                    ConnectedTime = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].ConnectedTime"),
                    OppositeInterfaceId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeInterfaceId"),
                    OppositeInterfaceSpec = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeInterfaceSpec"),
                    OppositeInterfaceStatus = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeInterfaceStatus"),
                    OppositeInterfaceBusinessStatus = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeInterfaceBusinessStatus"),
                    OppositeRouterId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeRouterId"),
                    OppositeRouterType = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeRouterType"),
                    OppositeInterfaceOwnerId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeInterfaceOwnerId"),
                    AccessPointId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].AccessPointId"),
                    OppositeAccessPointId = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].OppositeAccessPointId"),
                    HealthCheckSourceIp = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].HealthCheckSourceIp"),
                    HealthCheckTargetIp = context.StringValue($"DescribeRouterInterfaces.RouterInterfaceSet[{i}].HealthCheckTargetIp")
                };
                routerInterfaceSet.Add(routerInterfaceType);
			}
			describeRouterInterfacesResponse.RouterInterfaceSet = routerInterfaceSet;
        
			return describeRouterInterfacesResponse;
        }
    }
}