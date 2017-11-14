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
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse();

			describeTagsResponse.HttpResponse = context.HttpResponse;
			describeTagsResponse.RequestId = context.StringValue("DescribeTags.RequestId");
			describeTagsResponse.PageSize = context.IntegerValue("DescribeTags.PageSize");
			describeTagsResponse.PageNumber = context.IntegerValue("DescribeTags.PageNumber");
			describeTagsResponse.TotalCount = context.IntegerValue("DescribeTags.TotalCount");

			List<DescribeTagsResponse.DescribeTags_TagSet> describeTagsResponse_tagSets = new List<DescribeTagsResponse.DescribeTags_TagSet>();
			for (int i = 0; i < context.Length("DescribeTags.TagSets.Length"); i++) {
				DescribeTagsResponse.DescribeTags_TagSet tagSet = new DescribeTagsResponse.DescribeTags_TagSet();
				tagSet.TagKey = context.StringValue("DescribeTags.TagSets["+ i +"].TagKey");
				tagSet.TagValue = context.StringValue("DescribeTags.TagSets["+ i +"].TagValue");
				tagSet.InstanceCount = context.IntegerValue("DescribeTags.TagSets["+ i +"].InstanceCount");

				describeTagsResponse_tagSets.Add(tagSet);
			}
			describeTagsResponse.TagSets = describeTagsResponse_tagSets;
        
			return describeTagsResponse;
        }
    }
}