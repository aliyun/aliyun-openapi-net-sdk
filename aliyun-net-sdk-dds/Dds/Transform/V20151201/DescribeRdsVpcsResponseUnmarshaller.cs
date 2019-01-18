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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRdsVpcsResponseUnmarshaller
    {
        public static DescribeRdsVpcsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRdsVpcsResponse describeRdsVpcsResponse = new DescribeRdsVpcsResponse();

			describeRdsVpcsResponse.HttpResponse = context.HttpResponse;
			describeRdsVpcsResponse.RequestId = context.StringValue("DescribeRdsVpcs.RequestId");

			DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs vpcs = new DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs();

			List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem> vpcs_vpc = new List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem>();
			for (int i = 0; i < context.Length("DescribeRdsVpcs.Vpcs.Vpc.Length"); i++) {
				DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem vpcItem = new DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem();
				vpcItem.VpcId = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VpcId");
				vpcItem.VpcName = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VpcName");
				vpcItem.Bid = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].Bid");
				vpcItem.AliUid = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].AliUid");
				vpcItem.RegionNo = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].RegionNo");
				vpcItem.CidrBlock = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].CidrBlock");
				vpcItem.IsDefault = context.BooleanValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].IsDefault");
				vpcItem.Status = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].Status");
				vpcItem.GmtCreate = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].GmtCreate");
				vpcItem.GmtModified = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].GmtModified");

				List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch> vpcItem_vSwitchs = new List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch>();
				for (int j = 0; j < context.Length("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs.Length"); j++) {
					DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch vSwitch = new DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch();
					vSwitch.VSwitchId = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].VSwitchId");
					vSwitch.VSwitchName = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].VSwitchName");
					vSwitch.IzNo = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].IzNo");
					vSwitch.CidrBlock = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].CidrBlock");
					vSwitch.IsDefault = context.BooleanValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].IsDefault");
					vSwitch.Status = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].Status");
					vSwitch.GmtCreate = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].GmtCreate");
					vSwitch.GmtModified = context.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].GmtModified");

					vpcItem_vSwitchs.Add(vSwitch);
				}
				vpcItem.VSwitchs = vpcItem_vSwitchs;

				vpcs_vpc.Add(vpcItem);
			}
			vpcs.Vpc = vpcs_vpc;
			describeRdsVpcsResponse.Vpcs = vpcs;
        
			return describeRdsVpcsResponse;
        }
    }
}