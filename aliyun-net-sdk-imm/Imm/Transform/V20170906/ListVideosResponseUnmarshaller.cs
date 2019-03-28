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
        public static ListVideosResponse Unmarshall(UnmarshallerContext context)
        {
			ListVideosResponse listVideosResponse = new ListVideosResponse();

			listVideosResponse.HttpResponse = context.HttpResponse;
			listVideosResponse.SetId = context.StringValue("ListVideos.SetId");
			listVideosResponse.NextMarker = context.StringValue("ListVideos.NextMarker");
			listVideosResponse.RequestId = context.StringValue("ListVideos.RequestId");

			List<ListVideosResponse.ListVideos_VideosItem> listVideosResponse_videos = new List<ListVideosResponse.ListVideos_VideosItem>();
			for (int i = 0; i < context.Length("ListVideos.Videos.Length"); i++) {
				ListVideosResponse.ListVideos_VideosItem videosItem = new ListVideosResponse.ListVideos_VideosItem();
				videosItem.VideoUri = context.StringValue("ListVideos.Videos["+ i +"].VideoUri");
				videosItem.RemarksA = context.StringValue("ListVideos.Videos["+ i +"].RemarksA");
				videosItem.RemarksB = context.StringValue("ListVideos.Videos["+ i +"].RemarksB");
				videosItem.CreateTime = context.StringValue("ListVideos.Videos["+ i +"].CreateTime");
				videosItem.ModifyTime = context.StringValue("ListVideos.Videos["+ i +"].ModifyTime");
				videosItem.VideoWidth = context.IntegerValue("ListVideos.Videos["+ i +"].VideoWidth");
				videosItem.VideoHeight = context.IntegerValue("ListVideos.Videos["+ i +"].VideoHeight");
				videosItem.VideoFormat = context.StringValue("ListVideos.Videos["+ i +"].VideoFormat");
				videosItem.VideoDuration = context.FloatValue("ListVideos.Videos["+ i +"].VideoDuration");
				videosItem.FileSize = context.IntegerValue("ListVideos.Videos["+ i +"].FileSize");
				videosItem.VideoFrames = context.IntegerValue("ListVideos.Videos["+ i +"].VideoFrames");
				videosItem.SourceType = context.StringValue("ListVideos.Videos["+ i +"].SourceType");
				videosItem.SourceUri = context.StringValue("ListVideos.Videos["+ i +"].SourceUri");
				videosItem.SourcePosition = context.StringValue("ListVideos.Videos["+ i +"].SourcePosition");
				videosItem.ProcessStatus = context.StringValue("ListVideos.Videos["+ i +"].ProcessStatus");
				videosItem.ProcessModifyTime = context.StringValue("ListVideos.Videos["+ i +"].ProcessModifyTime");
				videosItem.VideoTagsStatus = context.StringValue("ListVideos.Videos["+ i +"].VideoTagsStatus");
				videosItem.VideoTagsModifyTime = context.StringValue("ListVideos.Videos["+ i +"].VideoTagsModifyTime");
				videosItem.CelebrityStatus = context.StringValue("ListVideos.Videos["+ i +"].CelebrityStatus");
				videosItem.CelebrityModifyTime = context.StringValue("ListVideos.Videos["+ i +"].CelebrityModifyTime");
				videosItem.CelebrityFailReason = context.StringValue("ListVideos.Videos["+ i +"].CelebrityFailReason");
				videosItem.VideoTagsFailReason = context.StringValue("ListVideos.Videos["+ i +"].VideoTagsFailReason");
				videosItem.ProcessFailReason = context.StringValue("ListVideos.Videos["+ i +"].ProcessFailReason");
				videosItem.RemarksC = context.StringValue("ListVideos.Videos["+ i +"].RemarksC");
				videosItem.RemarksD = context.StringValue("ListVideos.Videos["+ i +"].RemarksD");
				videosItem.ExternalId = context.StringValue("ListVideos.Videos["+ i +"].ExternalId");

				List<ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem> videosItem_videoTags = new List<ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem>();
				for (int j = 0; j < context.Length("ListVideos.Videos["+ i +"].VideoTags.Length"); j++) {
					ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem videoTagsItem = new ListVideosResponse.ListVideos_VideosItem.ListVideos_VideoTagsItem();
					videoTagsItem.VideoTagName = context.StringValue("ListVideos.Videos["+ i +"].VideoTags["+ j +"].VideoTagName");
					videoTagsItem.VideoTagEnName = context.StringValue("ListVideos.Videos["+ i +"].VideoTags["+ j +"].VideoTagEnName");
					videoTagsItem.VideoTagConfidence = context.FloatValue("ListVideos.Videos["+ i +"].VideoTags["+ j +"].VideoTagConfidence");

					videosItem_videoTags.Add(videoTagsItem);
				}
				videosItem.VideoTags = videosItem_videoTags;

				List<ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem> videosItem_celebrity = new List<ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem>();
				for (int j = 0; j < context.Length("ListVideos.Videos["+ i +"].Celebrity.Length"); j++) {
					ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem celebrityItem = new ListVideosResponse.ListVideos_VideosItem.ListVideos_CelebrityItem();
					celebrityItem.CelebrityName = context.StringValue("ListVideos.Videos["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityNum = context.IntegerValue("ListVideos.Videos["+ i +"].Celebrity["+ j +"].CelebrityNum");
					celebrityItem.CelebrityLibraryName = context.StringValue("ListVideos.Videos["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					videosItem_celebrity.Add(celebrityItem);
				}
				videosItem.Celebrity = videosItem_celebrity;

				List<ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem> videosItem_persons = new List<ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem>();
				for (int j = 0; j < context.Length("ListVideos.Videos["+ i +"].Persons.Length"); j++) {
					ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem personsItem = new ListVideosResponse.ListVideos_VideosItem.ListVideos_PersonsItem();
					personsItem.PersonId = context.StringValue("ListVideos.Videos["+ i +"].Persons["+ j +"].PersonId");
					personsItem.Age = context.IntegerValue("ListVideos.Videos["+ i +"].Persons["+ j +"].Age");
					personsItem.AgeConfidence = context.FloatValue("ListVideos.Videos["+ i +"].Persons["+ j +"].AgeConfidence");
					personsItem.Gender = context.StringValue("ListVideos.Videos["+ i +"].Persons["+ j +"].Gender");
					personsItem.GenderConfidence = context.FloatValue("ListVideos.Videos["+ i +"].Persons["+ j +"].GenderConfidence");

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
