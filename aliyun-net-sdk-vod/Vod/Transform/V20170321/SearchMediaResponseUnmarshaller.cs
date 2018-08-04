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
				video.ModificationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Video.ModificationTime");
				video.CreationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Video.CreationTime");
				video.CoverURL = context.StringValue("SearchMedia.MediaList["+ i +"].Video.CoverURL");
				video.CateId = context.LongValue("SearchMedia.MediaList["+ i +"].Video.CateId");
				video.CateName = context.StringValue("SearchMedia.MediaList["+ i +"].Video.CateName");
				video.DownloadSwitch = context.StringValue("SearchMedia.MediaList["+ i +"].Video.DownloadSwitch");
				video.PreprocessStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PreprocessStatus");
				video.StorageLocation = context.StringValue("SearchMedia.MediaList["+ i +"].Video.StorageLocation");
				video.RegionId = context.StringValue("SearchMedia.MediaList["+ i +"].Video.RegionId");
				video.TranscodeMode = context.StringValue("SearchMedia.MediaList["+ i +"].Video.TranscodeMode");

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

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio audio = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio();
				audio.AudioId = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.AudioId");
				audio.MediaSource = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.MediaSource");
				audio.Title = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.Title");
				audio.Tags = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.Tags");
				audio.Status = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.Status");
				audio.Size = context.LongValue("SearchMedia.MediaList["+ i +"].Audio.Size");
				audio.Duration = context.FloatValue("SearchMedia.MediaList["+ i +"].Audio.Duration");
				audio.Description = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.Description");
				audio.ModificationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.ModificationTime");
				audio.CreationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.CreationTime");
				audio.CoverURL = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.CoverURL");
				audio.CateId = context.LongValue("SearchMedia.MediaList["+ i +"].Audio.CateId");
				audio.CateName = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.CateName");
				audio.DownloadSwitch = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.DownloadSwitch");
				audio.PreprocessStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PreprocessStatus");
				audio.StorageLocation = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.StorageLocation");
				audio.RegionId = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.RegionId");
				audio.TranscodeMode = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.TranscodeMode");

				List<string> audio_snapshots2 = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Audio.Snapshots.Length"); j++) {
					audio_snapshots2.Add(context.StringValue("SearchMedia.MediaList["+ i +"].Audio.Snapshots["+ j +"]"));
				}
				audio.Snapshots2 = audio_snapshots2;

				List<string> audio_spriteSnapshots3 = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots.Length"); j++) {
					audio_spriteSnapshots3.Add(context.StringValue("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots["+ j +"]"));
				}
				audio.SpriteSnapshots3 = audio_spriteSnapshots3;
				media.Audio = audio;

				searchMediaResponse_mediaList.Add(media);
			}
			searchMediaResponse.MediaList = searchMediaResponse_mediaList;
        
			return searchMediaResponse;
        }
    }
}