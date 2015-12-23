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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeResourceByTagsResponseUnmarshaller
    {
        public static DescribeResourceByTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResourceByTagsResponse describeResourceByTagsResponse = new DescribeResourceByTagsResponse();

			describeResourceByTagsResponse.HttpResponse = context.HttpResponse;
			describeResourceByTagsResponse.RequestId = context.StringValue("DescribeResourceByTags.RequestId");
			describeResourceByTagsResponse.PageSize = context.IntegerValue("DescribeResourceByTags.PageSize");
			describeResourceByTagsResponse.PageNumber = context.IntegerValue("DescribeResourceByTags.PageNumber");
			describeResourceByTagsResponse.TotalCount = context.IntegerValue("DescribeResourceByTags.TotalCount");

			List<DescribeResourceByTagsResponse.Resource> resources = new List<DescribeResourceByTagsResponse.Resource>();
			for (int i = 0; i < context.Length("DescribeResourceByTags.Resources.Length"); i++) {
				DescribeResourceByTagsResponse.Resource resource = new DescribeResourceByTagsResponse.Resource();
				resource.ResourceId = context.StringValue("DescribeResourceByTags.Resources["+ i +"].ResourceId");
				resource.ResourceType = context.StringValue("DescribeResourceByTags.Resources["+ i +"].ResourceType");
				resource.RegionId = context.StringValue("DescribeResourceByTags.Resources["+ i +"].RegionId");

				resources.Add(resource);
			}
			describeResourceByTagsResponse.Resources = resources;
        
			return describeResourceByTagsResponse;
        }
    }
}