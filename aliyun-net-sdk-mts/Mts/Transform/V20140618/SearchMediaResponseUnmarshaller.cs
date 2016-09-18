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
    public class SearchMediaResponseUnmarshaller
    {
        public static SearchMediaResponse Unmarshall(UnmarshallerContext context)
        {
			SearchMediaResponse searchMediaResponse = new SearchMediaResponse();

			searchMediaResponse.HttpResponse = context.HttpResponse;
			searchMediaResponse.RequestId = context.StringValue("SearchMedia.RequestId");
			searchMediaResponse.TotalNum = context.LongValue("SearchMedia.TotalNum");
			searchMediaResponse.PageNumber = context.LongValue("SearchMedia.PageNumber");
			searchMediaResponse.PageSize = context.LongValue("SearchMedia.PageSize");

			List<SearchMediaResponse.Media> mediaList = new List<SearchMediaResponse.Media>();
			for (int i = 0; i < context.Length("SearchMedia.MediaList.Length"); i++) {
				SearchMediaResponse.Media media = new SearchMediaResponse.Media();
				media.MediaId = context.StringValue("SearchMedia.MediaList["+ i +"].MediaId");
				media.Title = context.StringValue("SearchMedia.MediaList["+ i +"].Title");
				media.Description = context.StringValue("SearchMedia.MediaList["+ i +"].Description");
				media.CoverURL = context.StringValue("SearchMedia.MediaList["+ i +"].CoverURL");
				media.CateId = context.LongValue("SearchMedia.MediaList["+ i +"].CateId");
				media.Duration = context.StringValue("SearchMedia.MediaList["+ i +"].Duration");
				media.Format = context.StringValue("SearchMedia.MediaList["+ i +"].Format");
				media.Size = context.StringValue("SearchMedia.MediaList["+ i +"].Size");
				media.Bitrate = context.StringValue("SearchMedia.MediaList["+ i +"].Bitrate");
				media.Width = context.StringValue("SearchMedia.MediaList["+ i +"].Width");
				media.Height = context.StringValue("SearchMedia.MediaList["+ i +"].Height");
				media.Fps = context.StringValue("SearchMedia.MediaList["+ i +"].Fps");
				media.PublishState = context.StringValue("SearchMedia.MediaList["+ i +"].PublishState");
				media.CreationTime = context.StringValue("SearchMedia.MediaList["+ i +"].CreationTime");

				List<string> tags = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Tags.Length"); j++) {
					tags.Add(context.StringValue("SearchMedia.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = tags;

				List<string> runIdList = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].RunIdList.Length"); j++) {
					runIdList.Add(context.StringValue("SearchMedia.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = runIdList;

				SearchMediaResponse.Media.File_ file = new SearchMediaResponse.Media.File_();
				file.URL = context.StringValue("SearchMedia.MediaList["+ i +"].File.URL");
				file.State = context.StringValue("SearchMedia.MediaList["+ i +"].File.State");
				media.File = file;

				mediaList.Add(media);
			}
			searchMediaResponse.MediaList = mediaList;
        
			return searchMediaResponse;
        }
    }
}