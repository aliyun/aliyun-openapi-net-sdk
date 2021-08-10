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
using Aliyun.Acs.imagerecog.Model.V20190930;

namespace Aliyun.Acs.imagerecog.Transform.V20190930
{
    public class TaggingAdImageResponseUnmarshaller
    {
        public static TaggingAdImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TaggingAdImageResponse taggingAdImageResponse = new TaggingAdImageResponse();

			taggingAdImageResponse.HttpResponse = _ctx.HttpResponse;
			taggingAdImageResponse.RequestId = _ctx.StringValue("TaggingAdImage.RequestId");
			taggingAdImageResponse.Code = _ctx.StringValue("TaggingAdImage.Code");
			taggingAdImageResponse.Message = _ctx.StringValue("TaggingAdImage.Message");

			TaggingAdImageResponse.TaggingAdImage_Data data = new TaggingAdImageResponse.TaggingAdImage_Data();
			data.TagInfo = _ctx.StringValue("TaggingAdImage.Data.TagInfo");

			List<TaggingAdImageResponse.TaggingAdImage_Data.TaggingAdImage_TagsItem> data_tags = new List<TaggingAdImageResponse.TaggingAdImage_Data.TaggingAdImage_TagsItem>();
			for (int i = 0; i < _ctx.Length("TaggingAdImage.Data.Tags.Length"); i++) {
				TaggingAdImageResponse.TaggingAdImage_Data.TaggingAdImage_TagsItem tagsItem = new TaggingAdImageResponse.TaggingAdImage_Data.TaggingAdImage_TagsItem();
				tagsItem._Value = _ctx.StringValue("TaggingAdImage.Data.Tags["+ i +"].Value");
				tagsItem.Confidence = _ctx.FloatValue("TaggingAdImage.Data.Tags["+ i +"].Confidence");

				data_tags.Add(tagsItem);
			}
			data.Tags = data_tags;
			taggingAdImageResponse.Data = data;
        
			return taggingAdImageResponse;
        }
    }
}
