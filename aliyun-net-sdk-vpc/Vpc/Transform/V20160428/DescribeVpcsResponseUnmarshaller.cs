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
    public class DescribeVpcsResponseUnmarshaller
    {
        public static DescribeVpcsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpcsResponse describeVpcsResponse = new DescribeVpcsResponse();

			describeVpcsResponse.HttpResponse = context.HttpResponse;
			describeVpcsResponse.RequestId = context.StringValue("DescribeVpcs.RequestId");
			describeVpcsResponse.TotalCount = context.IntegerValue("DescribeVpcs.TotalCount");
			describeVpcsResponse.PageNumber = context.IntegerValue("DescribeVpcs.PageNumber");
			describeVpcsResponse.PageSize = context.IntegerValue("DescribeVpcs.PageSize");

			List<DescribeVpcsResponse.DescribeVpcs_Vpc> describeVpcsResponse_vpcs = new List<DescribeVpcsResponse.DescribeVpcs_Vpc>();
			for (int i = 0; i < context.Length("DescribeVpcs.Vpcs.Length"); i++) {
				DescribeVpcsResponse.DescribeVpcs_Vpc vpc = new DescribeVpcsResponse.DescribeVpcs_Vpc();
				vpc.VpcId = context.StringValue("DescribeVpcs.Vpcs["+ i +"].VpcId");
				vpc.RegionId = context.StringValue("DescribeVpcs.Vpcs["+ i +"].RegionId");
				vpc.Status = context.StringValue("DescribeVpcs.Vpcs["+ i +"].Status");
				vpc.VpcName = context.StringValue("DescribeVpcs.Vpcs["+ i +"].VpcName");
				vpc.CreationTime = context.StringValue("DescribeVpcs.Vpcs["+ i +"].CreationTime");
				vpc.CidrBlock = context.StringValue("DescribeVpcs.Vpcs["+ i +"].CidrBlock");
				vpc.VRouterId = context.StringValue("DescribeVpcs.Vpcs["+ i +"].VRouterId");
				vpc.Description = context.StringValue("DescribeVpcs.Vpcs["+ i +"].Description");
				vpc.IsDefault = context.BooleanValue("DescribeVpcs.Vpcs["+ i +"].IsDefault");

				List<string> vpc_vSwitchIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeVpcs.Vpcs["+ i +"].VSwitchIds.Length"); j++) {
					vpc_vSwitchIds.Add(context.StringValue("DescribeVpcs.Vpcs["+ i +"].VSwitchIds["+ j +"]"));
				}
				vpc.VSwitchIds = vpc_vSwitchIds;

				List<string> vpc_userCidrs = new List<string>();
				for (int j = 0; j < context.Length("DescribeVpcs.Vpcs["+ i +"].UserCidrs.Length"); j++) {
					vpc_userCidrs.Add(context.StringValue("DescribeVpcs.Vpcs["+ i +"].UserCidrs["+ j +"]"));
				}
				vpc.UserCidrs = vpc_userCidrs;

				List<string> vpc_natGatewayIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeVpcs.Vpcs["+ i +"].NatGatewayIds.Length"); j++) {
					vpc_natGatewayIds.Add(context.StringValue("DescribeVpcs.Vpcs["+ i +"].NatGatewayIds["+ j +"]"));
				}
				vpc.NatGatewayIds = vpc_natGatewayIds;

				List<string> vpc_routerTableIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeVpcs.Vpcs["+ i +"].RouterTableIds.Length"); j++) {
					vpc_routerTableIds.Add(context.StringValue("DescribeVpcs.Vpcs["+ i +"].RouterTableIds["+ j +"]"));
				}
				vpc.RouterTableIds = vpc_routerTableIds;

				describeVpcsResponse_vpcs.Add(vpc);
			}
			describeVpcsResponse.Vpcs = describeVpcsResponse_vpcs;
        
			return describeVpcsResponse;
        }
    }
}