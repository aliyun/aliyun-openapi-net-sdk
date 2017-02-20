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
using Aliyun.Acs.Mts.Model.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class AddMediaResponseUnmarshaller
    {
        public static AddMediaResponse Unmarshall(UnmarshallerContext context)
        {
            AddMediaResponse addMediaResponse = new AddMediaResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("AddMedia.RequestId")
            };
            AddMediaResponse.Media_ media = new AddMediaResponse.Media_()
            {
                MediaId = context.StringValue("AddMedia.Media.MediaId"),
                Title = context.StringValue("AddMedia.Media.Title"),
                Description = context.StringValue("AddMedia.Media.Description"),
                CoverURL = context.StringValue("AddMedia.Media.CoverURL"),
                CateId = context.LongValue("AddMedia.Media.CateId"),
                Duration = context.StringValue("AddMedia.Media.Duration"),
                Format = context.StringValue("AddMedia.Media.Format"),
                Size = context.StringValue("AddMedia.Media.Size"),
                Bitrate = context.StringValue("AddMedia.Media.Bitrate"),
                Width = context.StringValue("AddMedia.Media.Width"),
                Height = context.StringValue("AddMedia.Media.Height"),
                Fps = context.StringValue("AddMedia.Media.Fps"),
                PublishState = context.StringValue("AddMedia.Media.PublishState"),
                CreationTime = context.StringValue("AddMedia.Media.CreationTime")
            };
            List<string> tags = new List<string>();
			for (int i = 0; i < context.Length("AddMedia.Media.Tags.Length"); i++) {
				tags.Add(context.StringValue($"AddMedia.Media.Tags[{i}]"));
			}
			media.Tags = tags;

			List<string> runIdList = new List<string>();
			for (int i = 0; i < context.Length("AddMedia.Media.RunIdList.Length"); i++) {
				runIdList.Add(context.StringValue($"AddMedia.Media.RunIdList[{i}]"));
			}
			media.RunIdList = runIdList;

            AddMediaResponse.Media_.File_ file = new AddMediaResponse.Media_.File_()
            {
                URL = context.StringValue("AddMedia.Media.File.URL"),
                State = context.StringValue("AddMedia.Media.File.State")
            };
            media.File = file;
			addMediaResponse.Media = media;
        
			return addMediaResponse;
        }
    }
}