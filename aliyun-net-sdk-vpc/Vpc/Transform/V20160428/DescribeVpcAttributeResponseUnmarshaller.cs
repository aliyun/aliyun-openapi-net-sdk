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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVpcAttributeResponseUnmarshaller
    {
        public static DescribeVpcAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpcAttributeResponse describeVpcAttributeResponse = new DescribeVpcAttributeResponse();

			describeVpcAttributeResponse.HttpResponse = context.HttpResponse;
			describeVpcAttributeResponse.RequestId = context.StringValue("DescribeVpcAttribute.RequestId");
			describeVpcAttributeResponse.VpcId = context.StringValue("DescribeVpcAttribute.VpcId");
			describeVpcAttributeResponse.RegionId = context.StringValue("DescribeVpcAttribute.RegionId");
			describeVpcAttributeResponse.Status = context.StringValue("DescribeVpcAttribute.Status");
			describeVpcAttributeResponse.VpcName = context.StringValue("DescribeVpcAttribute.VpcName");
			describeVpcAttributeResponse.CreationTime = context.StringValue("DescribeVpcAttribute.CreationTime");
			describeVpcAttributeResponse.CidrBlock = context.StringValue("DescribeVpcAttribute.CidrBlock");
			describeVpcAttributeResponse.VRouterId = context.StringValue("DescribeVpcAttribute.VRouterId");
			describeVpcAttributeResponse.Description = context.StringValue("DescribeVpcAttribute.Description");
			describeVpcAttributeResponse.IsDefault = context.BooleanValue("DescribeVpcAttribute.IsDefault");
			describeVpcAttributeResponse.ClassicLinkEnabled = context.BooleanValue("DescribeVpcAttribute.ClassicLinkEnabled");

			List<string> describeVpcAttributeResponse_vSwitchIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeVpcAttribute.VSwitchIds.Length"); i++) {
				describeVpcAttributeResponse_vSwitchIds.Add(context.StringValue("DescribeVpcAttribute.VSwitchIds["+ i +"]"));
			}
			describeVpcAttributeResponse.VSwitchIds = describeVpcAttributeResponse_vSwitchIds;

			List<string> describeVpcAttributeResponse_userCidrs = new List<string>();
			for (int i = 0; i < context.Length("DescribeVpcAttribute.UserCidrs.Length"); i++) {
				describeVpcAttributeResponse_userCidrs.Add(context.StringValue("DescribeVpcAttribute.UserCidrs["+ i +"]"));
			}
			describeVpcAttributeResponse.UserCidrs = describeVpcAttributeResponse_userCidrs;

			List<DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType> describeVpcAttributeResponse_cloudResources = new List<DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType>();
			for (int i = 0; i < context.Length("DescribeVpcAttribute.CloudResources.Length"); i++) {
				DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType cloudResourceSetType = new DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType();
				cloudResourceSetType.ResourceType = context.StringValue("DescribeVpcAttribute.CloudResources["+ i +"].ResourceType");
				cloudResourceSetType.ResourceCount = context.IntegerValue("DescribeVpcAttribute.CloudResources["+ i +"].ResourceCount");

				describeVpcAttributeResponse_cloudResources.Add(cloudResourceSetType);
			}
			describeVpcAttributeResponse.CloudResources = describeVpcAttributeResponse_cloudResources;
        
			return describeVpcAttributeResponse;
        }
    }
}