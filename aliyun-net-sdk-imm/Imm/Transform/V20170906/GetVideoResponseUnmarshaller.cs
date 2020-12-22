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
        public static GetVideoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVideoResponse getVideoResponse = new GetVideoResponse();

			getVideoResponse.HttpResponse = _ctx.HttpResponse;
			getVideoResponse.RequestId = _ctx.StringValue("GetVideo.RequestId");
			getVideoResponse.SetId = _ctx.StringValue("GetVideo.SetId");
			getVideoResponse.VideoUri = _ctx.StringValue("GetVideo.VideoUri");
			getVideoResponse.RemarksA = _ctx.StringValue("GetVideo.RemarksA");
			getVideoResponse.RemarksB = _ctx.StringValue("GetVideo.RemarksB");
			getVideoResponse.CreateTime = _ctx.StringValue("GetVideo.CreateTime");
			getVideoResponse.ModifyTime = _ctx.StringValue("GetVideo.ModifyTime");
			getVideoResponse.VideoWidth = _ctx.IntegerValue("GetVideo.VideoWidth");
			getVideoResponse.VideoHeight = _ctx.IntegerValue("GetVideo.VideoHeight");
			getVideoResponse.VideoFormat = _ctx.StringValue("GetVideo.VideoFormat");
			getVideoResponse.VideoDuration = _ctx.FloatValue("GetVideo.VideoDuration");
			getVideoResponse.FileSize = _ctx.IntegerValue("GetVideo.FileSize");
			getVideoResponse.VideoFrames = _ctx.IntegerValue("GetVideo.VideoFrames");
			getVideoResponse.SourceType = _ctx.StringValue("GetVideo.SourceType");
			getVideoResponse.SourceUri = _ctx.StringValue("GetVideo.SourceUri");
			getVideoResponse.SourcePosition = _ctx.StringValue("GetVideo.SourcePosition");
			getVideoResponse.ProcessStatus = _ctx.StringValue("GetVideo.ProcessStatus");
			getVideoResponse.ProcessModifyTime = _ctx.StringValue("GetVideo.ProcessModifyTime");
			getVideoResponse.VideoTagsStatus = _ctx.StringValue("GetVideo.VideoTagsStatus");
			getVideoResponse.VideoTagsModifyTime = _ctx.StringValue("GetVideo.VideoTagsModifyTime");
			getVideoResponse.CelebrityStatus = _ctx.StringValue("GetVideo.CelebrityStatus");
			getVideoResponse.CelebrityModifyTime = _ctx.StringValue("GetVideo.CelebrityModifyTime");
			getVideoResponse.ProcessFailReason = _ctx.StringValue("GetVideo.ProcessFailReason");
			getVideoResponse.VideoTagsFailReason = _ctx.StringValue("GetVideo.VideoTagsFailReason");
			getVideoResponse.CelebrityFailReason = _ctx.StringValue("GetVideo.CelebrityFailReason");
			getVideoResponse.RemarksC = _ctx.StringValue("GetVideo.RemarksC");
			getVideoResponse.RemarksD = _ctx.StringValue("GetVideo.RemarksD");
			getVideoResponse.ExternalId = _ctx.StringValue("GetVideo.ExternalId");
			getVideoResponse.VideoFacesStatus = _ctx.StringValue("GetVideo.VideoFacesStatus");
			getVideoResponse.VideoFacesFailReason = _ctx.StringValue("GetVideo.VideoFacesFailReason");
			getVideoResponse.VideoFacesModifyTime = _ctx.StringValue("GetVideo.VideoFacesModifyTime");
			getVideoResponse.VideoFrameTagsStatus = _ctx.StringValue("GetVideo.VideoFrameTagsStatus");
			getVideoResponse.VideoFrameTagsFailReason = _ctx.StringValue("GetVideo.VideoFrameTagsFailReason");
			getVideoResponse.VideoFrameTagsModifyTime = _ctx.StringValue("GetVideo.VideoFrameTagsModifyTime");
			getVideoResponse.VideoSTTStatus = _ctx.StringValue("GetVideo.VideoSTTStatus");
			getVideoResponse.VideoSTTFailReason = _ctx.StringValue("GetVideo.VideoSTTFailReason");
			getVideoResponse.VideoSTTModifyTime = _ctx.StringValue("GetVideo.VideoSTTModifyTime");
			getVideoResponse.VideoOCRStatus = _ctx.StringValue("GetVideo.VideoOCRStatus");
			getVideoResponse.VideoOCRFailReason = _ctx.StringValue("GetVideo.VideoOCRFailReason");
			getVideoResponse.VideoOCRModifyTime = _ctx.StringValue("GetVideo.VideoOCRModifyTime");
			getVideoResponse.VideoInfo = _ctx.StringValue("GetVideo.VideoInfo");

			List<GetVideoResponse.GetVideo_CelebrityItem> getVideoResponse_celebrity = new List<GetVideoResponse.GetVideo_CelebrityItem>();
			for (int i = 0; i < _ctx.Length("GetVideo.Celebrity.Length"); i++) {
				GetVideoResponse.GetVideo_CelebrityItem celebrityItem = new GetVideoResponse.GetVideo_CelebrityItem();
				celebrityItem.CelebrityName = _ctx.StringValue("GetVideo.Celebrity["+ i +"].CelebrityName");
				celebrityItem.CelebrityNum = _ctx.IntegerValue("GetVideo.Celebrity["+ i +"].CelebrityNum");
				celebrityItem.CelebrityLibraryName = _ctx.StringValue("GetVideo.Celebrity["+ i +"].CelebrityLibraryName");

				getVideoResponse_celebrity.Add(celebrityItem);
			}
			getVideoResponse.Celebrity = getVideoResponse_celebrity;

			List<GetVideoResponse.GetVideo_VideoTagsItem> getVideoResponse_videoTags = new List<GetVideoResponse.GetVideo_VideoTagsItem>();
			for (int i = 0; i < _ctx.Length("GetVideo.VideoTags.Length"); i++) {
				GetVideoResponse.GetVideo_VideoTagsItem videoTagsItem = new GetVideoResponse.GetVideo_VideoTagsItem();
				videoTagsItem.TagName = _ctx.StringValue("GetVideo.VideoTags["+ i +"].TagName");
				videoTagsItem.ParentTagName = _ctx.StringValue("GetVideo.VideoTags["+ i +"].ParentTagName");
				videoTagsItem.TagConfidence = _ctx.FloatValue("GetVideo.VideoTags["+ i +"].TagConfidence");
				videoTagsItem.TagLevel = _ctx.IntegerValue("GetVideo.VideoTags["+ i +"].TagLevel");

				getVideoResponse_videoTags.Add(videoTagsItem);
			}
			getVideoResponse.VideoTags = getVideoResponse_videoTags;

			List<GetVideoResponse.GetVideo_PersonsItem> getVideoResponse_persons = new List<GetVideoResponse.GetVideo_PersonsItem>();
			for (int i = 0; i < _ctx.Length("GetVideo.Persons.Length"); i++) {
				GetVideoResponse.GetVideo_PersonsItem personsItem = new GetVideoResponse.GetVideo_PersonsItem();
				personsItem.PersonId = _ctx.StringValue("GetVideo.Persons["+ i +"].PersonId");
				personsItem.Age = _ctx.IntegerValue("GetVideo.Persons["+ i +"].Age");
				personsItem.AgeConfidence = _ctx.FloatValue("GetVideo.Persons["+ i +"].AgeConfidence");
				personsItem.Gender = _ctx.StringValue("GetVideo.Persons["+ i +"].Gender");
				personsItem.GenderConfidence = _ctx.FloatValue("GetVideo.Persons["+ i +"].GenderConfidence");

				getVideoResponse_persons.Add(personsItem);
			}
			getVideoResponse.Persons = getVideoResponse_persons;
        
			return getVideoResponse;
        }
    }
}
