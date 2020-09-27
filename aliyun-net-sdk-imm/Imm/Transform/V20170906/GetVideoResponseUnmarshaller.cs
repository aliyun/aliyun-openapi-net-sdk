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
    public class GetVideoResponseUnmarshaller
    {
        public static GetVideoResponse Unmarshall(UnmarshallerContext context)
        {
			GetVideoResponse getVideoResponse = new GetVideoResponse();

			getVideoResponse.HttpResponse = context.HttpResponse;
			getVideoResponse.RequestId = context.StringValue("GetVideo.RequestId");
			getVideoResponse.SetId = context.StringValue("GetVideo.SetId");
			getVideoResponse.VideoUri = context.StringValue("GetVideo.VideoUri");
			getVideoResponse.RemarksA = context.StringValue("GetVideo.RemarksA");
			getVideoResponse.RemarksB = context.StringValue("GetVideo.RemarksB");
			getVideoResponse.CreateTime = context.StringValue("GetVideo.CreateTime");
			getVideoResponse.ModifyTime = context.StringValue("GetVideo.ModifyTime");
			getVideoResponse.VideoWidth = context.IntegerValue("GetVideo.VideoWidth");
			getVideoResponse.VideoHeight = context.IntegerValue("GetVideo.VideoHeight");
			getVideoResponse.VideoFormat = context.StringValue("GetVideo.VideoFormat");
			getVideoResponse.VideoDuration = context.FloatValue("GetVideo.VideoDuration");
			getVideoResponse.FileSize = context.IntegerValue("GetVideo.FileSize");
			getVideoResponse.VideoFrames = context.IntegerValue("GetVideo.VideoFrames");
			getVideoResponse.SourceType = context.StringValue("GetVideo.SourceType");
			getVideoResponse.SourceUri = context.StringValue("GetVideo.SourceUri");
			getVideoResponse.SourcePosition = context.StringValue("GetVideo.SourcePosition");
			getVideoResponse.ProcessStatus = context.StringValue("GetVideo.ProcessStatus");
			getVideoResponse.ProcessModifyTime = context.StringValue("GetVideo.ProcessModifyTime");
			getVideoResponse.VideoTagsStatus = context.StringValue("GetVideo.VideoTagsStatus");
			getVideoResponse.VideoTagsModifyTime = context.StringValue("GetVideo.VideoTagsModifyTime");
			getVideoResponse.CelebrityStatus = context.StringValue("GetVideo.CelebrityStatus");
			getVideoResponse.CelebrityModifyTime = context.StringValue("GetVideo.CelebrityModifyTime");
			getVideoResponse.ProcessFailReason = context.StringValue("GetVideo.ProcessFailReason");
			getVideoResponse.VideoTagsFailReason = context.StringValue("GetVideo.VideoTagsFailReason");
			getVideoResponse.CelebrityFailReason = context.StringValue("GetVideo.CelebrityFailReason");
			getVideoResponse.RemarksC = context.StringValue("GetVideo.RemarksC");
			getVideoResponse.RemarksD = context.StringValue("GetVideo.RemarksD");
			getVideoResponse.ExternalId = context.StringValue("GetVideo.ExternalId");
			getVideoResponse.VideoFacesStatus = context.StringValue("GetVideo.VideoFacesStatus");
			getVideoResponse.VideoFacesFailReason = context.StringValue("GetVideo.VideoFacesFailReason");
			getVideoResponse.VideoFacesModifyTime = context.StringValue("GetVideo.VideoFacesModifyTime");
			getVideoResponse.VideoFrameTagsStatus = context.StringValue("GetVideo.VideoFrameTagsStatus");
			getVideoResponse.VideoFrameTagsFailReason = context.StringValue("GetVideo.VideoFrameTagsFailReason");
			getVideoResponse.VideoFrameTagsModifyTime = context.StringValue("GetVideo.VideoFrameTagsModifyTime");
			getVideoResponse.VideoSTTStatus = context.StringValue("GetVideo.VideoSTTStatus");
			getVideoResponse.VideoSTTFailReason = context.StringValue("GetVideo.VideoSTTFailReason");
			getVideoResponse.VideoSTTModifyTime = context.StringValue("GetVideo.VideoSTTModifyTime");
			getVideoResponse.VideoOCRStatus = context.StringValue("GetVideo.VideoOCRStatus");
			getVideoResponse.VideoOCRFailReason = context.StringValue("GetVideo.VideoOCRFailReason");
			getVideoResponse.VideoOCRModifyTime = context.StringValue("GetVideo.VideoOCRModifyTime");
			getVideoResponse.VideoInfo = context.StringValue("GetVideo.VideoInfo");

			List<GetVideoResponse.GetVideo_CelebrityItem> getVideoResponse_celebrity = new List<GetVideoResponse.GetVideo_CelebrityItem>();
			for (int i = 0; i < context.Length("GetVideo.Celebrity.Length"); i++) {
				GetVideoResponse.GetVideo_CelebrityItem celebrityItem = new GetVideoResponse.GetVideo_CelebrityItem();
				celebrityItem.CelebrityName = context.StringValue("GetVideo.Celebrity["+ i +"].CelebrityName");
				celebrityItem.CelebrityNum = context.IntegerValue("GetVideo.Celebrity["+ i +"].CelebrityNum");
				celebrityItem.CelebrityLibraryName = context.StringValue("GetVideo.Celebrity["+ i +"].CelebrityLibraryName");

				getVideoResponse_celebrity.Add(celebrityItem);
			}
			getVideoResponse.Celebrity = getVideoResponse_celebrity;

			List<GetVideoResponse.GetVideo_VideoTagsItem> getVideoResponse_videoTags = new List<GetVideoResponse.GetVideo_VideoTagsItem>();
			for (int i = 0; i < context.Length("GetVideo.VideoTags.Length"); i++) {
				GetVideoResponse.GetVideo_VideoTagsItem videoTagsItem = new GetVideoResponse.GetVideo_VideoTagsItem();
				videoTagsItem.TagName = context.StringValue("GetVideo.VideoTags["+ i +"].TagName");
				videoTagsItem.ParentTagName = context.StringValue("GetVideo.VideoTags["+ i +"].ParentTagName");
				videoTagsItem.TagConfidence = context.FloatValue("GetVideo.VideoTags["+ i +"].TagConfidence");
				videoTagsItem.TagLevel = context.IntegerValue("GetVideo.VideoTags["+ i +"].TagLevel");

				getVideoResponse_videoTags.Add(videoTagsItem);
			}
			getVideoResponse.VideoTags = getVideoResponse_videoTags;

			List<GetVideoResponse.GetVideo_PersonsItem> getVideoResponse_persons = new List<GetVideoResponse.GetVideo_PersonsItem>();
			for (int i = 0; i < context.Length("GetVideo.Persons.Length"); i++) {
				GetVideoResponse.GetVideo_PersonsItem personsItem = new GetVideoResponse.GetVideo_PersonsItem();
				personsItem.PersonId = context.StringValue("GetVideo.Persons["+ i +"].PersonId");
				personsItem.Age = context.IntegerValue("GetVideo.Persons["+ i +"].Age");
				personsItem.AgeConfidence = context.FloatValue("GetVideo.Persons["+ i +"].AgeConfidence");
				personsItem.Gender = context.StringValue("GetVideo.Persons["+ i +"].Gender");
				personsItem.GenderConfidence = context.FloatValue("GetVideo.Persons["+ i +"].GenderConfidence");

				getVideoResponse_persons.Add(personsItem);
			}
			getVideoResponse.Persons = getVideoResponse_persons;
        
			return getVideoResponse;
        }
    }
}
