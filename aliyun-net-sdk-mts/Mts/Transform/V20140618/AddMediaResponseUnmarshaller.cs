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
    public class AddMediaResponseUnmarshaller
    {
        public static AddMediaResponse Unmarshall(UnmarshallerContext context)
        {
			AddMediaResponse addMediaResponse = new AddMediaResponse();

			addMediaResponse.HttpResponse = context.HttpResponse;
			addMediaResponse.RequestId = context.StringValue("AddMedia.RequestId");

			AddMediaResponse.Media_ media = new AddMediaResponse.Media_();
			media.MediaId = context.StringValue("AddMedia.Media.MediaId");
			media.Title = context.StringValue("AddMedia.Media.Title");
			media.Description = context.StringValue("AddMedia.Media.Description");
			media.CoverURL = context.StringValue("AddMedia.Media.CoverURL");
			media.CateId = context.LongValue("AddMedia.Media.CateId");
			media.Duration = context.StringValue("AddMedia.Media.Duration");
			media.Format = context.StringValue("AddMedia.Media.Format");
			media.Size = context.StringValue("AddMedia.Media.Size");
			media.Bitrate = context.StringValue("AddMedia.Media.Bitrate");
			media.Width = context.StringValue("AddMedia.Media.Width");
			media.Height = context.StringValue("AddMedia.Media.Height");
			media.Fps = context.StringValue("AddMedia.Media.Fps");
			media.PublishState = context.StringValue("AddMedia.Media.PublishState");
			media.CreationTime = context.StringValue("AddMedia.Media.CreationTime");

			List<string> tags = new List<string>();
			for (int i = 0; i < context.Length("AddMedia.Media.Tags.Length"); i++) {
				tags.Add(context.StringValue("AddMedia.Media.Tags["+ i +"]"));
			}
			media.Tags = tags;

			List<string> runIdList = new List<string>();
			for (int i = 0; i < context.Length("AddMedia.Media.RunIdList.Length"); i++) {
				runIdList.Add(context.StringValue("AddMedia.Media.RunIdList["+ i +"]"));
			}
			media.RunIdList = runIdList;

			AddMediaResponse.Media_.File_ file = new AddMediaResponse.Media_.File_();
			file.URL = context.StringValue("AddMedia.Media.File.URL");
			file.State = context.StringValue("AddMedia.Media.File.State");
			media.File = file;
			addMediaResponse.Media = media;
        
			return addMediaResponse;
        }
    }
}