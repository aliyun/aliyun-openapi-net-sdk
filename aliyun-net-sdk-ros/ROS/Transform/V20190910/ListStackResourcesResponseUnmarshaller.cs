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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStackResourcesResponseUnmarshaller
    {
        public static ListStackResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStackResourcesResponse listStackResourcesResponse = new ListStackResourcesResponse();

			listStackResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listStackResourcesResponse.RequestId = _ctx.StringValue("ListStackResources.RequestId");

			List<ListStackResourcesResponse.ListStackResources_Resource> listStackResourcesResponse_resources = new List<ListStackResourcesResponse.ListStackResources_Resource>();
			for (int i = 0; i < _ctx.Length("ListStackResources.Resources.Length"); i++) {
				ListStackResourcesResponse.ListStackResources_Resource resource = new ListStackResourcesResponse.ListStackResources_Resource();
				resource.CreateTime = _ctx.StringValue("ListStackResources.Resources["+ i +"].CreateTime");
				resource.LogicalResourceId = _ctx.StringValue("ListStackResources.Resources["+ i +"].LogicalResourceId");
				resource.PhysicalResourceId = _ctx.StringValue("ListStackResources.Resources["+ i +"].PhysicalResourceId");
				resource.ResourceType = _ctx.StringValue("ListStackResources.Resources["+ i +"].ResourceType");
				resource.StackId = _ctx.StringValue("ListStackResources.Resources["+ i +"].StackId");
				resource.StackName = _ctx.StringValue("ListStackResources.Resources["+ i +"].StackName");
				resource.Status = _ctx.StringValue("ListStackResources.Resources["+ i +"].Status");
				resource.StatusReason = _ctx.StringValue("ListStackResources.Resources["+ i +"].StatusReason");
				resource.UpdateTime = _ctx.StringValue("ListStackResources.Resources["+ i +"].UpdateTime");
				resource.ResourceDriftStatus = _ctx.StringValue("ListStackResources.Resources["+ i +"].ResourceDriftStatus");
				resource.DriftDetectionTime = _ctx.StringValue("ListStackResources.Resources["+ i +"].DriftDetectionTime");

				listStackResourcesResponse_resources.Add(resource);
			}
			listStackResourcesResponse.Resources = listStackResourcesResponse_resources;
        
			return listStackResourcesResponse;
        }
    }
}
