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
        public static GetTranscodeTaskResponse Unmarshall(UnmarshallerContext context)
        {
			GetTranscodeTaskResponse getTranscodeTaskResponse = new GetTranscodeTaskResponse();

			getTranscodeTaskResponse.HttpResponse = context.HttpResponse;
			getTranscodeTaskResponse.RequestId = context.StringValue("GetTranscodeTask.RequestId");

			GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask transcodeTask = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask();
			transcodeTask.TranscodeTaskId = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeTaskId");
			transcodeTask.VideoId = context.StringValue("GetTranscodeTask.TranscodeTask.VideoId");
			transcodeTask.TaskStatus = context.StringValue("GetTranscodeTask.TranscodeTask.TaskStatus");
			transcodeTask.CreationTime = context.StringValue("GetTranscodeTask.TranscodeTask.CreationTime");
			transcodeTask.CompleteTime = context.StringValue("GetTranscodeTask.TranscodeTask.CompleteTime");
			transcodeTask.Trigger = context.StringValue("GetTranscodeTask.TranscodeTask.Trigger");
			transcodeTask.TranscodeTemplateGroupId = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeTemplateGroupId");

			List<GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo> transcodeTask_transcodeJobInfoList = new List<GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo>();
			for (int i = 0; i < context.Length("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList.Length"); i++) {
				GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo transcodeJobInfo = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo();
				transcodeJobInfo.TranscodeJobId = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeJobId");
				transcodeJobInfo.TranscodeTemplateId = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeTemplateId");
				transcodeJobInfo.TranscodeJobStatus = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeJobStatus");
				transcodeJobInfo.CreationTime = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].CreationTime");
				transcodeJobInfo.CompleteTime = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].CompleteTime");
				transcodeJobInfo.TranscodeProgress = context.LongValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].TranscodeProgress");
				transcodeJobInfo.InputFileUrl = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].InputFileUrl");
				transcodeJobInfo.Priority = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].Priority");
				transcodeJobInfo.ErrorCode = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].ErrorCode");
				transcodeJobInfo.ErrorMessage = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].ErrorMessage");
				transcodeJobInfo.Definition = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].Definition");

				GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo.GetTranscodeTask_OutputFile outputFile = new GetTranscodeTaskResponse.GetTranscodeTask_TranscodeTask.GetTranscodeTask_TranscodeJobInfo.GetTranscodeTask_OutputFile();
				outputFile.Width = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Width");
				outputFile.Height = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Height");
				outputFile.Bitrate = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Bitrate");
				outputFile.Fps = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Fps");
				outputFile.Format = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Format");
				outputFile.Duration = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Duration");
				outputFile.Filesize = context.LongValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Filesize");
				outputFile.Encryption = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.Encryption");
				outputFile.AudioStreamList = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.AudioStreamList");
				outputFile.VideoStreamList = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.VideoStreamList");
				outputFile.SubtitleStreamList = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.SubtitleStreamList");
				outputFile.OutputFileUrl = context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.OutputFileUrl");

				List<string> outputFile_watermarkIdList = new List<string>();
				for (int j = 0; j < context.Length("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.WatermarkIdList.Length"); j++) {
					outputFile_watermarkIdList.Add(context.StringValue("GetTranscodeTask.TranscodeTask.TranscodeJobInfoList["+ i +"].OutputFile.WatermarkIdList["+ j +"]"));
				}
				outputFile.WatermarkIdList = outputFile_watermarkIdList;
				transcodeJobInfo.OutputFile = outputFile;

				transcodeTask_transcodeJobInfoList.Add(transcodeJobInfo);
			}
			transcodeTask.TranscodeJobInfoList = transcodeTask_transcodeJobInfoList;
			getTranscodeTaskResponse.TranscodeTask = transcodeTask;
        
			return getTranscodeTaskResponse;
        }
    }
}
