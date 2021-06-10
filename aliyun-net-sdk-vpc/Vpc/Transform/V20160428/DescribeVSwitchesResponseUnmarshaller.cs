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

			List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch> describeVSwitchesResponse_vSwitches = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch>();
			for (int i = 0; i < _ctx.Length("DescribeVSwitches.VSwitches.Length"); i++) {
				DescribeVSwitchesResponse.DescribeVSwitches_VSwitch vSwitch = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch();
				vSwitch.VSwitchId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].VSwitchId");
				vSwitch.VpcId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].VpcId");
				vSwitch.Status = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Status");
				vSwitch.CidrBlock = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].CidrBlock");
				vSwitch.Ipv6CidrBlock = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Ipv6CidrBlock");
				vSwitch.ZoneId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].ZoneId");
				vSwitch.AvailableIpAddressCount = _ctx.LongValue("DescribeVSwitches.VSwitches["+ i +"].AvailableIpAddressCount");
				vSwitch.Description = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Description");
				vSwitch.VSwitchName = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].VSwitchName");
				vSwitch.CreationTime = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].CreationTime");
				vSwitch.IsDefault = _ctx.BooleanValue("DescribeVSwitches.VSwitches["+ i +"].IsDefault");
				vSwitch.ResourceGroupId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].ResourceGroupId");
				vSwitch.NetworkAclId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].NetworkAclId");
				vSwitch.OwnerId = _ctx.LongValue("DescribeVSwitches.VSwitches["+ i +"].OwnerId");
				vSwitch.ShareType = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].ShareType");

				DescribeVSwitchesResponse.DescribeVSwitches_VSwitch.DescribeVSwitches_RouteTable routeTable = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch.DescribeVSwitches_RouteTable();
				routeTable.RouteTableId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].RouteTable.RouteTableId");
				routeTable.RouteTableType = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].RouteTable.RouteTableType");
				vSwitch.RouteTable = routeTable;

				List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch.DescribeVSwitches_Tag> vSwitch_tags = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch.DescribeVSwitches_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeVSwitches.VSwitches["+ i +"].Tags.Length"); j++) {
					DescribeVSwitchesResponse.DescribeVSwitches_VSwitch.DescribeVSwitches_Tag tag = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch.DescribeVSwitches_Tag();
					tag.Key = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Tags["+ j +"].Value");

					vSwitch_tags.Add(tag);
				}
				vSwitch.Tags = vSwitch_tags;

				describeVSwitchesResponse_vSwitches.Add(vSwitch);
			}
			describeVSwitchesResponse.VSwitches = describeVSwitchesResponse_vSwitches;
        
			return describeVSwitchesResponse;
        }
    }
}
