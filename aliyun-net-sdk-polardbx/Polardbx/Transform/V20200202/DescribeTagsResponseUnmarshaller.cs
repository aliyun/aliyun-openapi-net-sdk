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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse();

			describeTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeTagsResponse.RequestId = _ctx.StringValue("DescribeTags.RequestId");

			List<DescribeTagsResponse.DescribeTags_TagInfo> describeTagsResponse_tagInfos = new List<DescribeTagsResponse.DescribeTags_TagInfo>();
			for (int i = 0; i < _ctx.Length("DescribeTags.TagInfos.Length"); i++) {
				DescribeTagsResponse.DescribeTags_TagInfo tagInfo = new DescribeTagsResponse.DescribeTags_TagInfo();
				tagInfo.TagKey = _ctx.StringValue("DescribeTags.TagInfos["+ i +"].TagKey");
				tagInfo.TagValue = _ctx.StringValue("DescribeTags.TagInfos["+ i +"].TagValue");

				List<string> tagInfo_dBInstanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeTags.TagInfos["+ i +"].DBInstanceIds.Length"); j++) {
					tagInfo_dBInstanceIds.Add(_ctx.StringValue("DescribeTags.TagInfos["+ i +"].DBInstanceIds["+ j +"]"));
				}
				tagInfo.DBInstanceIds = tagInfo_dBInstanceIds;

				describeTagsResponse_tagInfos.Add(tagInfo);
			}
			describeTagsResponse.TagInfos = describeTagsResponse_tagInfos;
        
			return describeTagsResponse;
        }
    }
}
