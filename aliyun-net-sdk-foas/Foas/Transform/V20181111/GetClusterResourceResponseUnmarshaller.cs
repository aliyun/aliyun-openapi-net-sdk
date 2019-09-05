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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class GetClusterResourceResponseUnmarshaller
    {
        public static GetClusterResourceResponse Unmarshall(UnmarshallerContext context)
        {
			GetClusterResourceResponse getClusterResourceResponse = new GetClusterResourceResponse();

			getClusterResourceResponse.HttpResponse = context.HttpResponse;
			getClusterResourceResponse.RequestId = context.StringValue("GetClusterResource.RequestId");

			GetClusterResourceResponse.GetClusterResource_Resource resource = new GetClusterResourceResponse.GetClusterResource_Resource();
			resource.TotalMB = context.LongValue("GetClusterResource.Resource.TotalMB");
			resource.AllocatedMB = context.LongValue("GetClusterResource.Resource.AllocatedMB");
			resource.AvailableMB = context.LongValue("GetClusterResource.Resource.AvailableMB");
			resource.TotalVirtualCores = context.LongValue("GetClusterResource.Resource.TotalVirtualCores");
			resource.AllocatedVirtualCores = context.LongValue("GetClusterResource.Resource.AllocatedVirtualCores");
			resource.AvailableVirtualCores = context.LongValue("GetClusterResource.Resource.AvailableVirtualCores");
			getClusterResourceResponse.Resource = resource;
        
			return getClusterResourceResponse;
        }
    }
}
