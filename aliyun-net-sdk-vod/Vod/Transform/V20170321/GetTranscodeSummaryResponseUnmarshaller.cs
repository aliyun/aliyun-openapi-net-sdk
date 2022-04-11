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
    public class GetTranscodeSummaryResponseUnmarshaller
    {
        public static GetTranscodeSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTranscodeSummaryResponse getTranscodeSummaryResponse = new GetTranscodeSummaryResponse();

			getTranscodeSummaryResponse.HttpResponse = _ctx.HttpResponse;
			getTranscodeSummaryResponse.RequestId = _ctx.StringValue("GetTranscodeSummary.RequestId");

			List<string> getTranscodeSummaryResponse_nonExistVideoIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTranscodeSummary.NonExistVideoIds.Length"); i++) {
				getTranscodeSummaryResponse_nonExistVideoIds.Add(_ctx.StringValue("GetTranscodeSummary.NonExistVideoIds["+ i +"]"));
			}
			getTranscodeSummaryResponse.NonExistVideoIds = getTranscodeSummaryResponse_nonExistVideoIds;

			List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary> getTranscodeSummaryResponse_transcodeSummaryList = new List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary>();
			for (int i = 0; i < _ctx.Length("GetTranscodeSummary.TranscodeSummaryList.Length"); i++) {
				GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary transcodeSummary = new GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary();
				transcodeSummary.CreationTime = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].CreationTime");
				transcodeSummary.Trigger = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].Trigger");
				transcodeSummary.VideoId = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].VideoId");
				transcodeSummary.CompleteTime = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].CompleteTime");
				transcodeSummary.TranscodeStatus = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeStatus");
				transcodeSummary.TranscodeTemplateGroupId = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeTemplateGroupId");

				List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary> transcodeSummary_transcodeJobInfoSummaryList = new List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary>();
				for (int j = 0; j < _ctx.Length("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList.Length"); j++) {
					GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary transcodeJobInfoSummary = new GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary();
					transcodeJobInfoSummary.CreationTime = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].CreationTime");
					transcodeJobInfoSummary.ErrorMessage = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].ErrorMessage");
					transcodeJobInfoSummary.Encryption = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Encryption");
					transcodeJobInfoSummary.Height = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Height");
					transcodeJobInfoSummary.TranscodeProgress = _ctx.LongValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].TranscodeProgress");
					transcodeJobInfoSummary.TranscodeTemplateId = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].TranscodeTemplateId");
					transcodeJobInfoSummary.Bitrate = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Bitrate");
					transcodeJobInfoSummary.Definition = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Definition");
					transcodeJobInfoSummary.ErrorCode = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].ErrorCode");
					transcodeJobInfoSummary.CompleteTime = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].CompleteTime");
					transcodeJobInfoSummary.Width = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Width");
					transcodeJobInfoSummary.Duration = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Duration");
					transcodeJobInfoSummary.Fps = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Fps");
					transcodeJobInfoSummary.TranscodeJobStatus = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].TranscodeJobStatus");
					transcodeJobInfoSummary.Filesize = _ctx.LongValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Filesize");
					transcodeJobInfoSummary.Format = _ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Format");

					List<string> transcodeJobInfoSummary_watermarkIdList = new List<string>();
					for (int k = 0; k < _ctx.Length("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].WatermarkIdList.Length"); k++) {
						transcodeJobInfoSummary_watermarkIdList.Add(_ctx.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].WatermarkIdList["+ k +"]"));
					}
					transcodeJobInfoSummary.WatermarkIdList = transcodeJobInfoSummary_watermarkIdList;

					transcodeSummary_transcodeJobInfoSummaryList.Add(transcodeJobInfoSummary);
				}
				transcodeSummary.TranscodeJobInfoSummaryList = transcodeSummary_transcodeJobInfoSummaryList;

				getTranscodeSummaryResponse_transcodeSummaryList.Add(transcodeSummary);
			}
			getTranscodeSummaryResponse.TranscodeSummaryList = getTranscodeSummaryResponse_transcodeSummaryList;
        
			return getTranscodeSummaryResponse;
        }
    }
}
