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
			getVideoResponse.ModifyTime = _ctx.StringValue("GetVideo.ModifyTime");
			getVideoResponse.ProcessStatus = _ctx.StringValue("GetVideo.ProcessStatus");
			getVideoResponse.VideoWidth = _ctx.IntegerValue("GetVideo.VideoWidth");
			getVideoResponse.SourceUri = _ctx.StringValue("GetVideo.SourceUri");
			getVideoResponse.SourceType = _ctx.StringValue("GetVideo.SourceType");
			getVideoResponse.VideoInfo = _ctx.StringValue("GetVideo.VideoInfo");
			getVideoResponse.RemarksA = _ctx.StringValue("GetVideo.RemarksA");
			getVideoResponse.VideoFrameTagsModifyTime = _ctx.StringValue("GetVideo.VideoFrameTagsModifyTime");
			getVideoResponse.RemarksB = _ctx.StringValue("GetVideo.RemarksB");
			getVideoResponse.VideoFacesFailReason = _ctx.StringValue("GetVideo.VideoFacesFailReason");
			getVideoResponse.VideoFacesStatus = _ctx.StringValue("GetVideo.VideoFacesStatus");
			getVideoResponse.VideoOCRModifyTime = _ctx.StringValue("GetVideo.VideoOCRModifyTime");
			getVideoResponse.RemarksC = _ctx.StringValue("GetVideo.RemarksC");
			getVideoResponse.RemarksD = _ctx.StringValue("GetVideo.RemarksD");
			getVideoResponse.VideoHeight = _ctx.IntegerValue("GetVideo.VideoHeight");
			getVideoResponse.SourcePosition = _ctx.StringValue("GetVideo.SourcePosition");
			getVideoResponse.VideoOCRFailReason = _ctx.StringValue("GetVideo.VideoOCRFailReason");
			getVideoResponse.VideoFrameTagsStatus = _ctx.StringValue("GetVideo.VideoFrameTagsStatus");
			getVideoResponse.VideoTagsFailReason = _ctx.StringValue("GetVideo.VideoTagsFailReason");
			getVideoResponse.VideoTagsModifyTime = _ctx.StringValue("GetVideo.VideoTagsModifyTime");
			getVideoResponse.VideoOCRStatus = _ctx.StringValue("GetVideo.VideoOCRStatus");
			getVideoResponse.VideoFrames = _ctx.IntegerValue("GetVideo.VideoFrames");
			getVideoResponse.RequestId = _ctx.StringValue("GetVideo.RequestId");
			getVideoResponse.VideoSTTModifyTime = _ctx.StringValue("GetVideo.VideoSTTModifyTime");
			getVideoResponse.ProcessModifyTime = _ctx.StringValue("GetVideo.ProcessModifyTime");
			getVideoResponse.ProcessFailReason = _ctx.StringValue("GetVideo.ProcessFailReason");
			getVideoResponse.VideoSTTFailReason = _ctx.StringValue("GetVideo.VideoSTTFailReason");
			getVideoResponse.ExternalId = _ctx.StringValue("GetVideo.ExternalId");
			getVideoResponse.CreateTime = _ctx.StringValue("GetVideo.CreateTime");
			getVideoResponse.VideoUri = _ctx.StringValue("GetVideo.VideoUri");
			getVideoResponse.VideoFormat = _ctx.StringValue("GetVideo.VideoFormat");
			getVideoResponse.VideoFrameTagsFailReason = _ctx.StringValue("GetVideo.VideoFrameTagsFailReason");
			getVideoResponse.VideoSTTStatus = _ctx.StringValue("GetVideo.VideoSTTStatus");
			getVideoResponse.VideoFacesModifyTime = _ctx.StringValue("GetVideo.VideoFacesModifyTime");
			getVideoResponse.CelebrityModifyTime = _ctx.StringValue("GetVideo.CelebrityModifyTime");
			getVideoResponse.VideoDuration = _ctx.FloatValue("GetVideo.VideoDuration");
			getVideoResponse.CelebrityFailReason = _ctx.StringValue("GetVideo.CelebrityFailReason");
			getVideoResponse.CelebrityStatus = _ctx.StringValue("GetVideo.CelebrityStatus");
			getVideoResponse.SetId = _ctx.StringValue("GetVideo.SetId");
			getVideoResponse.VideoTagsStatus = _ctx.StringValue("GetVideo.VideoTagsStatus");
			getVideoResponse.FileSize = _ctx.IntegerValue("GetVideo.FileSize");

			List<GetVideoResponse.GetVideo_VideoTagsItem> getVideoResponse_videoTags = new List<GetVideoResponse.GetVideo_VideoTagsItem>();
			for (int i = 0; i < _ctx.Length("GetVideo.VideoTags.Length"); i++) {
				GetVideoResponse.GetVideo_VideoTagsItem videoTagsItem = new GetVideoResponse.GetVideo_VideoTagsItem();
				videoTagsItem.TagConfidence = _ctx.FloatValue("GetVideo.VideoTags["+ i +"].TagConfidence");
				videoTagsItem.TagName = _ctx.StringValue("GetVideo.VideoTags["+ i +"].TagName");
				videoTagsItem.TagLevel = _ctx.IntegerValue("GetVideo.VideoTags["+ i +"].TagLevel");
				videoTagsItem.ParentTagName = _ctx.StringValue("GetVideo.VideoTags["+ i +"].ParentTagName");

				getVideoResponse_videoTags.Add(videoTagsItem);
			}
			getVideoResponse.VideoTags = getVideoResponse_videoTags;

			List<GetVideoResponse.GetVideo_PersonsItem> getVideoResponse_persons = new List<GetVideoResponse.GetVideo_PersonsItem>();
			for (int i = 0; i < _ctx.Length("GetVideo.Persons.Length"); i++) {
				GetVideoResponse.GetVideo_PersonsItem personsItem = new GetVideoResponse.GetVideo_PersonsItem();
				personsItem.PersonId = _ctx.StringValue("GetVideo.Persons["+ i +"].PersonId");
				personsItem.GenderConfidence = _ctx.FloatValue("GetVideo.Persons["+ i +"].GenderConfidence");
				personsItem.Gender = _ctx.StringValue("GetVideo.Persons["+ i +"].Gender");
				personsItem.Age = _ctx.IntegerValue("GetVideo.Persons["+ i +"].Age");
				personsItem.AgeConfidence = _ctx.FloatValue("GetVideo.Persons["+ i +"].AgeConfidence");

				getVideoResponse_persons.Add(personsItem);
			}
			getVideoResponse.Persons = getVideoResponse_persons;

			List<GetVideoResponse.GetVideo_CelebrityItem> getVideoResponse_celebrity = new List<GetVideoResponse.GetVideo_CelebrityItem>();
			for (int i = 0; i < _ctx.Length("GetVideo.Celebrity.Length"); i++) {
				GetVideoResponse.GetVideo_CelebrityItem celebrityItem = new GetVideoResponse.GetVideo_CelebrityItem();
				celebrityItem.CelebrityName = _ctx.StringValue("GetVideo.Celebrity["+ i +"].CelebrityName");
				celebrityItem.CelebrityNum = _ctx.IntegerValue("GetVideo.Celebrity["+ i +"].CelebrityNum");
				celebrityItem.CelebrityLibraryName = _ctx.StringValue("GetVideo.Celebrity["+ i +"].CelebrityLibraryName");

				getVideoResponse_celebrity.Add(celebrityItem);
			}
			getVideoResponse.Celebrity = getVideoResponse_celebrity;
        
			return getVideoResponse;
        }
    }
}
