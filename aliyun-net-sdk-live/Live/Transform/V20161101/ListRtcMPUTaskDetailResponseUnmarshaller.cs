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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class ListRtcMPUTaskDetailResponseUnmarshaller
    {
        public static ListRtcMPUTaskDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRtcMPUTaskDetailResponse listRtcMPUTaskDetailResponse = new ListRtcMPUTaskDetailResponse();

			listRtcMPUTaskDetailResponse.HttpResponse = _ctx.HttpResponse;
			listRtcMPUTaskDetailResponse.RequestId = _ctx.StringValue("ListRtcMPUTaskDetail.RequestId");

			List<ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask> listRtcMPUTaskDetailResponse_mPUTasks = new List<ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask>();
			for (int i = 0; i < _ctx.Length("ListRtcMPUTaskDetail.MPUTasks.Length"); i++) {
				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask mpuTask = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask();
				mpuTask.AppId = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].AppId");
				mpuTask.ChannelId = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].ChannelId");
				mpuTask.TaskId = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TaskId");
				mpuTask.MixMode = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].MixMode");
				mpuTask.StreamURL = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].StreamURL");
				mpuTask.Region = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].Region");

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SingleSubParams singleSubParams = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SingleSubParams();
				singleSubParams.SourceType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SingleSubParams.SourceType");
				singleSubParams.StreamType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SingleSubParams.StreamType");
				singleSubParams.UserId = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SingleSubParams.UserId");
				mpuTask.SingleSubParams = singleSubParams;

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams transcodeParams = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams();

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Background background = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Background();
				background.RenderMode = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Background.RenderMode");
				background.URL = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Background.URL");
				transcodeParams.Background = background;

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_EncodeParams encodeParams = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_EncodeParams();
				encodeParams.AudioOnly = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.AudioOnly");
				encodeParams.AudioBitrate = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.AudioBitrate");
				encodeParams.AudioChannels = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.AudioChannels");
				encodeParams.AudioSampleRate = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.AudioSampleRate");
				encodeParams.VideoCodec = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.VideoCodec");
				encodeParams.VideoBitrate = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.VideoBitrate");
				encodeParams.VideoFramerate = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.VideoFramerate");
				encodeParams.VideoGop = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.VideoGop");
				encodeParams.VideoHeight = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.VideoHeight");
				encodeParams.VideoWidth = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.VideoWidth");
				encodeParams.EnhancedParam = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.EncodeParams.EnhancedParam");
				transcodeParams.EncodeParams = encodeParams;

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout layout = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout();
				layout.LayoutMode = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.LayoutMode");

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_MaxVideoUser maxVideoUser = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_MaxVideoUser();
				maxVideoUser.SourceType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.MaxVideoUser.SourceType");
				maxVideoUser.StreamType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.MaxVideoUser.StreamType");
				maxVideoUser.UserId = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.MaxVideoUser.UserId");
				layout.MaxVideoUser = maxVideoUser;

				List<ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_UserPane> layout_userPanes = new List<ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_UserPane>();
				for (int j = 0; j < _ctx.Length("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes.Length"); j++) {
					ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_UserPane userPane = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_UserPane();
					userPane.Height = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].Height");
					userPane.Width = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].Width");
					userPane.X = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].X");
					userPane.Y = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].Y");
					userPane.ZOrder = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].ZOrder");
					userPane.BackgroundImageUrl = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].BackgroundImageUrl");
					userPane.RenderMode = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].RenderMode");

					ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_UserPane.ListRtcMPUTaskDetail_UserInfo1 userInfo1 = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_Layout.ListRtcMPUTaskDetail_UserPane.ListRtcMPUTaskDetail_UserInfo1();
					userInfo1.SourceType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].UserInfo.SourceType");
					userInfo1.UserId = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.Layout.UserPanes["+ j +"].UserInfo.UserId");
					userPane.UserInfo1 = userInfo1;

					layout_userPanes.Add(userPane);
				}
				layout.UserPanes = layout_userPanes;
				transcodeParams.Layout = layout;

				List<ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_UserInfo> transcodeParams_userInfos = new List<ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_UserInfo>();
				for (int j = 0; j < _ctx.Length("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.UserInfos.Length"); j++) {
					ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_UserInfo userInfo = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_TranscodeParams.ListRtcMPUTaskDetail_UserInfo();
					userInfo.UserId = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.UserInfos["+ j +"].UserId");
					userInfo.SourceType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.UserInfos["+ j +"].SourceType");
					userInfo.StreamType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].TranscodeParams.UserInfos["+ j +"].StreamType");

					transcodeParams_userInfos.Add(userInfo);
				}
				transcodeParams.UserInfos = transcodeParams_userInfos;
				mpuTask.TranscodeParams = transcodeParams;

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SeiParams seiParams = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SeiParams();
				seiParams.PayloadType = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SeiParams.PayloadType");

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SeiParams.ListRtcMPUTaskDetail_LayoutVolume layoutVolume = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SeiParams.ListRtcMPUTaskDetail_LayoutVolume();
				layoutVolume.FollowIdr = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SeiParams.LayoutVolume.FollowIdr");
				layoutVolume.Interval = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SeiParams.LayoutVolume.Interval");
				seiParams.LayoutVolume = layoutVolume;

				ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SeiParams.ListRtcMPUTaskDetail_PassThrough passThrough = new ListRtcMPUTaskDetailResponse.ListRtcMPUTaskDetail_MpuTask.ListRtcMPUTaskDetail_SeiParams.ListRtcMPUTaskDetail_PassThrough();
				passThrough.FollowIdr = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SeiParams.PassThrough.FollowIdr");
				passThrough.Interval = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SeiParams.PassThrough.Interval");
				passThrough.PayloadContent = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SeiParams.PassThrough.PayloadContent");
				passThrough.PayloadContentKey = _ctx.StringValue("ListRtcMPUTaskDetail.MPUTasks["+ i +"].SeiParams.PassThrough.PayloadContentKey");
				seiParams.PassThrough = passThrough;
				mpuTask.SeiParams = seiParams;

				listRtcMPUTaskDetailResponse_mPUTasks.Add(mpuTask);
			}
			listRtcMPUTaskDetailResponse.MPUTasks = listRtcMPUTaskDetailResponse_mPUTasks;
        
			return listRtcMPUTaskDetailResponse;
        }
    }
}
