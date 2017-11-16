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
    public class DescribeVSwitchAttributesResponseUnmarshaller
    {
        public static DescribeVSwitchAttributesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVSwitchAttributesResponse describeVSwitchAttributesResponse = new DescribeVSwitchAttributesResponse();

			describeVSwitchAttributesResponse.HttpResponse = context.HttpResponse;
			describeVSwitchAttributesResponse.RequestId = context.StringValue("DescribeVSwitchAttributes.RequestId");
			describeVSwitchAttributesResponse.VSwitchId = context.StringValue("DescribeVSwitchAttributes.VSwitchId");
			describeVSwitchAttributesResponse.VpcId = context.StringValue("DescribeVSwitchAttributes.VpcId");
			describeVSwitchAttributesResponse.Status = context.StringValue("DescribeVSwitchAttributes.Status");
			describeVSwitchAttributesResponse.CidrBlock = context.StringValue("DescribeVSwitchAttributes.CidrBlock");
			describeVSwitchAttributesResponse.ZoneId = context.StringValue("DescribeVSwitchAttributes.ZoneId");
			describeVSwitchAttributesResponse.AvailableIpAddressCount = context.LongValue("DescribeVSwitchAttributes.AvailableIpAddressCount");
			describeVSwitchAttributesResponse.Description = context.StringValue("DescribeVSwitchAttributes.Description");
			describeVSwitchAttributesResponse.VSwitchName = context.StringValue("DescribeVSwitchAttributes.VSwitchName");
			describeVSwitchAttributesResponse.CreationTime = context.StringValue("DescribeVSwitchAttributes.CreationTime");
			describeVSwitchAttributesResponse.IsDefault = context.BooleanValue("DescribeVSwitchAttributes.IsDefault");

			List<DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType> describeVSwitchAttributesResponse_cloudResources = new List<DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType>();
			for (int i = 0; i < context.Length("DescribeVSwitchAttributes.CloudResources.Length"); i++) {
				DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType cloudResourceSetType = new DescribeVSwitchAttributesResponse.DescribeVSwitchAttributes_CloudResourceSetType();
				cloudResourceSetType.ResourceType = context.StringValue("DescribeVSwitchAttributes.CloudResources["+ i +"].ResourceType");
				cloudResourceSetType.ResourceCount = context.IntegerValue("DescribeVSwitchAttributes.CloudResources["+ i +"].ResourceCount");

				describeVSwitchAttributesResponse_cloudResources.Add(cloudResourceSetType);
			}
			describeVSwitchAttributesResponse.CloudResources = describeVSwitchAttributesResponse_cloudResources;
        
			return describeVSwitchAttributesResponse;
        }
    }
}