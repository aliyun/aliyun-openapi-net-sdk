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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeImageComponentsResponseUnmarshaller
    {
        public static DescribeImageComponentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageComponentsResponse describeImageComponentsResponse = new DescribeImageComponentsResponse();

			describeImageComponentsResponse.HttpResponse = _ctx.HttpResponse;
			describeImageComponentsResponse.RequestId = _ctx.StringValue("DescribeImageComponents.RequestId");
			describeImageComponentsResponse.TotalCount = _ctx.IntegerValue("DescribeImageComponents.TotalCount");
			describeImageComponentsResponse.NextToken = _ctx.StringValue("DescribeImageComponents.NextToken");
			describeImageComponentsResponse.MaxResults = _ctx.IntegerValue("DescribeImageComponents.MaxResults");

			List<DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet> describeImageComponentsResponse_imageComponent = new List<DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet>();
			for (int i = 0; i < _ctx.Length("DescribeImageComponents.ImageComponent.Length"); i++) {
				DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet imageComponentSet = new DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet();
				imageComponentSet.CreationTime = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].CreationTime");
				imageComponentSet.ImageComponentId = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].ImageComponentId");
				imageComponentSet.Name = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].Name");
				imageComponentSet.Description = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].Description");
				imageComponentSet.SystemType = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].SystemType");
				imageComponentSet.ComponentType = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].ComponentType");
				imageComponentSet.Content = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].Content");
				imageComponentSet.ResourceGroupId = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].ResourceGroupId");

				List<DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet.DescribeImageComponents_Tag> imageComponentSet_tags = new List<DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet.DescribeImageComponents_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeImageComponents.ImageComponent["+ i +"].Tags.Length"); j++) {
					DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet.DescribeImageComponents_Tag tag = new DescribeImageComponentsResponse.DescribeImageComponents_ImageComponentSet.DescribeImageComponents_Tag();
					tag.TagKey = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeImageComponents.ImageComponent["+ i +"].Tags["+ j +"].TagValue");

					imageComponentSet_tags.Add(tag);
				}
				imageComponentSet.Tags = imageComponentSet_tags;

				describeImageComponentsResponse_imageComponent.Add(imageComponentSet);
			}
			describeImageComponentsResponse.ImageComponent = describeImageComponentsResponse_imageComponent;
        
			return describeImageComponentsResponse;
        }
    }
}
