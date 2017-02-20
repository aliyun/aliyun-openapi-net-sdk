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
    public class StartMediaWorkflowExecutionResponseUnmarshaller
    {
        public static StartMediaWorkflowExecutionResponse Unmarshall(UnmarshallerContext context)
        {
            StartMediaWorkflowExecutionResponse startMediaWorkflowExecutionResponse = new StartMediaWorkflowExecutionResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("StartMediaWorkflowExecution.RequestId")
            };
            StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_ mediaWorkflowExecution = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_()
            {
                RunId = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.RunId"),
                Name = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Name"),
                State = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.State"),
                MediaId = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.MediaId"),
                CreationTime = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.CreationTime")
            };
            StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_ input = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_()
            {
                UserData = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.UserData")
            };
            StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_.InputFile_ inputFile = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_.InputFile_()
            {
                Bucket = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.InputFile.Bucket"),
                Location = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.InputFile.Location"),
                Object = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.InputFile.Object")
            };
            input.InputFile = inputFile;
			mediaWorkflowExecution.Input = input;

			List<StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity> activityList = new List<StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity>();
			for (int i = 0; i < context.Length("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList.Length"); i++) {
                StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity activity = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity()
                {
                    Name = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].Name"),
                    Type = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].Type"),
                    JobId = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].JobId"),
                    State = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].State"),
                    Code = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].Code"),
                    Message = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].Message"),
                    StartTime = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].StartTime"),
                    EndTime = context.StringValue($"StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList[{i}].EndTime")
                };
                activityList.Add(activity);
			}
			mediaWorkflowExecution.ActivityList = activityList;
			startMediaWorkflowExecutionResponse.MediaWorkflowExecution = mediaWorkflowExecution;
        
			return startMediaWorkflowExecutionResponse;
        }
    }
}