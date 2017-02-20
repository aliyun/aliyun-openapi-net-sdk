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
    public class ListMediaWorkflowExecutionsResponseUnmarshaller
    {
        public static ListMediaWorkflowExecutionsResponse Unmarshall(UnmarshallerContext context)
        {
            ListMediaWorkflowExecutionsResponse listMediaWorkflowExecutionsResponse = new ListMediaWorkflowExecutionsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ListMediaWorkflowExecutions.RequestId"),
                NextPageToken = context.StringValue("ListMediaWorkflowExecutions.NextPageToken")
            };
            List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution> mediaWorkflowExecutionList = new List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution>();
			for (int i = 0; i < context.Length("ListMediaWorkflowExecutions.MediaWorkflowExecutionList.Length"); i++) {
                ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution mediaWorkflowExecution = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution()
                {
                    RunId = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].RunId"),
                    MediaWorkflowId = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].MediaWorkflowId"),
                    Name = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].Name"),
                    State = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].State"),
                    MediaId = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].MediaId"),
                    CreationTime = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].CreationTime")
                };
                ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_ input = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_()
                {
                    UserData = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].Input.UserData")
                };
                ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_.InputFile_ inputFile = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_.InputFile_()
                {
                    Bucket = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].Input.InputFile.Bucket"),
                    Location = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].Input.InputFile.Location"),
                    Object = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].Input.InputFile.Object")
                };
                input.InputFile = inputFile;
				mediaWorkflowExecution.Input = input;

				List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity> activityList = new List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity>();
				for (int j = 0; j < context.Length($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList.Length"); j++) {
                    ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity activity = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity()
                    {
                        Name = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Name"),
                        Type = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Type"),
                        JobId = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].JobId"),
                        State = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].State"),
                        Code = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Code"),
                        Message = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Message"),
                        StartTime = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].StartTime"),
                        EndTime = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].EndTime")
                    };
                    ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity.MnsMessageResult_ mNsMessageResult = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity.MnsMessageResult_()
                    {
                        MessageId = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].MNSMessageResult.MessageId"),
                        ErrorMessage = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].MNSMessageResult.ErrorMessage"),
                        ErrorCode = context.StringValue($"ListMediaWorkflowExecutions.MediaWorkflowExecutionList[{i}].ActivityList[{j}].MNSMessageResult.ErrorCode")
                    };
                    activity.MnsMessageResult = mNsMessageResult;

					activityList.Add(activity);
				}
				mediaWorkflowExecution.ActivityList = activityList;

				mediaWorkflowExecutionList.Add(mediaWorkflowExecution);
			}
			listMediaWorkflowExecutionsResponse.MediaWorkflowExecutionList = mediaWorkflowExecutionList;
        
			return listMediaWorkflowExecutionsResponse;
        }
    }
}