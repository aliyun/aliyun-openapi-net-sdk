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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class SearchMediaResponseUnmarshaller
    {
        public static SearchMediaResponse Unmarshall(UnmarshallerContext context)
        {
			SearchMediaResponse searchMediaResponse = new SearchMediaResponse();

			searchMediaResponse.HttpResponse = context.HttpResponse;
			searchMediaResponse.RequestId = context.StringValue("SearchMedia.RequestId");
			searchMediaResponse.ScrollToken = context.StringValue("SearchMedia.ScrollToken");
			searchMediaResponse.Total = context.LongValue("SearchMedia.Total");

			List<SearchMediaResponse.SearchMedia_Media> searchMediaResponse_mediaList = new List<SearchMediaResponse.SearchMedia_Media>();
			for (int i = 0; i < context.Length("SearchMedia.MediaList.Length"); i++) {
				SearchMediaResponse.SearchMedia_Media media = new SearchMediaResponse.SearchMedia_Media();
				media.MediaType = context.StringValue("SearchMedia.MediaList["+ i +"].MediaType");
				media.CreationTime = context.StringValue("SearchMedia.MediaList["+ i +"].CreationTime");
				media.MediaType1 = context.StringValue("SearchMedia.MediaList["+ i +"].MediaType");
				media.MediaId = context.StringValue("SearchMedia.MediaList["+ i +"].MediaId");

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Video video = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Video();
				video.VideoId = context.StringValue("SearchMedia.MediaList["+ i +"].Video.VideoId");
				video.MediaSource = context.StringValue("SearchMedia.MediaList["+ i +"].Video.MediaSource");
				video.MediaType = context.StringValue("SearchMedia.MediaList["+ i +"].Video.MediaType");
				video.Title = context.StringValue("SearchMedia.MediaList["+ i +"].Video.Title");
				video.Tags = context.StringValue("SearchMedia.MediaList["+ i +"].Video.Tags");
				video.Status = context.StringValue("SearchMedia.MediaList["+ i +"].Video.Status");
				video.Size = context.LongValue("SearchMedia.MediaList["+ i +"].Video.Size");
				video.Duration = context.FloatValue("SearchMedia.MediaList["+ i +"].Video.Duration");
				video.Description = context.StringValue("SearchMedia.MediaList["+ i +"].Video.Description");
				video.CustomerId = context.LongValue("SearchMedia.MediaList["+ i +"].Video.CustomerId");
				video.ModificationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Video.ModificationTime");
				video.CreationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Video.CreationTime");
				video.CoverURL = context.StringValue("SearchMedia.MediaList["+ i +"].Video.CoverURL");
				video.CateId = context.LongValue("SearchMedia.MediaList["+ i +"].Video.CateId");
				video.CateName = context.StringValue("SearchMedia.MediaList["+ i +"].Video.CateName");
				video.DownloadSwitch = context.StringValue("SearchMedia.MediaList["+ i +"].Video.DownloadSwitch");
				video.PreprocessStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PreprocessStatus");
				video.StorageLocation = context.StringValue("SearchMedia.MediaList["+ i +"].Video.StorageLocation");
				video.RegionId = context.StringValue("SearchMedia.MediaList["+ i +"].Video.RegionId");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Video.Snapshots.Length"); j++) {
					video_snapshots.Add(context.StringValue("SearchMedia.MediaList["+ i +"].Video.Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;

				List<string> video_spriteSnapshots = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Video.SpriteSnapshots.Length"); j++) {
					video_spriteSnapshots.Add(context.StringValue("SearchMedia.MediaList["+ i +"].Video.SpriteSnapshots["+ j +"]"));
				}
				video.SpriteSnapshots = video_spriteSnapshots;
				media.Video = video;

				searchMediaResponse_mediaList.Add(media);
			}
			searchMediaResponse.MediaList = searchMediaResponse_mediaList;
        
			return searchMediaResponse;
        }
    }
}