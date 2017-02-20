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
    public class QueryMediaWorkflowExecutionListResponseUnmarshaller
    {
        public static QueryMediaWorkflowExecutionListResponse Unmarshall(UnmarshallerContext context)
        {
            QueryMediaWorkflowExecutionListResponse queryMediaWorkflowExecutionListResponse = new QueryMediaWorkflowExecutionListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryMediaWorkflowExecutionList.RequestId")
            };
            List<string> nonExistRunIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaWorkflowExecutionList.NonExistRunIds.Length"); i++) {
				nonExistRunIds.Add(context.StringValue($"QueryMediaWorkflowExecutionList.NonExistRunIds[{i}]"));
			}
			queryMediaWorkflowExecutionListResponse.NonExistRunIds = nonExistRunIds;

			List<QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution> mediaWorkflowExecutionList = new List<QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution>();
			for (int i = 0; i < context.Length("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList.Length"); i++) {
                QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution mediaWorkflowExecution = new QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution()
                {
                    RunId = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].RunId"),
                    MediaWorkflowId = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].MediaWorkflowId"),
                    Name = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].Name"),
                    State = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].State"),
                    MediaId = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].MediaId"),
                    CreationTime = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].CreationTime")
                };
                QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Input_ input = new QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Input_()
                {
                    UserData = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].Input.UserData")
                };
                QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Input_.InputFile_ inputFile = new QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Input_.InputFile_()
                {
                    Bucket = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].Input.InputFile.Bucket"),
                    Location = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].Input.InputFile.Location"),
                    Object = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].Input.InputFile.Object")
                };
                input.InputFile = inputFile;
				mediaWorkflowExecution.Input = input;

				List<QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Activity> activityList = new List<QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Activity>();
				for (int j = 0; j < context.Length($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList.Length"); j++) {
                    QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Activity activity = new QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Activity()
                    {
                        Name = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Name"),
                        Type = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Type"),
                        JobId = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].JobId"),
                        State = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].State"),
                        Code = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Code"),
                        Message = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Message"),
                        StartTime = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].StartTime"),
                        EndTime = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].EndTime")
                    };
                    QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Activity.MnsMessageResult_ mNsMessageResult = new QueryMediaWorkflowExecutionListResponse.MediaWorkflowExecution.Activity.MnsMessageResult_()
                    {
                        MessageId = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].MNSMessageResult.MessageId"),
                        ErrorMessage = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].MNSMessageResult.ErrorMessage"),
                        ErrorCode = context.StringValue($"QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList[{i}].ActivityList[{j}].MNSMessageResult.ErrorCode")
                    };
                    activity.MnsMessageResult = mNsMessageResult;

					activityList.Add(activity);
				}
				mediaWorkflowExecution.ActivityList = activityList;

				mediaWorkflowExecutionList.Add(mediaWorkflowExecution);
			}
			queryMediaWorkflowExecutionListResponse.MediaWorkflowExecutionList = mediaWorkflowExecutionList;
        
			return queryMediaWorkflowExecutionListResponse;
        }
    }
}