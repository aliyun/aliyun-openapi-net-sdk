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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeInstanceTagsResponseUnmarshaller
    {
        public static DescribeInstanceTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceTagsResponse describeInstanceTagsResponse = new DescribeInstanceTagsResponse();

			describeInstanceTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceTagsResponse.RequestId = _ctx.StringValue("DescribeInstanceTags.RequestId");

			List<DescribeInstanceTagsResponse.DescribeInstanceTags_TagResourcesItem> describeInstanceTagsResponse_tagResources = new List<DescribeInstanceTagsResponse.DescribeInstanceTags_TagResourcesItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceTags.TagResources.Length"); i++) {
				DescribeInstanceTagsResponse.DescribeInstanceTags_TagResourcesItem tagResourcesItem = new DescribeInstanceTagsResponse.DescribeInstanceTags_TagResourcesItem();
				tagResourcesItem.ResourceId = _ctx.StringValue("DescribeInstanceTags.TagResources["+ i +"].ResourceId");
				tagResourcesItem.ResourceType = _ctx.StringValue("DescribeInstanceTags.TagResources["+ i +"].ResourceType");
				tagResourcesItem.Tag = _ctx.StringValue("DescribeInstanceTags.TagResources["+ i +"].Tag");

				describeInstanceTagsResponse_tagResources.Add(tagResourcesItem);
			}
			describeInstanceTagsResponse.TagResources = describeInstanceTagsResponse_tagResources;
        
			return describeInstanceTagsResponse;
        }
    }
}
