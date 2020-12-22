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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeAvailableResourceResponseUnmarshaller
    {
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableResourceResponse.RequestId = _ctx.StringValue("DescribeAvailableResource.RequestId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource> describeAvailableResourceResponse_availableResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableResource.AvailableResources.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource availableResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource();
				availableResource.MasterZoneId = _ctx.StringValue("DescribeAvailableResource.AvailableResources["+ i +"].MasterZoneId");
				availableResource.SlaveZoneId = _ctx.StringValue("DescribeAvailableResource.AvailableResources["+ i +"].SlaveZoneId");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportResource> availableResource_supportResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportResource>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResource.AvailableResources["+ i +"].SupportResources.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportResource supportResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportResource();
					supportResource.AddressType = _ctx.StringValue("DescribeAvailableResource.AvailableResources["+ i +"].SupportResources["+ j +"].AddressType");
					supportResource.AddressIPVersion = _ctx.StringValue("DescribeAvailableResource.AvailableResources["+ i +"].SupportResources["+ j +"].AddressIPVersion");

					availableResource_supportResources.Add(supportResource);
				}
				availableResource.SupportResources = availableResource_supportResources;

				describeAvailableResourceResponse_availableResources.Add(availableResource);
			}
			describeAvailableResourceResponse.AvailableResources = describeAvailableResourceResponse_availableResources;
        
			return describeAvailableResourceResponse;
        }
    }
}
