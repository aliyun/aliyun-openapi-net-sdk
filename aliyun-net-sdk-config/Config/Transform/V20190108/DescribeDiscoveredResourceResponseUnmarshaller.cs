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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class DescribeDiscoveredResourceResponseUnmarshaller
    {
        public static DescribeDiscoveredResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDiscoveredResourceResponse describeDiscoveredResourceResponse = new DescribeDiscoveredResourceResponse();

			describeDiscoveredResourceResponse.HttpResponse = context.HttpResponse;
			describeDiscoveredResourceResponse.RequestId = context.StringValue("DescribeDiscoveredResource.RequestId");

			DescribeDiscoveredResourceResponse.DescribeDiscoveredResource_DiscoveredResourceDetail discoveredResourceDetail = new DescribeDiscoveredResourceResponse.DescribeDiscoveredResource_DiscoveredResourceDetail();
			discoveredResourceDetail.AccountId = context.LongValue("DescribeDiscoveredResource.DiscoveredResourceDetail.AccountId");
			discoveredResourceDetail.ResourceId = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.ResourceId");
			discoveredResourceDetail.ResourceType = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.ResourceType");
			discoveredResourceDetail.ResourceName = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.ResourceName");
			discoveredResourceDetail.Region = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.Region");
			discoveredResourceDetail.AvailabilityZone = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.AvailabilityZone");
			discoveredResourceDetail.ResourceCreationTime = context.LongValue("DescribeDiscoveredResource.DiscoveredResourceDetail.ResourceCreationTime");
			discoveredResourceDetail.ResourceStatus = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.ResourceStatus");
			discoveredResourceDetail.ResourceDeleted = context.IntegerValue("DescribeDiscoveredResource.DiscoveredResourceDetail.ResourceDeleted");
			discoveredResourceDetail.Tags = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.Tags");
			discoveredResourceDetail.Configuration = context.StringValue("DescribeDiscoveredResource.DiscoveredResourceDetail.Configuration");
			describeDiscoveredResourceResponse.DiscoveredResourceDetail = discoveredResourceDetail;
        
			return describeDiscoveredResourceResponse;
        }
    }
}
