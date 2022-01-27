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
    public class DescribeRouterInterfaceAttributeResponseUnmarshaller
    {
        public static DescribeRouterInterfaceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRouterInterfaceAttributeResponse describeRouterInterfaceAttributeResponse = new DescribeRouterInterfaceAttributeResponse();

			describeRouterInterfaceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeRouterInterfaceAttributeResponse.RequestId = _ctx.StringValue("DescribeRouterInterfaceAttribute.RequestId");
			describeRouterInterfaceAttributeResponse.Code = _ctx.StringValue("DescribeRouterInterfaceAttribute.Code");
			describeRouterInterfaceAttributeResponse.Message = _ctx.StringValue("DescribeRouterInterfaceAttribute.Message");
			describeRouterInterfaceAttributeResponse.Success = _ctx.BooleanValue("DescribeRouterInterfaceAttribute.Success");
			describeRouterInterfaceAttributeResponse.RouterInterfaceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.RouterInterfaceId");
			describeRouterInterfaceAttributeResponse.OppositeRegionId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeRegionId");
			describeRouterInterfaceAttributeResponse.Role = _ctx.StringValue("DescribeRouterInterfaceAttribute.Role");
			describeRouterInterfaceAttributeResponse.Spec = _ctx.StringValue("DescribeRouterInterfaceAttribute.Spec");
			describeRouterInterfaceAttributeResponse.Name = _ctx.StringValue("DescribeRouterInterfaceAttribute.Name");
			describeRouterInterfaceAttributeResponse.Description = _ctx.StringValue("DescribeRouterInterfaceAttribute.Description");
			describeRouterInterfaceAttributeResponse.RouterId = _ctx.StringValue("DescribeRouterInterfaceAttribute.RouterId");
			describeRouterInterfaceAttributeResponse.RouterType = _ctx.StringValue("DescribeRouterInterfaceAttribute.RouterType");
			describeRouterInterfaceAttributeResponse.CreationTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.CreationTime");
			describeRouterInterfaceAttributeResponse.GmtModified = _ctx.StringValue("DescribeRouterInterfaceAttribute.GmtModified");
			describeRouterInterfaceAttributeResponse.EndTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.EndTime");
			describeRouterInterfaceAttributeResponse.ChargeType = _ctx.StringValue("DescribeRouterInterfaceAttribute.ChargeType");
			describeRouterInterfaceAttributeResponse.Status = _ctx.StringValue("DescribeRouterInterfaceAttribute.Status");
			describeRouterInterfaceAttributeResponse.BusinessStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.BusinessStatus");
			describeRouterInterfaceAttributeResponse.ConnectedTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.ConnectedTime");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceId");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceSpec = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceSpec");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceStatus");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceBusinessStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceBusinessStatus");
			describeRouterInterfaceAttributeResponse.OppositeRouterId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeRouterId");
			describeRouterInterfaceAttributeResponse.OppositeRouterType = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeRouterType");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceOwnerId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceOwnerId");
			describeRouterInterfaceAttributeResponse.AccessPointId = _ctx.StringValue("DescribeRouterInterfaceAttribute.AccessPointId");
			describeRouterInterfaceAttributeResponse.OppositeAccessPointId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeAccessPointId");
			describeRouterInterfaceAttributeResponse.HealthCheckSourceIp = _ctx.StringValue("DescribeRouterInterfaceAttribute.HealthCheckSourceIp");
			describeRouterInterfaceAttributeResponse.HealthCheckTargetIp = _ctx.StringValue("DescribeRouterInterfaceAttribute.HealthCheckTargetIp");
			describeRouterInterfaceAttributeResponse.OppositeVpcInstanceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeVpcInstanceId");
			describeRouterInterfaceAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.Bandwidth");
			describeRouterInterfaceAttributeResponse.VpcInstanceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.VpcInstanceId");
			describeRouterInterfaceAttributeResponse.OppositeBandwidth = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.OppositeBandwidth");
			describeRouterInterfaceAttributeResponse.HasReservationData = _ctx.StringValue("DescribeRouterInterfaceAttribute.HasReservationData");
			describeRouterInterfaceAttributeResponse.ReservationBandwidth = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationBandwidth");
			describeRouterInterfaceAttributeResponse.ReservationInternetChargeType = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationInternetChargeType");
			describeRouterInterfaceAttributeResponse.ReservationActiveTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationActiveTime");
			describeRouterInterfaceAttributeResponse.ReservationOrderType = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationOrderType");
			describeRouterInterfaceAttributeResponse.CrossBorder = _ctx.BooleanValue("DescribeRouterInterfaceAttribute.CrossBorder");
			describeRouterInterfaceAttributeResponse.HcThreshold = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.HcThreshold");
			describeRouterInterfaceAttributeResponse.HcRate = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.HcRate");
			describeRouterInterfaceAttributeResponse.HealthCheckStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.HealthCheckStatus");
        
			return describeRouterInterfaceAttributeResponse;
        }
    }
}
