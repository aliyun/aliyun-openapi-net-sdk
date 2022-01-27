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
    public class DescribeIpv6GatewayAttributeResponseUnmarshaller
    {
        public static DescribeIpv6GatewayAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpv6GatewayAttributeResponse describeIpv6GatewayAttributeResponse = new DescribeIpv6GatewayAttributeResponse();

			describeIpv6GatewayAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeIpv6GatewayAttributeResponse.RequestId = _ctx.StringValue("DescribeIpv6GatewayAttribute.RequestId");
			describeIpv6GatewayAttributeResponse.RegionId = _ctx.StringValue("DescribeIpv6GatewayAttribute.RegionId");
			describeIpv6GatewayAttributeResponse.Ipv6GatewayId = _ctx.StringValue("DescribeIpv6GatewayAttribute.Ipv6GatewayId");
			describeIpv6GatewayAttributeResponse.VpcId = _ctx.StringValue("DescribeIpv6GatewayAttribute.VpcId");
			describeIpv6GatewayAttributeResponse.Status = _ctx.StringValue("DescribeIpv6GatewayAttribute.Status");
			describeIpv6GatewayAttributeResponse.BusinessStatus = _ctx.StringValue("DescribeIpv6GatewayAttribute.BusinessStatus");
			describeIpv6GatewayAttributeResponse.Name = _ctx.StringValue("DescribeIpv6GatewayAttribute.Name");
			describeIpv6GatewayAttributeResponse.Description = _ctx.StringValue("DescribeIpv6GatewayAttribute.Description");
			describeIpv6GatewayAttributeResponse.Spec = _ctx.StringValue("DescribeIpv6GatewayAttribute.Spec");
			describeIpv6GatewayAttributeResponse.InstanceChargeType = _ctx.StringValue("DescribeIpv6GatewayAttribute.InstanceChargeType");
			describeIpv6GatewayAttributeResponse.ExpiredTime = _ctx.StringValue("DescribeIpv6GatewayAttribute.ExpiredTime");
			describeIpv6GatewayAttributeResponse.CreationTime = _ctx.StringValue("DescribeIpv6GatewayAttribute.CreationTime");
        
			return describeIpv6GatewayAttributeResponse;
        }
    }
}
