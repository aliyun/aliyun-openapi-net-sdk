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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse();

			describeTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeTagsResponse.RequestId = _ctx.StringValue("DescribeTags.RequestId");

			List<DescribeTagsResponse.DescribeTags_TagInfos> describeTagsResponse_items = new List<DescribeTagsResponse.DescribeTags_TagInfos>();
			for (int i = 0; i < _ctx.Length("DescribeTags.Items.Length"); i++) {
				DescribeTagsResponse.DescribeTags_TagInfos tagInfos = new DescribeTagsResponse.DescribeTags_TagInfos();
				tagInfos.TagKey = _ctx.StringValue("DescribeTags.Items["+ i +"].TagKey");
				tagInfos.TagValue = _ctx.StringValue("DescribeTags.Items["+ i +"].TagValue");

				List<string> tagInfos_dBInstanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeTags.Items["+ i +"].DBInstanceIds.Length"); j++) {
					tagInfos_dBInstanceIds.Add(_ctx.StringValue("DescribeTags.Items["+ i +"].DBInstanceIds["+ j +"]"));
				}
				tagInfos.DBInstanceIds = tagInfos_dBInstanceIds;

				describeTagsResponse_items.Add(tagInfos);
			}
			describeTagsResponse.Items = describeTagsResponse_items;
        
			return describeTagsResponse;
        }
    }
}
