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
    public class TaggingImageResponseUnmarshaller
    {
        public static TaggingImageResponse Unmarshall(UnmarshallerContext context)
        {
			TaggingImageResponse taggingImageResponse = new TaggingImageResponse();

			taggingImageResponse.HttpResponse = context.HttpResponse;
			taggingImageResponse.RequestId = context.StringValue("TaggingImage.RequestId");

			TaggingImageResponse.TaggingImage_Data data = new TaggingImageResponse.TaggingImage_Data();

			List<TaggingImageResponse.TaggingImage_Data.TaggingImage_Tag> data_tags = new List<TaggingImageResponse.TaggingImage_Data.TaggingImage_Tag>();
			for (int i = 0; i < context.Length("TaggingImage.Data.Tags.Length"); i++) {
				TaggingImageResponse.TaggingImage_Data.TaggingImage_Tag tag = new TaggingImageResponse.TaggingImage_Data.TaggingImage_Tag();
				tag.Confidence = context.FloatValue("TaggingImage.Data.Tags["+ i +"].Confidence");
				tag._Value = context.StringValue("TaggingImage.Data.Tags["+ i +"].Value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;
			taggingImageResponse.Data = data;
        
			return taggingImageResponse;
        }
    }
}
