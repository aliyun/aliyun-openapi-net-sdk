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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnUserTagsResponseUnmarshaller
    {
        public static DescribeDcdnUserTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnUserTagsResponse describeDcdnUserTagsResponse = new DescribeDcdnUserTagsResponse();

			describeDcdnUserTagsResponse.HttpResponse = context.HttpResponse;
			describeDcdnUserTagsResponse.RequestId = context.StringValue("DescribeDcdnUserTags.RequestId");

			List<DescribeDcdnUserTagsResponse.DescribeDcdnUserTags_Tag> describeDcdnUserTagsResponse_tags = new List<DescribeDcdnUserTagsResponse.DescribeDcdnUserTags_Tag>();
			for (int i = 0; i < context.Length("DescribeDcdnUserTags.Tags.Length"); i++) {
				DescribeDcdnUserTagsResponse.DescribeDcdnUserTags_Tag tag = new DescribeDcdnUserTagsResponse.DescribeDcdnUserTags_Tag();
				tag.Key = context.StringValue("DescribeDcdnUserTags.Tags["+ i +"].Key");

				List<string> tag_value = new List<string>();
				for (int j = 0; j < context.Length("DescribeDcdnUserTags.Tags["+ i +"].Value.Length"); j++) {
					tag_value.Add(context.StringValue("DescribeDcdnUserTags.Tags["+ i +"].Value["+ j +"]"));
				}
				tag._Value = tag_value;

				describeDcdnUserTagsResponse_tags.Add(tag);
			}
			describeDcdnUserTagsResponse.Tags = describeDcdnUserTagsResponse_tags;
        
			return describeDcdnUserTagsResponse;
        }
    }
}
