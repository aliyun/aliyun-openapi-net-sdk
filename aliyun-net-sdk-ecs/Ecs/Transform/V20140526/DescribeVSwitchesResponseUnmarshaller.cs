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
        public static DescribeVSwitchesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVSwitchesResponse describeVSwitchesResponse = new DescribeVSwitchesResponse();

			describeVSwitchesResponse.HttpResponse = context.HttpResponse;
			describeVSwitchesResponse.RequestId = context.StringValue("DescribeVSwitches.RequestId");
			describeVSwitchesResponse.TotalCount = context.IntegerValue("DescribeVSwitches.TotalCount");
			describeVSwitchesResponse.PageNumber = context.IntegerValue("DescribeVSwitches.PageNumber");
			describeVSwitchesResponse.PageSize = context.IntegerValue("DescribeVSwitches.PageSize");

			List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch> describeVSwitchesResponse_vSwitches = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch>();
			for (int i = 0; i < context.Length("DescribeVSwitches.VSwitches.Length"); i++) {
				DescribeVSwitchesResponse.DescribeVSwitches_VSwitch vSwitch = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch();
				vSwitch.VSwitchId = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].VSwitchId");
				vSwitch.VpcId = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].VpcId");
				vSwitch.Status = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].Status");
				vSwitch.CidrBlock = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].CidrBlock");
				vSwitch.ZoneId = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].ZoneId");
				vSwitch.AvailableIpAddressCount = context.LongValue("DescribeVSwitches.VSwitches["+ i +"].AvailableIpAddressCount");
				vSwitch.Description = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].Description");
				vSwitch.VSwitchName = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].VSwitchName");
				vSwitch.CreationTime = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].CreationTime");
				vSwitch.IsDefault = context.BooleanValue("DescribeVSwitches.VSwitches["+ i +"].IsDefault");
				vSwitch.ResourceGroupId = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].ResourceGroupId");

				describeVSwitchesResponse_vSwitches.Add(vSwitch);
			}
			describeVSwitchesResponse.VSwitches = describeVSwitchesResponse_vSwitches;
        
			return describeVSwitchesResponse;
        }
    }
}
