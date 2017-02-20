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
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QuerySnapshotJobListResponseUnmarshaller
    {
        public static QuerySnapshotJobListResponse Unmarshall(UnmarshallerContext context)
        {
            QuerySnapshotJobListResponse querySnapshotJobListResponse = new QuerySnapshotJobListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QuerySnapshotJobList.RequestId")
            };
            List<string> nonExistSnapshotJobIds = new List<string>();
			for (int i = 0; i < context.Length("QuerySnapshotJobList.NonExistSnapshotJobIds.Length"); i++) {
				nonExistSnapshotJobIds.Add(context.StringValue($"QuerySnapshotJobList.NonExistSnapshotJobIds[{i}]"));
			}
			querySnapshotJobListResponse.NonExistSnapshotJobIds = nonExistSnapshotJobIds;

			List<QuerySnapshotJobListResponse.SnapshotJob> snapshotJobList = new List<QuerySnapshotJobListResponse.SnapshotJob>();
			for (int i = 0; i < context.Length("QuerySnapshotJobList.SnapshotJobList.Length"); i++) {
                QuerySnapshotJobListResponse.SnapshotJob snapshotJob = new QuerySnapshotJobListResponse.SnapshotJob()
                {
                    Id = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].Id"),
                    UserData = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].UserData"),
                    PipelineId = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].PipelineId"),
                    State = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].State"),
                    Code = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].Code"),
                    Count = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].Count"),
                    Message = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].Message"),
                    CreationTime = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].CreationTime")
                };
                QuerySnapshotJobListResponse.SnapshotJob.Input_ input = new QuerySnapshotJobListResponse.SnapshotJob.Input_()
                {
                    Bucket = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].Input.Bucket"),
                    Location = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].Input.Location"),
                    Object = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].Input.Object")
                };
                snapshotJob.Input = input;

                QuerySnapshotJobListResponse.SnapshotJob.SnapshotConfig_ snapshotConfig = new QuerySnapshotJobListResponse.SnapshotJob.SnapshotConfig_()
                {
                    Time = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.Time"),
                    Interval = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.Interval"),
                    Num = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.Num"),
                    Width = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.Width"),
                    Height = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.Height"),
                    FrameType = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.FrameType")
                };
                QuerySnapshotJobListResponse.SnapshotJob.SnapshotConfig_.OutputFile_ outputFile = new QuerySnapshotJobListResponse.SnapshotJob.SnapshotConfig_.OutputFile_()
                {
                    Bucket = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.OutputFile.Bucket"),
                    Location = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.OutputFile.Location"),
                    Object = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].SnapshotConfig.OutputFile.Object")
                };
                snapshotConfig.OutputFile = outputFile;
				snapshotJob.SnapshotConfig = snapshotConfig;

                QuerySnapshotJobListResponse.SnapshotJob.MnsMessageResult_ mNsMessageResult = new QuerySnapshotJobListResponse.SnapshotJob.MnsMessageResult_()
                {
                    MessageId = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].MNSMessageResult.MessageId"),
                    ErrorMessage = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].MNSMessageResult.ErrorMessage"),
                    ErrorCode = context.StringValue($"QuerySnapshotJobList.SnapshotJobList[{i}].MNSMessageResult.ErrorCode")
                };
                snapshotJob.MnsMessageResult = mNsMessageResult;

				snapshotJobList.Add(snapshotJob);
			}
			querySnapshotJobListResponse.SnapshotJobList = snapshotJobList;
        
			return querySnapshotJobListResponse;
        }
    }
}