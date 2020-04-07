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
        public static DescribeRouterInterfaceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouterInterfaceAttributeResponse describeRouterInterfaceAttributeResponse = new DescribeRouterInterfaceAttributeResponse();

			describeRouterInterfaceAttributeResponse.HttpResponse = context.HttpResponse;
			describeRouterInterfaceAttributeResponse.RequestId = context.StringValue("DescribeRouterInterfaceAttribute.RequestId");
			describeRouterInterfaceAttributeResponse.Code = context.StringValue("DescribeRouterInterfaceAttribute.Code");
			describeRouterInterfaceAttributeResponse.Message = context.StringValue("DescribeRouterInterfaceAttribute.Message");
			describeRouterInterfaceAttributeResponse.Success = context.BooleanValue("DescribeRouterInterfaceAttribute.Success");
			describeRouterInterfaceAttributeResponse.RouterInterfaceId = context.StringValue("DescribeRouterInterfaceAttribute.RouterInterfaceId");
			describeRouterInterfaceAttributeResponse.OppositeRegionId = context.StringValue("DescribeRouterInterfaceAttribute.OppositeRegionId");
			describeRouterInterfaceAttributeResponse.Role = context.StringValue("DescribeRouterInterfaceAttribute.Role");
			describeRouterInterfaceAttributeResponse.Spec = context.StringValue("DescribeRouterInterfaceAttribute.Spec");
			describeRouterInterfaceAttributeResponse.Name = context.StringValue("DescribeRouterInterfaceAttribute.Name");
			describeRouterInterfaceAttributeResponse.Description = context.StringValue("DescribeRouterInterfaceAttribute.Description");
			describeRouterInterfaceAttributeResponse.RouterId = context.StringValue("DescribeRouterInterfaceAttribute.RouterId");
			describeRouterInterfaceAttributeResponse.RouterType = context.StringValue("DescribeRouterInterfaceAttribute.RouterType");
			describeRouterInterfaceAttributeResponse.CreationTime = context.StringValue("DescribeRouterInterfaceAttribute.CreationTime");
			describeRouterInterfaceAttributeResponse.GmtModified = context.StringValue("DescribeRouterInterfaceAttribute.GmtModified");
			describeRouterInterfaceAttributeResponse.EndTime = context.StringValue("DescribeRouterInterfaceAttribute.EndTime");
			describeRouterInterfaceAttributeResponse.ChargeType = context.StringValue("DescribeRouterInterfaceAttribute.ChargeType");
			describeRouterInterfaceAttributeResponse.Status = context.StringValue("DescribeRouterInterfaceAttribute.Status");
			describeRouterInterfaceAttributeResponse.BusinessStatus = context.StringValue("DescribeRouterInterfaceAttribute.BusinessStatus");
			describeRouterInterfaceAttributeResponse.ConnectedTime = context.StringValue("DescribeRouterInterfaceAttribute.ConnectedTime");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceId = context.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceId");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceSpec = context.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceSpec");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceStatus = context.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceStatus");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceBusinessStatus = context.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceBusinessStatus");
			describeRouterInterfaceAttributeResponse.OppositeRouterId = context.StringValue("DescribeRouterInterfaceAttribute.OppositeRouterId");
			describeRouterInterfaceAttributeResponse.OppositeRouterType = context.StringValue("DescribeRouterInterfaceAttribute.OppositeRouterType");
			describeRouterInterfaceAttributeResponse.OppositeInterfaceOwnerId = context.StringValue("DescribeRouterInterfaceAttribute.OppositeInterfaceOwnerId");
			describeRouterInterfaceAttributeResponse.AccessPointId = context.StringValue("DescribeRouterInterfaceAttribute.AccessPointId");
			describeRouterInterfaceAttributeResponse.OppositeAccessPointId = context.StringValue("DescribeRouterInterfaceAttribute.OppositeAccessPointId");
			describeRouterInterfaceAttributeResponse.HealthCheckSourceIp = context.StringValue("DescribeRouterInterfaceAttribute.HealthCheckSourceIp");
			describeRouterInterfaceAttributeResponse.HealthCheckTargetIp = context.StringValue("DescribeRouterInterfaceAttribute.HealthCheckTargetIp");
			describeRouterInterfaceAttributeResponse.OppositeVpcInstanceId = context.StringValue("DescribeRouterInterfaceAttribute.OppositeVpcInstanceId");
			describeRouterInterfaceAttributeResponse.Bandwidth = context.IntegerValue("DescribeRouterInterfaceAttribute.Bandwidth");
			describeRouterInterfaceAttributeResponse.VpcInstanceId = context.StringValue("DescribeRouterInterfaceAttribute.VpcInstanceId");
			describeRouterInterfaceAttributeResponse.OppositeBandwidth = context.IntegerValue("DescribeRouterInterfaceAttribute.OppositeBandwidth");
			describeRouterInterfaceAttributeResponse.HasReservationData = context.StringValue("DescribeRouterInterfaceAttribute.HasReservationData");
			describeRouterInterfaceAttributeResponse.ReservationBandwidth = context.StringValue("DescribeRouterInterfaceAttribute.ReservationBandwidth");
			describeRouterInterfaceAttributeResponse.ReservationInternetChargeType = context.StringValue("DescribeRouterInterfaceAttribute.ReservationInternetChargeType");
			describeRouterInterfaceAttributeResponse.ReservationActiveTime = context.StringValue("DescribeRouterInterfaceAttribute.ReservationActiveTime");
			describeRouterInterfaceAttributeResponse.ReservationOrderType = context.StringValue("DescribeRouterInterfaceAttribute.ReservationOrderType");
			describeRouterInterfaceAttributeResponse.CrossBorder = context.BooleanValue("DescribeRouterInterfaceAttribute.CrossBorder");
			describeRouterInterfaceAttributeResponse.HcThreshold = context.IntegerValue("DescribeRouterInterfaceAttribute.HcThreshold");
			describeRouterInterfaceAttributeResponse.HcRate = context.IntegerValue("DescribeRouterInterfaceAttribute.HcRate");
			describeRouterInterfaceAttributeResponse.HealthCheckStatus = context.StringValue("DescribeRouterInterfaceAttribute.HealthCheckStatus");
        
			return describeRouterInterfaceAttributeResponse;
        }
    }
}
