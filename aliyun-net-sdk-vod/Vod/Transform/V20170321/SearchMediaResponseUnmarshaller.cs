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
        public static SearchMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchMediaResponse searchMediaResponse = new SearchMediaResponse();

			searchMediaResponse.HttpResponse = _ctx.HttpResponse;
			searchMediaResponse.RequestId = _ctx.StringValue("SearchMedia.RequestId");
			searchMediaResponse.ScrollToken = _ctx.StringValue("SearchMedia.ScrollToken");
			searchMediaResponse.Total = _ctx.LongValue("SearchMedia.Total");

			List<SearchMediaResponse.SearchMedia_Media> searchMediaResponse_mediaList = new List<SearchMediaResponse.SearchMedia_Media>();
			for (int i = 0; i < _ctx.Length("SearchMedia.MediaList.Length"); i++) {
				SearchMediaResponse.SearchMedia_Media media = new SearchMediaResponse.SearchMedia_Media();
				media.MediaType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].MediaType");
				media.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].CreationTime");
				media.MediaId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].MediaId");

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Video video = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Video();
				video.VideoId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.VideoId");
				video.MediaSource = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.MediaSource");
				video.MediaType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.MediaType");
				video.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Title");
				video.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Tags");
				video.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Status");
				video.Size = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Video.Size");
				video.Duration = _ctx.FloatValue("SearchMedia.MediaList["+ i +"].Video.Duration");
				video.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Description");
				video.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.ModificationTime");
				video.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CreationTime");
				video.CoverURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CoverURL");
				video.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Video.CateId");
				video.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CateName");
				video.DownloadSwitch = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.DownloadSwitch");
				video.PreprocessStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PreprocessStatus");
				video.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.StorageLocation");
				video.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.RegionId");
				video.TranscodeMode = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.TranscodeMode");
				video.AuditStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditStatus");
				video.AuditAIStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAIStatus");
				video.AuditManualStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditManualStatus");
				video.AuditAIResult = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAIResult");
				video.AuditTemplateId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditTemplateId");
				video.CustomMediaInfo = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CustomMediaInfo");
				video.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AppId");
				video.AuditAbnormalModules = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAbnormalModules");
				video.AuditLabel = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditLabel");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Video.Snapshots.Length"); j++) {
					video_snapshots.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;

				List<string> video_spriteSnapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Video.SpriteSnapshots.Length"); j++) {
					video_spriteSnapshots.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.SpriteSnapshots["+ j +"]"));
				}
				video.SpriteSnapshots = video_spriteSnapshots;

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo> video_playInfoList = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Video.PlayInfoList.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo playInfo = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo();
					playInfo.Width = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Width");
					playInfo.Height = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Height");
					playInfo.Size = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Size");
					playInfo.PlayURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].PlayURL");
					playInfo.Bitrate = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Bitrate");
					playInfo.Definition = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Definition");
					playInfo.Duration = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Duration");
					playInfo.Format = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Format");
					playInfo.Fps = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Fps");
					playInfo.Encrypt = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Encrypt");
					playInfo.Plaintext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Plaintext");
					playInfo.Complexity = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Complexity");
					playInfo.StreamType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].StreamType");
					playInfo.Rand = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Rand");
					playInfo.JobId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].JobId");

					video_playInfoList.Add(playInfo);
				}
				video.PlayInfoList = video_playInfoList;
				media.Video = video;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio audio = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio();
				audio.AudioId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AudioId");
				audio.MediaSource = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.MediaSource");
				audio.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Title");
				audio.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Tags");
				audio.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Status");
				audio.Size = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Audio.Size");
				audio.Duration = _ctx.FloatValue("SearchMedia.MediaList["+ i +"].Audio.Duration");
				audio.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Description");
				audio.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.ModificationTime");
				audio.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CreationTime");
				audio.CoverURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CoverURL");
				audio.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Audio.CateId");
				audio.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CateName");
				audio.DownloadSwitch = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.DownloadSwitch");
				audio.PreprocessStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PreprocessStatus");
				audio.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.StorageLocation");
				audio.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.RegionId");
				audio.TranscodeMode = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.TranscodeMode");
				audio.AuditStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditStatus");
				audio.AuditAIStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditAIStatus");
				audio.AuditManualStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditManualStatus");
				audio.AuditAIResult = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditAIResult");
				audio.AuditTemplateId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditTemplateId");
				audio.CustomMediaInfo = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CustomMediaInfo");
				audio.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AppId");

				List<string> audio_snapshots1 = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Audio.Snapshots.Length"); j++) {
					audio_snapshots1.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Snapshots["+ j +"]"));
				}
				audio.Snapshots1 = audio_snapshots1;

				List<string> audio_spriteSnapshots2 = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots.Length"); j++) {
					audio_spriteSnapshots2.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots["+ j +"]"));
				}
				audio.SpriteSnapshots2 = audio_spriteSnapshots2;

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4> audio_playInfoList3 = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4 playInfo4 = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4();
					playInfo4.Width = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Width");
					playInfo4.Height = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Height");
					playInfo4.Size = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Size");
					playInfo4.PlayURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].PlayURL");
					playInfo4.Bitrate = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Bitrate");
					playInfo4.Definition = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Definition");
					playInfo4.Duration = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Duration");
					playInfo4.Format = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Format");
					playInfo4.Fps = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Fps");
					playInfo4.Encrypt = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Encrypt");
					playInfo4.Plaintext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Plaintext");
					playInfo4.Complexity = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Complexity");
					playInfo4.StreamType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].StreamType");
					playInfo4.Rand = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Rand");
					playInfo4.JobId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].JobId");

					audio_playInfoList3.Add(playInfo4);
				}
				audio.PlayInfoList3 = audio_playInfoList3;
				media.Audio = audio;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Image image = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Image();
				image.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Title");
				image.ImageId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.ImageId");
				image.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Image.CateId");
				image.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.CateName");
				image.Ext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Ext");
				image.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.CreationTime");
				image.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.ModificationTime");
				image.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Tags");
				image.Type = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Type");
				image.URL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.URL");
				image.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Status");
				image.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Description");
				image.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.StorageLocation");
				image.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.RegionId");
				image.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.AppId");
				media.Image = image;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia attachedMedia = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia();
				attachedMedia.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Title");
				attachedMedia.MediaId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.MediaId");
				attachedMedia.Ext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Ext");
				attachedMedia.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.CreationTime");
				attachedMedia.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.ModificationTime");
				attachedMedia.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Tags");
				attachedMedia.BusinessType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.BusinessType");
				attachedMedia.URL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.URL");
				attachedMedia.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Status");
				attachedMedia.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Description");
				attachedMedia.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.StorageLocation");
				attachedMedia.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.RegionId");
				attachedMedia.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.AppId");
				attachedMedia.Icon = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Icon");
				attachedMedia.OnlineStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.OnlineStatus");

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category> attachedMedia_categories = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category category = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category();
					category.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].CateId");
					category.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].CateName");
					category.Level = _ctx.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].Level");
					category.ParentId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].ParentId");

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
