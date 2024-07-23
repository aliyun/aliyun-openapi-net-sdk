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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class UpdateMediaResponseUnmarshaller
    {
        public static UpdateMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateMediaResponse updateMediaResponse = new UpdateMediaResponse();

			updateMediaResponse.HttpResponse = _ctx.HttpResponse;
			updateMediaResponse.RequestId = _ctx.StringValue("UpdateMedia.RequestId");

			UpdateMediaResponse.UpdateMedia_Media media = new UpdateMediaResponse.UpdateMedia_Media();
			media.CreationTime = _ctx.StringValue("UpdateMedia.Media.CreationTime");
			media.CateId = _ctx.LongValue("UpdateMedia.Media.CateId");
			media.Height = _ctx.StringValue("UpdateMedia.Media.Height");
			media.CensorState = _ctx.StringValue("UpdateMedia.Media.CensorState");
			media.Bitrate = _ctx.StringValue("UpdateMedia.Media.Bitrate");
			media.MediaId = _ctx.StringValue("UpdateMedia.Media.MediaId");
			media.PublishState = _ctx.StringValue("UpdateMedia.Media.PublishState");
			media.Description = _ctx.StringValue("UpdateMedia.Media.Description");
			media.Width = _ctx.StringValue("UpdateMedia.Media.Width");
			media.Size = _ctx.StringValue("UpdateMedia.Media.Size");
			media.CoverURL = _ctx.StringValue("UpdateMedia.Media.CoverURL");
			media.Duration = _ctx.StringValue("UpdateMedia.Media.Duration");
			media.Fps = _ctx.StringValue("UpdateMedia.Media.Fps");
			media.Title = _ctx.StringValue("UpdateMedia.Media.Title");
			media.Format = _ctx.StringValue("UpdateMedia.Media.Format");

			List<string> media_tags = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateMedia.Media.Tags.Length"); i++) {
				media_tags.Add(_ctx.StringValue("UpdateMedia.Media.Tags["+ i +"]"));
			}
			media.Tags = media_tags;

			List<string> media_runIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateMedia.Media.RunIdList.Length"); i++) {
				media_runIdList.Add(_ctx.StringValue("UpdateMedia.Media.RunIdList["+ i +"]"));
			}
			media.RunIdList = media_runIdList;

			UpdateMediaResponse.UpdateMedia_Media.UpdateMedia_File file = new UpdateMediaResponse.UpdateMedia_Media.UpdateMedia_File();
			file.State = _ctx.StringValue("UpdateMedia.Media.File.State");
			file.URL = _ctx.StringValue("UpdateMedia.Media.File.URL");
			media.File = file;
			updateMediaResponse.Media = media;
        
			return updateMediaResponse;
        }
    }
}
