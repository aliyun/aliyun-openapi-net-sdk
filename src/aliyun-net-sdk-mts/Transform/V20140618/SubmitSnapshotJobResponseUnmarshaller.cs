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

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitSnapshotJobResponseUnmarshaller
    {
        public static SubmitSnapshotJobResponse Unmarshall(UnmarshallerContext context)
        {
            SubmitSnapshotJobResponse submitSnapshotJobResponse = new SubmitSnapshotJobResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SubmitSnapshotJob.RequestId")
            };
            SubmitSnapshotJobResponse.SnapshotJob_ snapshotJob = new SubmitSnapshotJobResponse.SnapshotJob_()
            {
                Id = context.StringValue("SubmitSnapshotJob.SnapshotJob.Id"),
                UserData = context.StringValue("SubmitSnapshotJob.SnapshotJob.UserData"),
                PipelineId = context.StringValue("SubmitSnapshotJob.SnapshotJob.PipelineId"),
                State = context.StringValue("SubmitSnapshotJob.SnapshotJob.State"),
                Code = context.StringValue("SubmitSnapshotJob.SnapshotJob.Code"),
                Count = context.StringValue("SubmitSnapshotJob.SnapshotJob.Count"),
                Message = context.StringValue("SubmitSnapshotJob.SnapshotJob.Message"),
                CreationTime = context.StringValue("SubmitSnapshotJob.SnapshotJob.CreationTime")
            };
            SubmitSnapshotJobResponse.SnapshotJob_.Input_ input = new SubmitSnapshotJobResponse.SnapshotJob_.Input_()
            {
                Bucket = context.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Bucket"),
                Location = context.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Location"),
                Object = context.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Object")
            };
            snapshotJob.Input = input;

            SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_ snapshotConfig = new SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_()
            {
                Time = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Time"),
                Interval = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Interval"),
                Num = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Num"),
                Width = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Width"),
                Height = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Height"),
                FrameType = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.FrameType")
            };
            SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_.OutputFile_ outputFile = new SubmitSnapshotJobResponse.SnapshotJob_.SnapshotConfig_.OutputFile_()
            {
                Bucket = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Bucket"),
                Location = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Location"),
                Object = context.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Object")
            };
            snapshotConfig.OutputFile = outputFile;
			snapshotJob.SnapshotConfig = snapshotConfig;

            SubmitSnapshotJobResponse.SnapshotJob_.MnsMessageResult_ mNsMessageResult = new SubmitSnapshotJobResponse.SnapshotJob_.MnsMessageResult_()
            {
                MessageId = context.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.MessageId"),
                ErrorMessage = context.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.ErrorMessage"),
                ErrorCode = context.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.ErrorCode")
            };
            snapshotJob.MnsMessageResult = mNsMessageResult;
			submitSnapshotJobResponse.SnapshotJob = snapshotJob;
        
			return submitSnapshotJobResponse;
        }
    }
}