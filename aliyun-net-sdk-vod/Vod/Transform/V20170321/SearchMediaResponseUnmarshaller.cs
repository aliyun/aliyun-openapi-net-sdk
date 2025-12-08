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
			searchMediaResponse.Total = _ctx.LongValue("SearchMedia.Total");
			searchMediaResponse.ScrollToken = _ctx.StringValue("SearchMedia.ScrollToken");

			List<SearchMediaResponse.SearchMedia_Media> searchMediaResponse_mediaList = new List<SearchMediaResponse.SearchMedia_Media>();
			for (int i = 0; i < _ctx.Length("SearchMedia.MediaList.Length"); i++) {
				SearchMediaResponse.SearchMedia_Media media = new SearchMediaResponse.SearchMedia_Media();
				media.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].CreationTime");
				media.MediaType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].MediaType");
				media.MediaId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].MediaId");

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Video video = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Video();
				video.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Status");
				video.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CreationTime");
				video.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.StorageLocation");
				video.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Video.CateId");
				video.AuditTemplateId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditTemplateId");
				video.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Tags");
				video.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.ModificationTime");
				video.AuditManualStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditManualStatus");
				video.MediaType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.MediaType");
				video.MediaSource = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.MediaSource");
				video.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Description");
				video.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AppId");
				video.CoverURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CoverURL");
				video.AuditStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditStatus");
				video.AuditAIStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAIStatus");
				video.VideoId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.VideoId");
				video.AuditLabel = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditLabel");
				video.DownloadSwitch = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.DownloadSwitch");
				video.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.RegionId");
				video.AuditAbnormalModules = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAbnormalModules");
				video.CustomMediaInfo = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CustomMediaInfo");
				video.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.CateName");
				video.TranscodeMode = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.TranscodeMode");
				video.AuditAIResult = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.AuditAIResult");
				video.PreprocessStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PreprocessStatus");
				video.RestoreExpiration = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.RestoreExpiration");
				video.RestoreStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.RestoreStatus");
				video.StorageClass = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.StorageClass");
				video.Size = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Video.Size");
				video.Duration = _ctx.FloatValue("SearchMedia.MediaList["+ i +"].Video.Duration");
				video.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Title");
				video.ReferenceId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.ReferenceId");

				List<string> video_spriteSnapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Video.SpriteSnapshots.Length"); j++) {
					video_spriteSnapshots.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.SpriteSnapshots["+ j +"]"));
				}
				video.SpriteSnapshots = video_spriteSnapshots;

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Video.Snapshots.Length"); j++) {
					video_snapshots.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo> video_playInfoList = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Video.PlayInfoList.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo playInfo = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Video.SearchMedia_PlayInfo();
					playInfo.Complexity = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Complexity");
					playInfo.Height = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Height");
					playInfo.Bitrate = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Bitrate");
					playInfo.Encrypt = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Encrypt");
					playInfo.Definition = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Definition");
					playInfo.Rand = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Rand");
					playInfo.StreamType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].StreamType");
					playInfo.JobId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].JobId");
					playInfo.Width = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Width");
					playInfo.Size = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Size");
					playInfo.Plaintext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Plaintext");
					playInfo.PlayURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].PlayURL");
					playInfo.Duration = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Duration");
					playInfo.Fps = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Fps");
					playInfo.Format = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Video.PlayInfoList["+ j +"].Format");

					video_playInfoList.Add(playInfo);
				}
				video.PlayInfoList = video_playInfoList;
				media.Video = video;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio audio = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio();
				audio.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Status");
				audio.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CreationTime");
				audio.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.StorageLocation");
				audio.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Audio.CateId");
				audio.AuditTemplateId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditTemplateId");
				audio.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Tags");
				audio.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.ModificationTime");
				audio.AuditManualStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditManualStatus");
				audio.MediaSource = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.MediaSource");
				audio.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Description");
				audio.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AppId");
				audio.CoverURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CoverURL");
				audio.AudioId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AudioId");
				audio.AuditStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditStatus");
				audio.AuditAIStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditAIStatus");
				audio.DownloadSwitch = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.DownloadSwitch");
				audio.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.RegionId");
				audio.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CateName");
				audio.TranscodeMode = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.TranscodeMode");
				audio.CustomMediaInfo = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.CustomMediaInfo");
				audio.AuditAIResult = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.AuditAIResult");
				audio.PreprocessStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PreprocessStatus");
				audio.RestoreExpiration = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.RestoreExpiration");
				audio.RestoreStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.RestoreStatus");
				audio.StorageClass = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.StorageClass");
				audio.Size = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Audio.Size");
				audio.Duration = _ctx.FloatValue("SearchMedia.MediaList["+ i +"].Audio.Duration");
				audio.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Title");
				audio.ReferenceId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.ReferenceId");

				List<string> audio_spriteSnapshots1 = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots.Length"); j++) {
					audio_spriteSnapshots1.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.SpriteSnapshots["+ j +"]"));
				}
				audio.SpriteSnapshots1 = audio_spriteSnapshots1;

				List<string> audio_snapshots2 = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Audio.Snapshots.Length"); j++) {
					audio_snapshots2.Add(_ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.Snapshots["+ j +"]"));
				}
				audio.Snapshots2 = audio_snapshots2;

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4> audio_playInfoList3 = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4 playInfo4 = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Audio.SearchMedia_PlayInfo4();
					playInfo4.Complexity = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Complexity");
					playInfo4.Height = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Height");
					playInfo4.Bitrate = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Bitrate");
					playInfo4.Encrypt = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Encrypt");
					playInfo4.Definition = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Definition");
					playInfo4.Rand = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Rand");
					playInfo4.StreamType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].StreamType");
					playInfo4.JobId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].JobId");
					playInfo4.Width = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Width");
					playInfo4.Size = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Size");
					playInfo4.Plaintext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Plaintext");
					playInfo4.PlayURL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].PlayURL");
					playInfo4.Duration = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Duration");
					playInfo4.Fps = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Fps");
					playInfo4.Format = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Audio.PlayInfoList["+ j +"].Format");

					audio_playInfoList3.Add(playInfo4);
				}
				audio.PlayInfoList3 = audio_playInfoList3;
				media.Audio = audio;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_Image image = new SearchMediaResponse.SearchMedia_Media.SearchMedia_Image();
				image.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.StorageLocation");
				image.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.CreationTime");
				image.Type = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Type");
				image.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Status");
				image.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].Image.CateId");
				image.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Tags");
				image.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.ModificationTime");
				image.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.RegionId");
				image.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.CateName");
				image.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Description");
				image.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.AppId");
				image.URL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.URL");
				image.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Title");
				image.Ext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.Ext");
				image.ImageId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].Image.ImageId");
				media.Image = image;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia attachedMedia = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia();
				attachedMedia.CreationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.CreationTime");
				attachedMedia.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Status");
				attachedMedia.StorageLocation = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.StorageLocation");
				attachedMedia.Icon = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Icon");
				attachedMedia.Tags = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Tags");
				attachedMedia.ModificationTime = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.ModificationTime");
				attachedMedia.MediaId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.MediaId");
				attachedMedia.BusinessType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.BusinessType");
				attachedMedia.RegionId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.RegionId");
				attachedMedia.Description = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Description");
				attachedMedia.AppId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.AppId");
				attachedMedia.URL = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.URL");
				attachedMedia.Title = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Title");
				attachedMedia.Ext = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Ext");
				attachedMedia.OnlineStatus = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.OnlineStatus");

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category> attachedMedia_categories = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category category = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AttachedMedia.SearchMedia_Category();
					category.ParentId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].ParentId");
					category.CateName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].CateName");
					category.CateId = _ctx.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].CateId");
					category.Level = _ctx.LongValue("SearchMedia.MediaList["+ i +"].AttachedMedia.Categories["+ j +"].Level");

					attachedMedia_categories.Add(category);
				}
				attachedMedia.Categories = attachedMedia_categories;
				media.AttachedMedia = attachedMedia;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData aiData = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData();

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem> aiData_aiLabelInfo = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem aiLabelInfoItem = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem();
					aiLabelInfoItem.Category = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo["+ j +"].Category");
					aiLabelInfoItem.LabelName = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo["+ j +"].LabelName");
					aiLabelInfoItem.LabelId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo["+ j +"].LabelId");

					List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem.SearchMedia_OccurrencesItem> aiLabelInfoItem_occurrences = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem.SearchMedia_OccurrencesItem>();
					for (int k = 0; k < _ctx.Length("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo["+ j +"].Occurrences.Length"); k++) {
						SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem.SearchMedia_OccurrencesItem occurrencesItem = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_AiLabelInfoItem.SearchMedia_OccurrencesItem();
						occurrencesItem.Score = _ctx.DoubleValue("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo["+ j +"].Occurrences["+ k +"].Score");
						occurrencesItem.From = _ctx.DoubleValue("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo["+ j +"].Occurrences["+ k +"].From");
						occurrencesItem.To = _ctx.DoubleValue("SearchMedia.MediaList["+ i +"].AiData.AiLabelInfo["+ j +"].Occurrences["+ k +"].To");

						aiLabelInfoItem_occurrences.Add(occurrencesItem);
					}
					aiLabelInfoItem.Occurrences = aiLabelInfoItem_occurrences;

					aiData_aiLabelInfo.Add(aiLabelInfoItem);
				}
				aiData.AiLabelInfo = aiData_aiLabelInfo;

				List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_OcrInfoItem> aiData_ocrInfo = new List<SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_OcrInfoItem>();
				for (int j = 0; j < _ctx.Length("SearchMedia.MediaList["+ i +"].AiData.OcrInfo.Length"); j++) {
					SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_OcrInfoItem ocrInfoItem = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AiData.SearchMedia_OcrInfoItem();
					ocrInfoItem.From = _ctx.DoubleValue("SearchMedia.MediaList["+ i +"].AiData.OcrInfo["+ j +"].From");
					ocrInfoItem.To = _ctx.DoubleValue("SearchMedia.MediaList["+ i +"].AiData.OcrInfo["+ j +"].To");
					ocrInfoItem.Content = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiData.OcrInfo["+ j +"].Content");

					aiData_ocrInfo.Add(ocrInfoItem);
				}
				aiData.OcrInfo = aiData_ocrInfo;
				media.AiData = aiData;

				SearchMediaResponse.SearchMedia_Media.SearchMedia_AiRoughData aiRoughData = new SearchMediaResponse.SearchMedia_Media.SearchMedia_AiRoughData();
				aiRoughData.SaveType = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiRoughData.SaveType");
				aiRoughData.Status = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiRoughData.Status");
				aiRoughData.AiJobId = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiRoughData.AiJobId");
				aiRoughData.AiCategory = _ctx.StringValue("SearchMedia.MediaList["+ i +"].AiRoughData.AiCategory");
				media.AiRoughData = aiRoughData;

				searchMediaResponse_mediaList.Add(media);
			}
			searchMediaResponse.MediaList = searchMediaResponse_mediaList;
        
			return searchMediaResponse;
        }
    }
}
