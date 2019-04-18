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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRdsVSwitchsResponseUnmarshaller
    {
        public static DescribeRdsVSwitchsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRdsVSwitchsResponse describeRdsVSwitchsResponse = new DescribeRdsVSwitchsResponse();

			describeRdsVSwitchsResponse.HttpResponse = context.HttpResponse;
			describeRdsVSwitchsResponse.RequestId = context.StringValue("DescribeRdsVSwitchs.RequestId");

			DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches vSwitches = new DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches();

			List<DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem> vSwitches_vSwitch = new List<DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem>();
			for (int i = 0; i < context.Length("DescribeRdsVSwitchs.VSwitches.VSwitch.Length"); i++) {
				DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem vSwitchItem = new DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem();
				vSwitchItem.VSwitchId = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].VSwitchId");
				vSwitchItem.VSwitchName = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].VSwitchName");
				vSwitchItem.IzNo = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].IzNo");
				vSwitchItem.Bid = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].Bid");
				vSwitchItem.AliUid = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].AliUid");
				vSwitchItem.RegionNo = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].RegionNo");
				vSwitchItem.CidrBlock = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].CidrBlock");
				vSwitchItem.IsDefault = context.BooleanValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].IsDefault");
				vSwitchItem.Status = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].Status");
				vSwitchItem.GmtCreate = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].GmtCreate");
				vSwitchItem.GmtModified = context.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].GmtModified");

				vSwitches_vSwitch.Add(vSwitchItem);
			}
			vSwitches.VSwitch = vSwitches_vSwitch;
			describeRdsVSwitchsResponse.VSwitches = vSwitches;
        
			return describeRdsVSwitchsResponse;
        }
    }
}
