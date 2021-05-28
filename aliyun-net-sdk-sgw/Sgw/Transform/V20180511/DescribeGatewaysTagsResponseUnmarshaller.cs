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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewaysTagsResponseUnmarshaller
    {
        public static DescribeGatewaysTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewaysTagsResponse describeGatewaysTagsResponse = new DescribeGatewaysTagsResponse();

			describeGatewaysTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewaysTagsResponse.RequestId = _ctx.StringValue("DescribeGatewaysTags.RequestId");
			describeGatewaysTagsResponse.Success = _ctx.BooleanValue("DescribeGatewaysTags.Success");
			describeGatewaysTagsResponse.Code = _ctx.StringValue("DescribeGatewaysTags.Code");
			describeGatewaysTagsResponse.Message = _ctx.StringValue("DescribeGatewaysTags.Message");

			List<DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag> describeGatewaysTagsResponse_gatewayTags = new List<DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag>();
			for (int i = 0; i < _ctx.Length("DescribeGatewaysTags.GatewayTags.Length"); i++) {
				DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag gatewayTag = new DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag();
				gatewayTag.GatewayId = _ctx.StringValue("DescribeGatewaysTags.GatewayTags["+ i +"].GatewayId");

				List<DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag.DescribeGatewaysTags_Tag> gatewayTag_tags = new List<DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag.DescribeGatewaysTags_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeGatewaysTags.GatewayTags["+ i +"].Tags.Length"); j++) {
					DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag.DescribeGatewaysTags_Tag tag = new DescribeGatewaysTagsResponse.DescribeGatewaysTags_GatewayTag.DescribeGatewaysTags_Tag();
					tag.TagKey = _ctx.StringValue("DescribeGatewaysTags.GatewayTags["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeGatewaysTags.GatewayTags["+ i +"].Tags["+ j +"].TagValue");

					gatewayTag_tags.Add(tag);
				}
				gatewayTag.Tags = gatewayTag_tags;

				describeGatewaysTagsResponse_gatewayTags.Add(gatewayTag);
			}
			describeGatewaysTagsResponse.GatewayTags = describeGatewaysTagsResponse_gatewayTags;
        
			return describeGatewaysTagsResponse;
        }
    }
}
