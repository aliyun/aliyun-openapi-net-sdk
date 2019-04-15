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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectImageTagsResponseUnmarshaller
    {
        public static DetectImageTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DetectImageTagsResponse detectImageTagsResponse = new DetectImageTagsResponse();

			detectImageTagsResponse.HttpResponse = context.HttpResponse;
			detectImageTagsResponse.RequestId = context.StringValue("DetectImageTags.RequestId");
			detectImageTagsResponse.ImageUri = context.StringValue("DetectImageTags.ImageUri");

			List<DetectImageTagsResponse.DetectImageTags_TagsItem> detectImageTagsResponse_tags = new List<DetectImageTagsResponse.DetectImageTags_TagsItem>();
			for (int i = 0; i < context.Length("DetectImageTags.Tags.Length"); i++) {
				DetectImageTagsResponse.DetectImageTags_TagsItem tagsItem = new DetectImageTagsResponse.DetectImageTags_TagsItem();
				tagsItem.TagName = context.StringValue("DetectImageTags.Tags["+ i +"].TagName");
				tagsItem.TagConfidence = context.FloatValue("DetectImageTags.Tags["+ i +"].TagConfidence");
				tagsItem.TagLevel = context.IntegerValue("DetectImageTags.Tags["+ i +"].TagLevel");
				tagsItem.ParentTagName = context.StringValue("DetectImageTags.Tags["+ i +"].ParentTagName");
				tagsItem.ParentTagEnName = context.StringValue("DetectImageTags.Tags["+ i +"].ParentTagEnName");
				tagsItem.TagEnName = context.StringValue("DetectImageTags.Tags["+ i +"].TagEnName");

				detectImageTagsResponse_tags.Add(tagsItem);
			}
			detectImageTagsResponse.Tags = detectImageTagsResponse_tags;
        
			return detectImageTagsResponse;
        }
    }
}
