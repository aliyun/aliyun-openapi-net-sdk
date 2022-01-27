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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeRdsVpcsResponseUnmarshaller
    {
        public static DescribeRdsVpcsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRdsVpcsResponse describeRdsVpcsResponse = new DescribeRdsVpcsResponse();

			describeRdsVpcsResponse.HttpResponse = _ctx.HttpResponse;
			describeRdsVpcsResponse.RequestId = _ctx.StringValue("DescribeRdsVpcs.RequestId");

			DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs vpcs = new DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs();

			List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem> vpcs_vpc = new List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem>();
			for (int i = 0; i < _ctx.Length("DescribeRdsVpcs.Vpcs.Vpc.Length"); i++) {
				DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem vpcItem = new DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem();
				vpcItem.Status = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].Status");
				vpcItem.VpcName = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VpcName");
				vpcItem.VpcId = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VpcId");
				vpcItem.IsDefault = _ctx.BooleanValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].IsDefault");
				vpcItem.CidrBlock = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].CidrBlock");
				vpcItem.RegionNo = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].RegionNo");
				vpcItem.GmtCreate = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].GmtCreate");
				vpcItem.AliUid = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].AliUid");
				vpcItem.GmtModified = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].GmtModified");
				vpcItem.Bid = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].Bid");

				List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch> vpcItem_vSwitchs = new List<DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch>();
				for (int j = 0; j < _ctx.Length("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs.Length"); j++) {
					DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch vSwitch = new DescribeRdsVpcsResponse.DescribeRdsVpcs_Vpcs.DescribeRdsVpcs_VpcItem.DescribeRdsVpcs_VSwitch();
					vSwitch.Status = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].Status");
					vSwitch.VSwitchId = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].VSwitchId");
					vSwitch.IsDefault = _ctx.BooleanValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].IsDefault");
					vSwitch.CidrBlock = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].CidrBlock");
					vSwitch.GmtCreate = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].GmtCreate");
					vSwitch.GmtModified = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].GmtModified");
					vSwitch.IzNo = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].IzNo");
					vSwitch.VSwitchName = _ctx.StringValue("DescribeRdsVpcs.Vpcs.Vpc["+ i +"].VSwitchs["+ j +"].VSwitchName");

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
