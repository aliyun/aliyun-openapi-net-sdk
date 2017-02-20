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
    public class UpdateMediaResponseUnmarshaller
    {
        public static UpdateMediaResponse Unmarshall(UnmarshallerContext context)
        {
            UpdateMediaResponse updateMediaResponse = new UpdateMediaResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("UpdateMedia.RequestId")
            };
            UpdateMediaResponse.Media_ media = new UpdateMediaResponse.Media_()
            {
                MediaId = context.StringValue("UpdateMedia.Media.MediaId"),
                Title = context.StringValue("UpdateMedia.Media.Title"),
                Description = context.StringValue("UpdateMedia.Media.Description"),
                CoverURL = context.StringValue("UpdateMedia.Media.CoverURL"),
                CateId = context.LongValue("UpdateMedia.Media.CateId"),
                Duration = context.StringValue("UpdateMedia.Media.Duration"),
                Format = context.StringValue("UpdateMedia.Media.Format"),
                Size = context.StringValue("UpdateMedia.Media.Size"),
                Bitrate = context.StringValue("UpdateMedia.Media.Bitrate"),
                Width = context.StringValue("UpdateMedia.Media.Width"),
                Height = context.StringValue("UpdateMedia.Media.Height"),
                Fps = context.StringValue("UpdateMedia.Media.Fps"),
                PublishState = context.StringValue("UpdateMedia.Media.PublishState"),
                CreationTime = context.StringValue("UpdateMedia.Media.CreationTime")
            };
            List<string> tags = new List<string>();
			for (int i = 0; i < context.Length("UpdateMedia.Media.Tags.Length"); i++) {
				tags.Add(context.StringValue($"UpdateMedia.Media.Tags[{i}]"));
			}
			media.Tags = tags;

			List<string> runIdList = new List<string>();
			for (int i = 0; i < context.Length("UpdateMedia.Media.RunIdList.Length"); i++) {
				runIdList.Add(context.StringValue($"UpdateMedia.Media.RunIdList[{i}]"));
			}
			media.RunIdList = runIdList;

            UpdateMediaResponse.Media_.File_ file = new UpdateMediaResponse.Media_.File_()
            {
                URL = context.StringValue("UpdateMedia.Media.File.URL"),
                State = context.StringValue("UpdateMedia.Media.File.State")
            };
            media.File = file;
			updateMediaResponse.Media = media;
        
			return updateMediaResponse;
        }
    }
}