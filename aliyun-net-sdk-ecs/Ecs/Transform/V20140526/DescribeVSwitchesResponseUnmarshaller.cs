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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeVSwitchesResponseUnmarshaller
    {
        public static DescribeVSwitchesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVSwitchesResponse describeVSwitchesResponse = new DescribeVSwitchesResponse();

			describeVSwitchesResponse.HttpResponse = _ctx.HttpResponse;
			describeVSwitchesResponse.PageSize = _ctx.IntegerValue("DescribeVSwitches.PageSize");
			describeVSwitchesResponse.RequestId = _ctx.StringValue("DescribeVSwitches.RequestId");
			describeVSwitchesResponse.PageNumber = _ctx.IntegerValue("DescribeVSwitches.PageNumber");
			describeVSwitchesResponse.TotalCount = _ctx.IntegerValue("DescribeVSwitches.TotalCount");

			List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch> describeVSwitchesResponse_vSwitches = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch>();
			for (int i = 0; i < _ctx.Length("DescribeVSwitches.VSwitches.Length"); i++) {
				DescribeVSwitchesResponse.DescribeVSwitches_VSwitch vSwitch = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch();
				vSwitch.CreationTime = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].CreationTime");
				vSwitch.Status = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Status");
				vSwitch.VpcId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].VpcId");
				vSwitch.IsDefault = _ctx.BooleanValue("DescribeVSwitches.VSwitches["+ i +"].IsDefault");
				vSwitch.VSwitchId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].VSwitchId");
				vSwitch.CidrBlock = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].CidrBlock");
				vSwitch.Description = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Description");
				vSwitch.AvailableIpAddressCount = _ctx.LongValue("DescribeVSwitches.VSwitches["+ i +"].AvailableIpAddressCount");
				vSwitch.ResourceGroupId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].ResourceGroupId");
				vSwitch.ZoneId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].ZoneId");
				vSwitch.VSwitchName = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].VSwitchName");

				describeVSwitchesResponse_vSwitches.Add(vSwitch);
			}
			describeVSwitchesResponse.VSwitches = describeVSwitchesResponse_vSwitches;
        
			return describeVSwitchesResponse;
        }
    }
}
