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
    public class GetTranscodeTaskResponseUnmarshaller
    {
        public static GetTranscodeTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTranscodeTaskResponse getTranscodeTaskResponse = new GetTranscodeTaskResponse();

			getTranscodeTaskResponse.HttpResponse = _ctx.HttpResponse;
			getTranscodeTaskResponse.RequestId = _ctx.StringValue("GetTranscodeTask.RequestId");

			List<string> getTranscodeTaskResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTranscodeTask.NonExistJobIds.Length"); i++) {
				getTranscodeTaskResponse_nonExistJobIds.Add(_ctx.StringValue("GetTranscodeTask.NonExistJobIds["+ i +"]"));
			}
			getTranscodeTaskResponse.NonExistJobIds = getTranscodeTaskResponse_nonExistJobIds;

			GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask transcodeTask = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask();
			transcodeTask.CreationTime = _ctx.StringValue("GetTranscodeTask.TranscodeTask.CreationTime");
			transcodeTask.Trigger = _ctx.StringValue("GetTranscodeTask.TranscodeTask.Trigger");
			transcodeTask.TaskStatus = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TaskStatus");
			transcodeTask.VideoId = _ctx.StringValue("GetTranscodeTask.TranscodeTask.VideoId");
			transcodeTask.CompleteTime = _ctx.StringValue("GetTranscodeTask.TranscodeTask.CompleteTime");
			transcodeTask.TranscodeTemplateGroupId = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeTemplateGroupId");
			transcodeTask.TranscodeTaskId = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeTaskId");

			List<GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo2> transcodeTask_transcodeJobInfoList1 = new List<GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo2>();
			for (int i = 0; i < _ctx.Length("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList.Length"); i++) {
				GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo2 transcodeJobInfo2 = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo2();
				transcodeJobInfo2.Definition = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].Definition");
				transcodeJobInfo2.CreationTime = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].CreationTime");
				transcodeJobInfo2.InputFileUrl = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].InputFileUrl");
				transcodeJobInfo2.ErrorMessage = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].ErrorMessage");
				transcodeJobInfo2.ErrorCode = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].ErrorCode");
				transcodeJobInfo2.CompleteTime = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].CompleteTime");
				transcodeJobInfo2.TranscodeProgress = _ctx.LongValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeProgress");
				transcodeJobInfo2.Priority = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].Priority");
				transcodeJobInfo2.TranscodeJobStatus = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeJobStatus");
				transcodeJobInfo2.TranscodeTemplateId = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeTemplateId");
				transcodeJobInfo2.TranscodeJobId = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeJobId");

				GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo2.GetTranscodeTask_OutputFile3 outputFile3 = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo2.GetTranscodeTask_OutputFile3();
				outputFile3.VideoStreamList = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.VideoStreamList");
				outputFile3.OutputFileUrl = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.OutputFileUrl");
				outputFile3.Encryption = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Encryption");
				outputFile3.Height = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Height");
				outputFile3.SubtitleStreamList = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.SubtitleStreamList");
				outputFile3.Bitrate = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Bitrate");
				outputFile3.AudioStreamList = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.AudioStreamList");
				outputFile3.Width = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Width");
				outputFile3.Fps = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Fps");
				outputFile3.Duration = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Duration");
				outputFile3.Format = _ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Format");
				outputFile3.Filesize = _ctx.LongValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Filesize");

				List<string> outputFile3_watermarkIdList4 = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.WatermarkIdList.Length"); j++) {
					outputFile3_watermarkIdList4.Add(_ctx.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.WatermarkIdList["+ j +"]"));
				}
				outputFile3.WatermarkIdList4 = outputFile3_watermarkIdList4;
				transcodeJobInfo2.OutputFile3 = outputFile3;

				transcodeTask_transcodeJobInfoList1.Add(transcodeJobInfo2);
			}
			transcodeTask.TranscodeJobInfoList1 = transcodeTask_transcodeJobInfoList1;
			getTranscodeTaskResponse.TranscodeTask = transcodeTask;

			List<GetTranscodeTaskResponse.GetTranscodeTask_TranscodeJobInfo> getTranscodeTaskResponse_transcodeJobInfoList = new List<GetTranscodeTaskResponse.GetTranscodeTask_TranscodeJobInfo>();
			for (int i = 0; i < _ctx.Length("GetTranscodeTask.TranscodeJobInfoList.Length"); i++) {
				GetTranscodeTaskResponse.GetTranscodeTask_TranscodeJobInfo transcodeJobInfo = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeJobInfo();
				transcodeJobInfo.Definition = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].Definition");
				transcodeJobInfo.CreationTime = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].CreationTime");
				transcodeJobInfo.InputFileUrl = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].InputFileUrl");
				transcodeJobInfo.ErrorMessage = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].ErrorMessage");
				transcodeJobInfo.ErrorCode = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].ErrorCode");
				transcodeJobInfo.CompleteTime = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].CompleteTime");
				transcodeJobInfo.TranscodeProgress = _ctx.LongValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeProgress");
				transcodeJobInfo.Priority = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].Priority");
				transcodeJobInfo.TranscodeJobStatus = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeJobStatus");
				transcodeJobInfo.TranscodeTemplateId = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeTemplateId");
				transcodeJobInfo.TranscodeJobId = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeJobId");

				GetTranscodeTaskResponse.GetTranscodeTask_TranscodeJobInfo.GetTranscodeTask_OutputFile outputFile = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeJobInfo.GetTranscodeTask_OutputFile();
				outputFile.VideoStreamList = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.VideoStreamList");
				outputFile.OutputFileUrl = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.OutputFileUrl");
				outputFile.Encryption = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Encryption");
				outputFile.Height = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Height");
				outputFile.SubtitleStreamList = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.SubtitleStreamList");
				outputFile.Bitrate = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Bitrate");
				outputFile.AudioStreamList = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.AudioStreamList");
				outputFile.Width = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Width");
				outputFile.Fps = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Fps");
				outputFile.Duration = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Duration");
				outputFile.Format = _ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Format");
				outputFile.Filesize = _ctx.LongValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Filesize");

				List<string> outputFile_watermarkIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.WatermarkIdList.Length"); j++) {
					outputFile_watermarkIdList.Add(_ctx.StringValue("GetTranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.WatermarkIdList["+ j +"]"));
				}
				outputFile.WatermarkIdList = outputFile_watermarkIdList;
				transcodeJobInfo.OutputFile = outputFile;

				getTranscodeTaskResponse_transcodeJobInfoList.Add(transcodeJobInfo);
			}
			getTranscodeTaskResponse.TranscodeJobInfoList = getTranscodeTaskResponse_transcodeJobInfoList;
        
			return getTranscodeTaskResponse;
        }
    }
}
