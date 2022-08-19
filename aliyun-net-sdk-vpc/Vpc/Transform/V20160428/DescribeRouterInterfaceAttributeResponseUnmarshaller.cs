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
			describeRouterInterfaceAttributeResponse.ReservationActiveTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationActiveTime");
			describeRouterInterfaceAttributeResponse.HealthCheckTargetIp = _ctx.StringValue("DescribeRouterInterfaceAttribute.HealthCheckTargetIp");
			describeRouterInterfaceAttributeResponse.Status = _ctx.StringValue("DescribeRouterInterfaceAttribute.Status");
			describeRouterInterfaceAttributeResponse.CreationTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.CreationTime");
			describeRouterInterfaceAttributeResponse.ReservationOrderType = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationOrderType");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceId");
			describeRouterInterfaceAttributeResponse.Spec = _ctx.StringValue("DescribeRouterInterfaceAttribute.Spec");
			describeRouterInterfaceAttributeResponse.ChargeType = _ctx.StringValue("DescribeRouterInterfaceAttribute.ChargeType");
			describeRouterInterfaceAttributeResponse.RouterInterfaceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.RouterInterfaceId");
			describeRouterInterfaceAttributeResponse.Message = _ctx.StringValue("DescribeRouterInterfaceAttribute.Message");
			describeRouterInterfaceAttributeResponse.HcThreshold = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.HcThreshold");
			describeRouterInterfaceAttributeResponse.OppositeRouterType = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeRouterType");
			describeRouterInterfaceAttributeResponse.GmtModified = _ctx.StringValue("DescribeRouterInterfaceAttribute.GmtModified");
			describeRouterInterfaceAttributeResponse.VpcInstanceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.VpcInstanceId");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceOwnerId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceOwnerId");
			describeRouterInterfaceAttributeResponse.OppositeVpcInstanceId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeVpcInstanceId");
			describeRouterInterfaceAttributeResponse.ReservationInternetChargeType = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationInternetChargeType");
			describeRouterInterfaceAttributeResponse.CrossBorder = _ctx.BooleanValue("DescribeRouterInterfaceAttribute.CrossBorder");
			describeRouterInterfaceAttributeResponse.RequestId = _ctx.StringValue("DescribeRouterInterfaceAttribute.RequestId");
			describeRouterInterfaceAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.Bandwidth");
			describeRouterInterfaceAttributeResponse.Description = _ctx.StringValue("DescribeRouterInterfaceAttribute.Description");
			describeRouterInterfaceAttributeResponse.HcRate = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.HcRate");
			describeRouterInterfaceAttributeResponse.ReservationBandwidth = _ctx.StringValue("DescribeRouterInterfaceAttribute.ReservationBandwidth");
			describeRouterInterfaceAttributeResponse.Code = _ctx.StringValue("DescribeRouterInterfaceAttribute.Code");
			describeRouterInterfaceAttributeResponse.Name = _ctx.StringValue("DescribeRouterInterfaceAttribute.Name");
			describeRouterInterfaceAttributeResponse.OppositeRouterId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeRouterId");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceSpec = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceSpec");
			describeRouterInterfaceAttributeResponse.RouterId = _ctx.StringValue("DescribeRouterInterfaceAttribute.RouterId");
			describeRouterInterfaceAttributeResponse.Success = _ctx.BooleanValue("DescribeRouterInterfaceAttribute.Success");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceBusinessStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceBusinessStatus");
			describeRouterInterfaceAttributeResponse.ConnectedTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.ConnectedTime");
			describeRouterInterfaceAttributeResponse.HealthCheckSourceIp = _ctx.StringValue("DescribeRouterInterfaceAttribute.HealthCheckSourceIp");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceStatus");
			describeRouterInterfaceAttributeResponse.EndTime = _ctx.StringValue("DescribeRouterInterfaceAttribute.EndTime");
			describeRouterInterfaceAttributeResponse.OppositeRegionId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeRegionId");
			describeRouterInterfaceAttributeResponse.OppositeAccessPointId = _ctx.StringValue("DescribeRouterInterfaceAttribute.OppositeAccessPointId");
			describeRouterInterfaceAttributeResponse.BusinessStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.BusinessStatus");
			describeRouterInterfaceAttributeResponse.HealthCheckStatus = _ctx.StringValue("DescribeRouterInterfaceAttribute.HealthCheckStatus");
			describeRouterInterfaceAttributeResponse.OppositeBandwidth = _ctx.IntegerValue("DescribeRouterInterfaceAttribute.OppositeBandwidth");
			describeRouterInterfaceAttributeResponse.RouterType = _ctx.StringValue("DescribeRouterInterfaceAttribute.RouterType");
			describeRouterInterfaceAttributeResponse.Role = _ctx.StringValue("DescribeRouterInterfaceAttribute.Role");
			describeRouterInterfaceAttributeResponse.HasReservationData = _ctx.StringValue("DescribeRouterInterfaceAttribute.HasReservationData");
			describeRouterInterfaceAttributeResponse.AccessPointId = _ctx.StringValue("DescribeRouterInterfaceAttribute.AccessPointId");
        
			return describeRouterInterfaceAttributeResponse;
        }
    }
}
