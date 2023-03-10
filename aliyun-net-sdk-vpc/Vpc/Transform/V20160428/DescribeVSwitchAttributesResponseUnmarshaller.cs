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
    public class DescribeVSwitchAttributesResponseUnmarshaller
    {
        public static DescribeVSwitchAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVSwitchAttributesResponse describeVSwitchAttributesResponse = new DescribeVSwitchAttributesResponse();

			describeVSwitchAttributesResponse.HttpResponse = _ctx.HttpResponse;
			describeVSwitchAttributesResponse.VpcId = _ctx.StringValue("DescribeVSwitchAttributes.VpcId");
			describeVSwitchAttributesResponse.Status = _ctx.StringValue("DescribeVSwitchAttributes.Status");
			describeVSwitchAttributesResponse.CreationTime = _ctx.StringValue("DescribeVSwitchAttributes.CreationTime");
			describeVSwitchAttributesResponse.IsDefault = _ctx.BooleanValue("DescribeVSwitchAttributes.IsDefault");
			describeVSwitchAttributesResponse.AvailableIpAddressCount = _ctx.LongValue("DescribeVSwitchAttributes.AvailableIpAddressCount");
			describeVSwitchAttributesResponse.NetworkAclId = _ctx.StringValue("DescribeVSwitchAttributes.NetworkAclId");
			describeVSwitchAttributesResponse.OwnerId = _ctx.LongValue("DescribeVSwitchAttributes.OwnerId");
			describeVSwitchAttributesResponse.VSwitchId = _ctx.StringValue("DescribeVSwitchAttributes.VSwitchId");
			describeVSwitchAttributesResponse.RequestId = _ctx.StringValue("DescribeVSwitchAttributes.RequestId");
			describeVSwitchAttributesResponse.CidrBlock = _ctx.StringValue("DescribeVSwitchAttributes.CidrBlock");
			describeVSwitchAttributesResponse.Description = _ctx.StringValue("DescribeVSwitchAttributes.Description");
			describeVSwitchAttributesResponse.ResourceGroupId = _ctx.StringValue("DescribeVSwitchAttributes.ResourceGroupId");
			describeVSwitchAttributesResponse.ZoneId = _ctx.StringValue("DescribeVSwitchAttributes.ZoneId");
			describeVSwitchAttributesResponse.Ipv6CidrBlock = _ctx.StringValue("DescribeVSwitchAttributes.Ipv6CidrBlock");
			describeVSwitchAttributesResponse.VSwitchName = _ctx.StringValue("DescribeVSwitchAttributes.VSwitchName");
			describeVSwitchAttributesResponse.ShareType = _ctx.StringValue("DescribeVSwitchAttributes.ShareType");

			DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_RouteTable routeTable = new DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_RouteTable();
			routeTable.RouteTableId = _ctx.StringValue("DescribeVSwitchAttributes.RouteTable.RouteTableId");
			routeTable.RouteTableType = _ctx.StringValue("DescribeVSwitchAttributes.RouteTable.RouteTableType");
			describeVSwitchAttributesResponse.RouteTable = routeTable;

			List<DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType> describeVSwitchAttributesResponse_cloudResources = new List<DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType>();
			for (int i = 0; i < _ctx.Length("DescribeVSwitchAttributes.CloudResources.Length"); i++) {
				DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType cloudResourceSetType = new DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType();
				cloudResourceSetType.ResourceCount = _ctx.IntegerValue("DescribeVSwitchAttributes.CloudResources["+ i +"].ResourceCount");
				cloudResourceSetType.ResourceType = _ctx.StringValue("DescribeVSwitchAttributes.CloudResources["+ i +"].ResourceType");

				describeVSwitchAttributesResponse_cloudResources.Add(cloudResourceSetType);
			}
			describeVSwitchAttributesResponse.CloudResources = describeVSwitchAttributesResponse_cloudResources;

			List<DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_Tag> describeVSwitchAttributesResponse_tags = new List<DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeVSwitchAttributes.Tags.Length"); i++) {
				DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_Tag tag = new DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_Tag();
				tag.Key = _ctx.StringValue("DescribeVSwitchAttributes.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeVSwitchAttributes.Tags["+ i +"].Value");

				describeVSwitchAttributesResponse_tags.Add(tag);
			}
			describeVSwitchAttributesResponse.Tags = describeVSwitchAttributesResponse_tags;
        
			return describeVSwitchAttributesResponse;
        }
    }
}
