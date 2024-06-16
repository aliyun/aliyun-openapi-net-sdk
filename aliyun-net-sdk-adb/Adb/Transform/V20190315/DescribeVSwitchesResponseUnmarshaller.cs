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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeVSwitchesResponseUnmarshaller
    {
        public static DescribeVSwitchesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVSwitchesResponse describeVSwitchesResponse = new DescribeVSwitchesResponse();

			describeVSwitchesResponse.HttpResponse = _ctx.HttpResponse;
			describeVSwitchesResponse.RequestId = _ctx.StringValue("DescribeVSwitches.RequestId");

			DescribeVSwitchesResponse.DescribeVSwitches_VSwitches vSwitches = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitches();

			List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitches.DescribeVSwitches_VSwitchItem> vSwitches_vSwitch = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitches.DescribeVSwitches_VSwitchItem>();
			for (int i = 0; i < _ctx.Length("DescribeVSwitches.VSwitches.VSwitch.Length"); i++) {
				DescribeVSwitchesResponse.DescribeVSwitches_VSwitches.DescribeVSwitches_VSwitchItem vSwitchItem = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitches.DescribeVSwitches_VSwitchItem();
				vSwitchItem.Status = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].Status");
				vSwitchItem.IsDefault = _ctx.BooleanValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].IsDefault");
				vSwitchItem.VSwitchId = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].VSwitchId");
				vSwitchItem.CidrBlock = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].CidrBlock");
				vSwitchItem.RegionNo = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].RegionNo");
				vSwitchItem.GmtCreate = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].GmtCreate");
				vSwitchItem.AliUid = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].AliUid");
				vSwitchItem.GmtModified = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].GmtModified");
				vSwitchItem.Bid = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].Bid");
				vSwitchItem.IzNo = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].IzNo");
				vSwitchItem.VSwitchName = _ctx.StringValue("DescribeVSwitches.VSwitches.VSwitch["+ i +"].VSwitchName");

				vSwitches_vSwitch.Add(vSwitchItem);
			}
			vSwitches.VSwitch = vSwitches_vSwitch;
			describeVSwitchesResponse.VSwitches = vSwitches;
        
			return describeVSwitchesResponse;
        }
    }
}
