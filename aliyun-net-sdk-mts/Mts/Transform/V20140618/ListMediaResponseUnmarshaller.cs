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
    public class ListMediaResponseUnmarshaller
    {
        public static ListMediaResponse Unmarshall(UnmarshallerContext context)
        {
			ListMediaResponse listMediaResponse = new ListMediaResponse();

			listMediaResponse.HttpResponse = context.HttpResponse;
			listMediaResponse.RequestId = context.StringValue("ListMedia.RequestId");
			listMediaResponse.NextPageToken = context.StringValue("ListMedia.NextPageToken");

			List<ListMediaResponse.Media> mediaList = new List<ListMediaResponse.Media>();
			for (int i = 0; i < context.Length("ListMedia.MediaList.Length"); i++) {
				ListMediaResponse.Media media = new ListMediaResponse.Media();
				media.MediaId = context.StringValue("ListMedia.MediaList["+ i +"].MediaId");
				media.Title = context.StringValue("ListMedia.MediaList["+ i +"].Title");
				media.Description = context.StringValue("ListMedia.MediaList["+ i +"].Description");
				media.CoverURL = context.StringValue("ListMedia.MediaList["+ i +"].CoverURL");
				media.CateId = context.LongValue("ListMedia.MediaList["+ i +"].CateId");
				media.Duration = context.StringValue("ListMedia.MediaList["+ i +"].Duration");
				media.Format = context.StringValue("ListMedia.MediaList["+ i +"].Format");
				media.Size = context.StringValue("ListMedia.MediaList["+ i +"].Size");
				media.Bitrate = context.StringValue("ListMedia.MediaList["+ i +"].Bitrate");
				media.Width = context.StringValue("ListMedia.MediaList["+ i +"].Width");
				media.Height = context.StringValue("ListMedia.MediaList["+ i +"].Height");
				media.Fps = context.StringValue("ListMedia.MediaList["+ i +"].Fps");
				media.PublishState = context.StringValue("ListMedia.MediaList["+ i +"].PublishState");
				media.CreationTime = context.StringValue("ListMedia.MediaList["+ i +"].CreationTime");

				List<string> tags = new List<string>();
				for (int j = 0; j < context.Length("ListMedia.MediaList["+ i +"].Tags.Length"); j++) {
					tags.Add(context.StringValue("ListMedia.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = tags;

				List<string> runIdList = new List<string>();
				for (int j = 0; j < context.Length("ListMedia.MediaList["+ i +"].RunIdList.Length"); j++) {
					runIdList.Add(context.StringValue("ListMedia.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = runIdList;

				ListMediaResponse.Media.File_ file = new ListMediaResponse.Media.File_();
				file.URL = context.StringValue("ListMedia.MediaList["+ i +"].File.URL");
				file.State = context.StringValue("ListMedia.MediaList["+ i +"].File.State");
				media.File = file;

				mediaList.Add(media);
			}
			listMediaResponse.MediaList = mediaList;
        
			return listMediaResponse;
        }
    }
}