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
using Aliyun.Acs.vod.Model.V20170321;

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
				video.AuditStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditStatus");
				video.AuditAIStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAIStatus");
				video.AuditManualStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditManualStatus");
				video.AuditAIResult = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAIResult");
				video.AuditTemplateId = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditTemplateId");
				video.CustomMediaInfo = context.StringValue("SearchMedia.MediaList["+ i +"].Video.CustomMediaInfo");
				video.AppId = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AppId");
				video.AuditAbnormalModules = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAbnormalModules");
				video.AuditLabel = context.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditLabel");

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

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo> video_playInfoList = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Video.PlayInfoList.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo playInfo = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo();
					playInfo.Width = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Width");
					playInfo.Height = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Height");
					playInfo.Size = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Size");
					playInfo.PlayURL = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].PlayURL");
					playInfo.Bitrate = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Bitrate");
					playInfo.Definition = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Definition");
					playInfo.Duration = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Duration");
					playInfo.Format = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Format");
					playInfo.Fps = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Fps");
					playInfo.Encrypt = context.LongValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Encrypt");
					playInfo.Plaintext = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Plaintext");
					playInfo.Complexity = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Complexity");
					playInfo.StreamType = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].StreamType");
					playInfo.Rand = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Rand");
					playInfo.JobId = context.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].JobId");

					video_playInfoList.Add(playInfo);
				}
				video.PlayInfoList = video_playInfoList;
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
				audio.AuditStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditStatus");
				audio.AuditAIStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditAIStatus");
				audio.AuditManualStatus = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditManualStatus");
				audio.AuditAIResult = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditAIResult");
				audio.AuditTemplateId = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditTemplateId");
				audio.CustomMediaInfo = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.CustomMediaInfo");
				audio.AppId = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.AppId");

				List<string> audio_snapshots1 = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Audio.Snapshots.Length"); j++) {
					audio_snapshots1.Add(context.StringValue("SearchMedia.MediaList["+ i +"].Audio.Snapshots["+ j +"]"));
				}
				audio.Snapshots1 = audio_snapshots1;

				List<string> audio_spriteSnapshots2 = new List<string>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots.Length"); j++) {
					audio_spriteSnapshots2.Add(context.StringValue("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots["+ j +"]"));
				}
				audio.SpriteSnapshots2 = audio_spriteSnapshots2;

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4> audio_playInfoList3 = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4 playInfo4 = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4();
					playInfo4.Width = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Width");
					playInfo4.Height = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Height");
					playInfo4.Size = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Size");
					playInfo4.PlayURL = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].PlayURL");
					playInfo4.Bitrate = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Bitrate");
					playInfo4.Definition = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Definition");
					playInfo4.Duration = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Duration");
					playInfo4.Format = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Format");
					playInfo4.Fps = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Fps");
					playInfo4.Encrypt = context.LongValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Encrypt");
					playInfo4.Plaintext = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Plaintext");
					playInfo4.Complexity = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Complexity");
					playInfo4.StreamType = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].StreamType");
					playInfo4.Rand = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Rand");
					playInfo4.JobId = context.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].JobId");

					audio_playInfoList3.Add(playInfo4);
				}
				audio.PlayInfoList3 = audio_playInfoList3;
				media.Audio = audio;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Image image = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Image();
				image.Title = context.StringValue("SearchMedia.MediaList["+ i +"].Image.Title");
				image.ImageId = context.StringValue("SearchMedia.MediaList["+ i +"].Image.ImageId");
				image.CateId = context.LongValue("SearchMedia.MediaList["+ i +"].Image.CateId");
				image.CateName = context.StringValue("SearchMedia.MediaList["+ i +"].Image.CateName");
				image.Ext = context.StringValue("SearchMedia.MediaList["+ i +"].Image.Ext");
				image.CreationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Image.CreationTime");
				image.ModificationTime = context.StringValue("SearchMedia.MediaList["+ i +"].Image.ModificationTime");
				image.Tags = context.StringValue("SearchMedia.MediaList["+ i +"].Image.Tags");
				image.Type = context.StringValue("SearchMedia.MediaList["+ i +"].Image.Type");
				image.URL = context.StringValue("SearchMedia.MediaList["+ i +"].Image.URL");
				image.Status = context.StringValue("SearchMedia.MediaList["+ i +"].Image.Status");
				image.Description = context.StringValue("SearchMedia.MediaList["+ i +"].Image.Description");
				image.StorageLocation = context.StringValue("SearchMedia.MediaList["+ i +"].Image.StorageLocation");
				image.RegionId = context.StringValue("SearchMedia.MediaList["+ i +"].Image.RegionId");
				image.AppId = context.StringValue("SearchMedia.MediaList["+ i +"].Image.AppId");
				media.Image = image;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia attachedMedia = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia();
				attachedMedia.Title = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Title");
				attachedMedia.MediaId = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.MediaId");
				attachedMedia.Ext = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Ext");
				attachedMedia.CreationTime = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.CreationTime");
				attachedMedia.ModificationTime = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.ModificationTime");
				attachedMedia.Tags = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Tags");
				attachedMedia.BusinessType = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.BusinessType");
				attachedMedia.URL = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.URL");
				attachedMedia.Status = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Status");
				attachedMedia.Description = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Description");
				attachedMedia.StorageLocation = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.StorageLocation");
				attachedMedia.RegionId = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.RegionId");
				attachedMedia.AppId = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.AppId");
				attachedMedia.Icon = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Icon");
				attachedMedia.OnlineStatus = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.OnlineStatus");

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category> attachedMedia_categories = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category>();
				for (int j = 0; j < context.Length("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category category = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category();
					category.CateId = context.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].CateId");
					category.CateName = context.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].CateName");
					category.Level = context.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].Level");
					category.ParentId = context.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].ParentId");

					attachedMedia_categories.Add(category);
				}
				attachedMedia.Categories = attachedMedia_categories;
				media.AttachedMedia = attachedMedia;

				searchMediaResponse_mediaList.Add(media);
			}
			searchMediaResponse.MediaList = searchMediaResponse_mediaList;
        
			return searchMediaResponse;
        }
    }
}
