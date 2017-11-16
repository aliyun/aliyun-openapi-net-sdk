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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class UpdateMediaResponseUnmarshaller
    {
        public static UpdateMediaResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateMediaResponse updateMediaResponse = new UpdateMediaResponse();

			updateMediaResponse.HttpResponse = context.HttpResponse;
			updateMediaResponse.RequestId = context.StringValue("UpdateMedia.RequestId");

			UpdateMediaResponse.UpdateMedia_Media media = new UpdateMediaResponse.UpdateMedia_Media();
			media.MediaId = context.StringValue("UpdateMedia.Media.MediaId");
			media.Title = context.StringValue("UpdateMedia.Media.Title");
			media.Description = context.StringValue("UpdateMedia.Media.Description");
			media.CoverURL = context.StringValue("UpdateMedia.Media.CoverURL");
			media.CateId = context.LongValue("UpdateMedia.Media.CateId");
			media.Duration = context.StringValue("UpdateMedia.Media.Duration");
			media.Format = context.StringValue("UpdateMedia.Media.Format");
			media.Size = context.StringValue("UpdateMedia.Media.Size");
			media.Bitrate = context.StringValue("UpdateMedia.Media.Bitrate");
			media.Width = context.StringValue("UpdateMedia.Media.Width");
			media.Height = context.StringValue("UpdateMedia.Media.Height");
			media.Fps = context.StringValue("UpdateMedia.Media.Fps");
			media.PublishState = context.StringValue("UpdateMedia.Media.PublishState");
			media.CreationTime = context.StringValue("UpdateMedia.Media.CreationTime");

			List<string> media_tags = new List<string>();
			for (int i = 0; i < context.Length("UpdateMedia.Media.Tags.Length"); i++) {
				media_tags.Add(context.StringValue("UpdateMedia.Media.Tags["+ i +"]"));
			}
			media.Tags = media_tags;

			List<string> media_runIdList = new List<string>();
			for (int i = 0; i < context.Length("UpdateMedia.Media.RunIdList.Length"); i++) {
				media_runIdList.Add(context.StringValue("UpdateMedia.Media.RunIdList["+ i +"]"));
			}
			media.RunIdList = media_runIdList;

			UpdateMediaResponse.UpdateMedia_Media.UpdateMedia_File file = new UpdateMediaResponse.UpdateMedia_Media.UpdateMedia_File();
			file.URL = context.StringValue("UpdateMedia.Media.File.URL");
			file.State = context.StringValue("UpdateMedia.Media.File.State");
			media.File = file;
			updateMediaResponse.Media = media;
        
			return updateMediaResponse;
        }
    }
}