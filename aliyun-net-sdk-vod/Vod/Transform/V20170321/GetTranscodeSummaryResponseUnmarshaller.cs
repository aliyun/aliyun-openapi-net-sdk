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
        public static GetTranscodeSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			GetTranscodeSummaryResponse getTranscodeSummaryResponse = new GetTranscodeSummaryResponse();

			getTranscodeSummaryResponse.HttpResponse = context.HttpResponse;
			getTranscodeSummaryResponse.RequestId = context.StringValue("GetTranscodeSummary.RequestId");

			List<string> getTranscodeSummaryResponse_nonExistVideoIds = new List<string>();
			for (int i = 0; i < context.Length("GetTranscodeSummary.NonExistVideoIds.Length"); i++) {
				getTranscodeSummaryResponse_nonExistVideoIds.Add(context.StringValue("GetTranscodeSummary.NonExistVideoIds["+ i +"]"));
			}
			getTranscodeSummaryResponse.NonExistVideoIds = getTranscodeSummaryResponse_nonExistVideoIds;

			List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary> getTranscodeSummaryResponse_transcodeSummaryList = new List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary>();
			for (int i = 0; i < context.Length("GetTranscodeSummary.TranscodeSummaryList.Length"); i++) {
				GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary transcodeSummary = new GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary();
				transcodeSummary.VideoId = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].VideoId");
				transcodeSummary.TranscodeStatus = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeStatus");
				transcodeSummary.CreationTime = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].CreationTime");
				transcodeSummary.CompleteTime = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].CompleteTime");
				transcodeSummary.Trigger = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].Trigger");
				transcodeSummary.TranscodeTemplateGroupId = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeTemplateGroupId");

				List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary> transcodeSummary_transcodeJobInfoSummaryList = new List<GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary>();
				for (int j = 0; j < context.Length("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList.Length"); j++) {
					GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary transcodeJobInfoSummary = new GetTranscodeSummaryResponse.GetTranscodeSummary_TranscodeSummary.GetTranscodeSummary_TranscodeJobInfoSummary();
					transcodeJobInfoSummary.TranscodeTemplateId = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].TranscodeTemplateId");
					transcodeJobInfoSummary.TranscodeJobStatus = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].TranscodeJobStatus");
					transcodeJobInfoSummary.CreationTime = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].CreationTime");
					transcodeJobInfoSummary.CompleteTime = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].CompleteTime");
					transcodeJobInfoSummary.TranscodeProgress = context.LongValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].TranscodeProgress");
					transcodeJobInfoSummary.ErrorCode = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].ErrorCode");
					transcodeJobInfoSummary.ErrorMessage = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].ErrorMessage");
					transcodeJobInfoSummary.Definition = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Definition");
					transcodeJobInfoSummary.Encryption = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Encryption");
					transcodeJobInfoSummary.Width = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Width");
					transcodeJobInfoSummary.Height = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Height");
					transcodeJobInfoSummary.Bitrate = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Bitrate");
					transcodeJobInfoSummary.Fps = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Fps");
					transcodeJobInfoSummary.Format = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Format");
					transcodeJobInfoSummary.Duration = context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Duration");
					transcodeJobInfoSummary.Filesize = context.LongValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].Filesize");

					List<string> transcodeJobInfoSummary_watermarkIdList = new List<string>();
					for (int k = 0; k < context.Length("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].WatermarkIdList.Length"); k++) {
						transcodeJobInfoSummary_watermarkIdList.Add(context.StringValue("GetTranscodeSummary.TranscodeSummaryList["+ i +"].TranscodeJobInfoSummaryList["+ j +"].WatermarkIdList["+ k +"]"));
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
