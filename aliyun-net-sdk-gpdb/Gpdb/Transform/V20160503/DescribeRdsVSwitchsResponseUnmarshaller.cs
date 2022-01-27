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
    public class DescribeRdsVSwitchsResponseUnmarshaller
    {
        public static DescribeRdsVSwitchsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRdsVSwitchsResponse describeRdsVSwitchsResponse = new DescribeRdsVSwitchsResponse();

			describeRdsVSwitchsResponse.HttpResponse = _ctx.HttpResponse;
			describeRdsVSwitchsResponse.RequestId = _ctx.StringValue("DescribeRdsVSwitchs.RequestId");

			DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches vSwitches = new DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches();

			List<DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem> vSwitches_vSwitch = new List<DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem>();
			for (int i = 0; i < _ctx.Length("DescribeRdsVSwitchs.VSwitches.VSwitch.Length"); i++) {
				DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem vSwitchItem = new DescribeRdsVSwitchsResponse.DescribeRdsVSwitchs_VSwitches.DescribeRdsVSwitchs_VSwitchItem();
				vSwitchItem.Status = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].Status");
				vSwitchItem.IsDefault = _ctx.BooleanValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].IsDefault");
				vSwitchItem.VSwitchId = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].VSwitchId");
				vSwitchItem.CidrBlock = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].CidrBlock");
				vSwitchItem.RegionNo = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].RegionNo");
				vSwitchItem.GmtCreate = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].GmtCreate");
				vSwitchItem.AliUid = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].AliUid");
				vSwitchItem.GmtModified = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].GmtModified");
				vSwitchItem.Bid = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].Bid");
				vSwitchItem.IzNo = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].IzNo");
				vSwitchItem.VSwitchName = _ctx.StringValue("DescribeRdsVSwitchs.VSwitches.VSwitch["+ i +"].VSwitchName");

				vSwitches_vSwitch.Add(vSwitchItem);
			}
			vSwitches.VSwitch = vSwitches_vSwitch;
			describeRdsVSwitchsResponse.VSwitches = vSwitches;
        
			return describeRdsVSwitchsResponse;
        }
    }
}
