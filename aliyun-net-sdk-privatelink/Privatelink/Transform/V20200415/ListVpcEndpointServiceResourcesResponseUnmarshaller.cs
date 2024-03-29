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
using Aliyun.Acs.Privatelink.Model.V20200415;

namespace Aliyun.Acs.Privatelink.Transform.V20200415
{
    public class ListVpcEndpointServiceResourcesResponseUnmarshaller
    {
        public static ListVpcEndpointServiceResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointServiceResourcesResponse listVpcEndpointServiceResourcesResponse = new ListVpcEndpointServiceResourcesResponse();

			listVpcEndpointServiceResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointServiceResourcesResponse.NextToken = _ctx.StringValue("ListVpcEndpointServiceResources.NextToken");
			listVpcEndpointServiceResourcesResponse.RequestId = _ctx.StringValue("ListVpcEndpointServiceResources.RequestId");
			listVpcEndpointServiceResourcesResponse.MaxResults = _ctx.StringValue("ListVpcEndpointServiceResources.MaxResults");

			List<ListVpcEndpointServiceResourcesResponse.ListVpcEndpointServiceResources_Resource> listVpcEndpointServiceResourcesResponse_resources = new List<ListVpcEndpointServiceResourcesResponse.ListVpcEndpointServiceResources_Resource>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointServiceResources.Resources.Length"); i++) {
				ListVpcEndpointServiceResourcesResponse.ListVpcEndpointServiceResources_Resource resource = new ListVpcEndpointServiceResourcesResponse.ListVpcEndpointServiceResources_Resource();
				resource.VpcId = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].VpcId");
				resource.VSwitchId = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].VSwitchId");
				resource.ResourceType = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].ResourceType");
				resource.ZoneId = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].ZoneId");
				resource.Ip = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].Ip");
				resource.ResourceId = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].ResourceId");
				resource.RegionId = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].RegionId");
				resource.RelatedEndpointCount = _ctx.LongValue("ListVpcEndpointServiceResources.Resources["+ i +"].RelatedEndpointCount");
				resource.RelatedDeprecatedEndpointCount = _ctx.LongValue("ListVpcEndpointServiceResources.Resources["+ i +"].RelatedDeprecatedEndpointCount");
				resource.AutoAllocatedEnabled = _ctx.BooleanValue("ListVpcEndpointServiceResources.Resources["+ i +"].AutoAllocatedEnabled");
				resource.StatusInfo = _ctx.StringValue("ListVpcEndpointServiceResources.Resources["+ i +"].StatusInfo");

				listVpcEndpointServiceResourcesResponse_resources.Add(resource);
			}
			listVpcEndpointServiceResourcesResponse.Resources = listVpcEndpointServiceResourcesResponse_resources;
        
			return listVpcEndpointServiceResourcesResponse;
        }
    }
}
