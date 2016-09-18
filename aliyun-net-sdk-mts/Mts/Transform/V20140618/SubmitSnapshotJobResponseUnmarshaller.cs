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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitSnapshotJobResponseUnmarshaller
    {
        public static SubmitSnapshotJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitSnapshotJobResponse submitSnapshotJobResponse = new SubmitSnapshotJobResponse();

			submitSnapshotJobResponse.HttpResponse = context.HttpResponse;
			submitSnapshotJobResponse.RequestId = context.StringValue("SubmitSnapshotJob.RequestId");

			SubmitSnapshotJobResponse.SnapshotJob_ snapshotJob = new SubmitSnapshotJobResponse.SnapshotJob_();
			snapshotJob.Id = context.StringValue("SubmitSnapshotJob.SnapshotJob.Id");
			snapshotJob.UserData = context.StringValue("SubmitSnapshotJob.SnapshotJob.UserData");
			snapshotJob.PipelineId = context.StringValue("SubmitSnapshotJob.SnapshotJob.PipelineId");
			snapshotJob.State = context.StringValue("SubmitSnapshotJob.SnapshotJob.State");
			snapshotJob.Code = context.StringValue("SubmitSnapshotJob.SnapshotJob.Code");
			snapshotJob.Count = context.StringValue("SubmitSnapshotJob.SnapshotJob.Count");
			snapshotJob.Message = context.StringValue("SubmitSnapshotJob.SnapshotJob.Message");
			snapshotJob.CreationTime = context.StringValue("SubmitSnapshotJob.SnapshotJob.CreationTime");

			SubmitSnapshotJobResponse.SnapshotJob_.Input_ input = new SubmitSnapshotJobResponse.SnapshotJob_.Input_();
			input.Bucket = context.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Bucket");
			input.Location = context.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Location");
			input.Object = context.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Object");
			snapshotJob.Input = input;

			SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_ snapshotConfig = new SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_();
			snapshotConfig.Time = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Time");
			snapshotConfig.Interval = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Interval");
			snapshotConfig.Num = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Num");
			snapshotConfig.Width = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Width");
			snapshotConfig.Height = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Height");
			snapshotConfig.FrameType = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.FrameType");

			SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_.OutputFile_ outputFile = new SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_.OutputFile_();
			outputFile.Bucket = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Bucket");
			outputFile.Location = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Location");
			outputFile.Object = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Object");
			snapshotConfig.OutputFile = outputFile;
			snapshotJob.SnapshotConfig = snapshotConfig;

			SubmitSnapshotJobResponse.SnapshotJob_.MNSMessageResult_ mNSMessageResult = new SubmitSnapshotJobResponse.SnapshotJob_.MNSMessageResult_();
			mNSMessageResult.MessageId = context.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = context.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = context.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.ErrorCode");
			snapshotJob.MNSMessageResult = mNSMessageResult;
			submitSnapshotJobResponse.SnapshotJob = snapshotJob;
        
			return submitSnapshotJobResponse;
        }
    }
}