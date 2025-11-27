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
    public class AddMediaResponseUnmarshaller
    {
        public static AddMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddMediaResponse addMediaResponse = new AddMediaResponse();

			addMediaResponse.HttpResponse = _ctx.HttpResponse;
			addMediaResponse.RequestId = _ctx.StringValue("AddMedia.RequestId");

			AddMediaResponse.AddMedia_Media media = new AddMediaResponse.AddMedia_Media();
			media.CreationTime = _ctx.StringValue("AddMedia.Media.CreationTime");
			media.CateId = _ctx.LongValue("AddMedia.Media.CateId");
			media.Height = _ctx.StringValue("AddMedia.Media.Height");
			media.CensorState = _ctx.StringValue("AddMedia.Media.CensorState");
			media.Bitrate = _ctx.StringValue("AddMedia.Media.Bitrate");
			media.MediaId = _ctx.StringValue("AddMedia.Media.MediaId");
			media.PublishState = _ctx.StringValue("AddMedia.Media.PublishState");
			media.Description = _ctx.StringValue("AddMedia.Media.Description");
			media.Width = _ctx.StringValue("AddMedia.Media.Width");
			media.Size = _ctx.StringValue("AddMedia.Media.Size");
			media.CoverURL = _ctx.StringValue("AddMedia.Media.CoverURL");
			media.Duration = _ctx.StringValue("AddMedia.Media.Duration");
			media.Fps = _ctx.StringValue("AddMedia.Media.Fps");
			media.Title = _ctx.StringValue("AddMedia.Media.Title");
			media.Format = _ctx.StringValue("AddMedia.Media.Format");

			List<string> media_tags = new List<string>();
			for (int i = 0; i < _ctx.Length("AddMedia.Media.Tags.Length"); i++) {
				media_tags.Add(_ctx.StringValue("AddMedia.Media.Tags["+ i +"]"));
			}
			media.Tags = media_tags;

			List<string> media_runIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("AddMedia.Media.RunIdList.Length"); i++) {
				media_runIdList.Add(_ctx.StringValue("AddMedia.Media.RunIdList["+ i +"]"));
			}
			media.RunIdList = media_runIdList;

			AddMediaResponse.AddMedia_Media.AddMedia_File file = new AddMediaResponse.AddMedia_Media.AddMedia_File();
			file.State = _ctx.StringValue("AddMedia.Media.File.State");
			file.URL = _ctx.StringValue("AddMedia.Media.File.URL");
			media.File = file;
			addMediaResponse.Media = media;
        
			return addMediaResponse;
        }
    }
}
