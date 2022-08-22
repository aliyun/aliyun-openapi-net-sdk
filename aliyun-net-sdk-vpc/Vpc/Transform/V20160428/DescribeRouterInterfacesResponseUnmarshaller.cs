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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
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
				routerInterfaceType.ReservationActiveTime = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ReservationActiveTime");
				routerInterfaceType.HealthCheckTargetIp = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HealthCheckTargetIp");
				routerInterfaceType.Status = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Status");
				routerInterfaceType.CreationTime = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].CreationTime");
				routerInterfaceType.ReservationOrderType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ReservationOrderType");
				routerInterfaceType.OppositeInterfaceId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceId");
				routerInterfaceType.Spec = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Spec");
				routerInterfaceType.ChargeType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ChargeType");
				routerInterfaceType.RouterInterfaceId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterInterfaceId");
				routerInterfaceType.HcThreshold = _ctx.IntegerValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HcThreshold");
				routerInterfaceType.OppositeRouterType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRouterType");
				routerInterfaceType.VpcInstanceId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].VpcInstanceId");
				routerInterfaceType.OppositeInterfaceOwnerId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceOwnerId");
				routerInterfaceType.OppositeVpcInstanceId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeVpcInstanceId");
				routerInterfaceType.ReservationInternetChargeType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ReservationInternetChargeType");
				routerInterfaceType.CrossBorder = _ctx.BooleanValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].CrossBorder");
				routerInterfaceType.Bandwidth = _ctx.IntegerValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Bandwidth");
				routerInterfaceType.Description = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Description");
				routerInterfaceType.HcRate = _ctx.IntegerValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HcRate");
				routerInterfaceType.ReservationBandwidth = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ReservationBandwidth");
				routerInterfaceType.Name = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Name");
				routerInterfaceType.OppositeRouterId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRouterId");
				routerInterfaceType.OppositeInterfaceSpec = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceSpec");
				routerInterfaceType.RouterId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterId");
				routerInterfaceType.OppositeInterfaceBusinessStatus = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceBusinessStatus");
				routerInterfaceType.ConnectedTime = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].ConnectedTime");
				routerInterfaceType.HealthCheckSourceIp = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HealthCheckSourceIp");
				routerInterfaceType.OppositeInterfaceStatus = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeInterfaceStatus");
				routerInterfaceType.EndTime = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].EndTime");
				routerInterfaceType.OppositeRegionId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeRegionId");
				routerInterfaceType.OppositeAccessPointId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeAccessPointId");
				routerInterfaceType.BusinessStatus = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].BusinessStatus");
				routerInterfaceType.OppositeBandwidth = _ctx.IntegerValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].OppositeBandwidth");
				routerInterfaceType.RouterType = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].RouterType");
				routerInterfaceType.Role = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Role");
				routerInterfaceType.HasReservationData = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].HasReservationData");
				routerInterfaceType.AccessPointId = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].AccessPointId");
				routerInterfaceType.Ipv6Status = _ctx.StringValue("DescribeRouterInterfaces.RouterInterfaceSet["+ i +"].Ipv6Status");

				describeRouterInterfacesResponse_routerInterfaceSet.Add(routerInterfaceType);
			}
			describeRouterInterfacesResponse.RouterInterfaceSet = describeRouterInterfacesResponse_routerInterfaceSet;
        
			return describeRouterInterfacesResponse;
        }
    }
}
