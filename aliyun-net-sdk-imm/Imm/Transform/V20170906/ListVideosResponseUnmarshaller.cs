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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListVideosResponseUnmarshaller
    {
        public static ListVideosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVideosResponse listVideosResponse = new ListVideosResponse();

			listVideosResponse.HttpResponse = _ctx.HttpResponse;
			listVideosResponse.SetId = _ctx.StringValue("ListVideos.SetId");
			listVideosResponse.NextMarker = _ctx.StringValue("ListVideos.NextMarker");
			listVideosResponse.RequestId = _ctx.StringValue("ListVideos.RequestId");

			List<ListVideosResponse.ListVideos_VideosItem> listVideosResponse_videos = new List<ListVideosResponse.ListVideos_VideosItem>();
			for (int i = 0; i < _ctx.Length("ListVideos.Videos.Length"); i++) {
				ListVideosResponse.ListVideos_VideosItem videosItem = new ListVideosResponse.ListVideos_VideosItem();
				videosItem.VideoUri = _ctx.StringValue("ListVideos.Videos["+ i +"].VideoUri");
				videosItem.RemarksA = _ctx.StringValue("ListVideos.Videos["+ i +"].RemarksA");
				videosItem.RemarksB = _ctx.StringValue("ListVideos.Videos["+ i +"].RemarksB");
				videosItem.CreateTime = _ctx.StringValue("ListVideos.Videos["+ i +"].CreateTime");
				videosItem.ModifyTime = _ctx.StringValue("ListVideos.Videos["+ i +"].ModifyTime");
				videosItem.VideoWidth = _ctx.IntegerValue("ListVideos.Videos["+ i +"].VideoWidth");
				videosItem.VideoHeight = _ctx.IntegerValue("ListVideos.Videos["+ i +"].VideoHeight");
				videosItem.VideoFormat = _ctx.StringValue("ListVideos.Videos["+ i +"].VideoFormat");
				videosItem.VideoDuration = _ctx.FloatValue("ListVideos.Videos["+ i +"].VideoDuration");
				videosItem.FileSize = _ctx.IntegerValue("ListVideos.Videos["+ i +"].FileSize");
				videosItem.VideoFrames = _ctx.IntegerValue("ListVideos.Videos["+ i +"].VideoFrames");
				videosItem.SourceType = _ctx.StringValue("ListVideos.Videos["+ i +"].SourceType");
				videosItem.SourceUri = _ctx.StringValue("ListVideos.Videos["+ i +"].SourceUri");
				videosItem.SourcePosition = _ctx.StringValue("ListVideos.Videos["+ i +"].SourcePosition");
				videosItem.ProcessStatus = _ctx.StringValue("ListVideos.Videos["+ i +"].ProcessStatus");
				videosItem.ProcessModifyTime = _ctx.StringValue("ListVideos.Videos["+ i +"].ProcessModifyTime");
				videosItem.VideoTagsStatus = _ctx.StringValue("ListVideos.Videos["+ i +"].VideoTagsStatus");
				videosItem.VideoTagsModifyTime = _ctx.StringValue("ListVideos.Videos["+ i +"].VideoTagsModifyTime");
				videosItem.CelebrityStatus = _ctx.StringValue("ListVideos.Videos["+ i +"].CelebrityStatus");
				videosItem.CelebrityModifyTime = _ctx.StringValue("ListVideos.Videos["+ i +"].CelebrityModifyTime");
				videosItem.CelebrityFailReason = _ctx.StringValue("ListVideos.Videos["+ i +"].CelebrityFailReason");
				videosItem.VideoTagsFailReason = _ctx.StringValue("ListVideos.Videos["+ i +"].VideoTagsFailReason");
				videosItem.ProcessFailReason = _ctx.StringValue("ListVideos.Videos["+ i +"].ProcessFailReason");
				videosItem.RemarksC = _ctx.StringValue("ListVideos.Videos["+ i +"].RemarksC");
				videosItem.RemarksD = _ctx.StringValue("ListVideos.Videos["+ i +"].RemarksD");
				videosItem.ExternalId = _ctx.StringValue("ListVideos.Videos["+ i +"].ExternalId");

				List<ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem> videosItem_videoTags = new List<ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem>();
				for (int j = 0; j < _ctx.Length("ListVideos.Videos["+ i +"].VideoTags.Length"); j++) {
					ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem videoTagsItem = new ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem();
					videoTagsItem.TagName = _ctx.StringValue("ListVideos.Videos["+ i +"].VideoTags["+ j +"].TagName");
					videoTagsItem.ParentTagName = _ctx.StringValue("ListVideos.Videos["+ i +"].VideoTags["+ j +"].ParentTagName");
					videoTagsItem.TagConfidence = _ctx.FloatValue("ListVideos.Videos["+ i +"].VideoTags["+ j +"].TagConfidence");
					videoTagsItem.TagLevel = _ctx.IntegerValue("ListVideos.Videos["+ i +"].VideoTags["+ j +"].TagLevel");

					videosItem_videoTags.Add(videoTagsItem);
				}
				videosItem.VideoTags = videosItem_videoTags;

				List<ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem> videosItem_celebrity = new List<ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem>();
				for (int j = 0; j < _ctx.Length("ListVideos.Videos["+ i +"].Celebrity.Length"); j++) {
					ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem celebrityItem = new ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem();
					celebrityItem.CelebrityName = _ctx.StringValue("ListVideos.Videos["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityNum = _ctx.IntegerValue("ListVideos.Videos["+ i +"].Celebrity["+ j +"].CelebrityNum");
					celebrityItem.CelebrityLibraryName = _ctx.StringValue("ListVideos.Videos["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					videosItem_celebrity.Add(celebrityItem);
				}
				videosItem.Celebrity = videosItem_celebrity;

				List<ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem> videosItem_persons = new List<ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem>();
				for (int j = 0; j < _ctx.Length("ListVideos.Videos["+ i +"].Persons.Length"); j++) {
					ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem personsItem = new ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem();
					personsItem.PersonId = _ctx.StringValue("ListVideos.Videos["+ i +"].Persons["+ j +"].PersonId");
					personsItem.Age = _ctx.IntegerValue("ListVideos.Videos["+ i +"].Persons["+ j +"].Age");
					personsItem.AgeConfidence = _ctx.FloatValue("ListVideos.Videos["+ i +"].Persons["+ j +"].AgeConfidence");
					personsItem.Gender = _ctx.StringValue("ListVideos.Videos["+ i +"].Persons["+ j +"].Gender");
					personsItem.GenderConfidence = _ctx.FloatValue("ListVideos.Videos["+ i +"].Persons["+ j +"].GenderConfidence");

					videosItem_persons.Add(personsItem);
				}
				videosItem.Persons = videosItem_persons;

				listVideosResponse_videos.Add(videosItem);
			}
			listVideosResponse.Videos = listVideosResponse_videos;
        
			return listVideosResponse;
        }
    }
}
