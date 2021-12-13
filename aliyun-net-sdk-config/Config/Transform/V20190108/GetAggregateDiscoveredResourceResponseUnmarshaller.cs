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
    public class GetAggregateDiscoveredResourceResponseUnmarshaller
    {
        public static GetAggregateDiscoveredResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAggregateDiscoveredResourceResponse getAggregateDiscoveredResourceResponse = new GetAggregateDiscoveredResourceResponse();

			getAggregateDiscoveredResourceResponse.HttpResponse = _ctx.HttpResponse;
			getAggregateDiscoveredResourceResponse.RequestId = _ctx.StringValue("GetAggregateDiscoveredResource.RequestId");

			GetAggregateDiscoveredResourceResponse.GetAggregateDiscoveredResource_DiscoveredResourceDetail discoveredResourceDetail = new GetAggregateDiscoveredResourceResponse.GetAggregateDiscoveredResource_DiscoveredResourceDetail();
			discoveredResourceDetail.AvailabilityZone = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.AvailabilityZone");
			discoveredResourceDetail.ResourceType = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.ResourceType");
			discoveredResourceDetail.Configuration = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.Configuration");
			discoveredResourceDetail.Region = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.Region");
			discoveredResourceDetail.ResourceCreationTime = _ctx.LongValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.ResourceCreationTime");
			discoveredResourceDetail.Tags = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.Tags");
			discoveredResourceDetail.AccountId = _ctx.LongValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.AccountId");
			discoveredResourceDetail.ResourceId = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.ResourceId");
			discoveredResourceDetail.ResourceDeleted = _ctx.IntegerValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.ResourceDeleted");
			discoveredResourceDetail.ResourceName = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.ResourceName");
			discoveredResourceDetail.ResourceStatus = _ctx.StringValue("GetAggregateDiscoveredResource.DiscoveredResourceDetail.ResourceStatus");
			getAggregateDiscoveredResourceResponse.DiscoveredResourceDetail = discoveredResourceDetail;
        
			return getAggregateDiscoveredResourceResponse;
        }
    }
}
