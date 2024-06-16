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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeVSwitchesResponseUnmarshaller
    {
        public static DescribeVSwitchesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVSwitchesResponse describeVSwitchesResponse = new DescribeVSwitchesResponse();

			describeVSwitchesResponse.HttpResponse = _ctx.HttpResponse;
			describeVSwitchesResponse.RequestId = _ctx.StringValue("DescribeVSwitches.RequestId");
			describeVSwitchesResponse.TotalCount = _ctx.IntegerValue("DescribeVSwitches.TotalCount");
			describeVSwitchesResponse.PageNumber = _ctx.IntegerValue("DescribeVSwitches.PageNumber");
			describeVSwitchesResponse.PageSize = _ctx.IntegerValue("DescribeVSwitches.PageSize");

			List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch> describeVSwitchesResponse_vSwitchs = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch>();
			for (int i = 0; i < _ctx.Length("DescribeVSwitches.VSwitchs.Length"); i++) {
				DescribeVSwitchesResponse.DescribeVSwitches_VSwitch vSwitch = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch();
				vSwitch.AliUid = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].AliUid");
				vSwitch.Bid = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].Bid");
				vSwitch.CidrBlock = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].CidrBlock");
				vSwitch.Description = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].Description");
				vSwitch.GmtCreate = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].GmtCreate");
				vSwitch.GmtModified = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].GmtModified");
				vSwitch.IsDefault = _ctx.BooleanValue("DescribeVSwitches.VSwitchs["+ i +"].IsDefault");
				vSwitch.IzNo = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].IzNo");
				vSwitch.RegionNo = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].RegionNo");
				vSwitch.Status = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].Status");
				vSwitch.VSwitchId = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].VSwitchId");
				vSwitch.VSwitchName = _ctx.StringValue("DescribeVSwitches.VSwitchs["+ i +"].VSwitchName");
				vSwitch.AvailableIpAddressCount = _ctx.LongValue("DescribeVSwitches.VSwitchs["+ i +"].AvailableIpAddressCount");

				describeVSwitchesResponse_vSwitchs.Add(vSwitch);
			}
			describeVSwitchesResponse.VSwitchs = describeVSwitchesResponse_vSwitchs;
        
			return describeVSwitchesResponse;
        }
    }
}
