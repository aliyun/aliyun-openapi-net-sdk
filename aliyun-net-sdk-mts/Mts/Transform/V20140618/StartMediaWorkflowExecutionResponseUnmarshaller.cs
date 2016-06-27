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
    public class StartMediaWorkflowExecutionResponseUnmarshaller
    {
        public static StartMediaWorkflowExecutionResponse Unmarshall(UnmarshallerContext context)
        {
			StartMediaWorkflowExecutionResponse startMediaWorkflowExecutionResponse = new StartMediaWorkflowExecutionResponse();

			startMediaWorkflowExecutionResponse.HttpResponse = context.HttpResponse;
			startMediaWorkflowExecutionResponse.RequestId = context.StringValue("StartMediaWorkflowExecution.RequestId");

			StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_ mediaWorkflowExecution = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_();
			mediaWorkflowExecution.RunId = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.RunId");
			mediaWorkflowExecution.Name = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Name");
			mediaWorkflowExecution.State = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.State");
			mediaWorkflowExecution.MediaId = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.MediaId");
			mediaWorkflowExecution.CreationTime = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.CreationTime");

			StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_ input = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_();
			input.UserData = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.UserData");

			StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_.InputFile_ inputFile = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Input_.InputFile_();
			inputFile.Bucket = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.InputFile.Bucket");
			inputFile.Location = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.InputFile.Location");
			inputFile.Object = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.Input.InputFile.Object");
			input.InputFile = inputFile;
			mediaWorkflowExecution.Input = input;

			List<StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity> activityList = new List<StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity>();
			for (int i = 0; i < context.Length("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList.Length"); i++) {
				StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity activity = new StartMediaWorkflowExecutionResponse.MediaWorkflowExecution_.Activity();
				activity.Name = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].Name");
				activity.Type = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].Type");
				activity.JobId = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].JobId");
				activity.State = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].State");
				activity.Code = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].Code");
				activity.Message = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].Message");
				activity.StartTime = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].StartTime");
				activity.EndTime = context.StringValue("StartMediaWorkflowExecution.MediaWorkflowExecution.ActivityList["+ i +"].EndTime");

				activityList.Add(activity);
			}
			mediaWorkflowExecution.ActivityList = activityList;
			startMediaWorkflowExecutionResponse.MediaWorkflowExecution = mediaWorkflowExecution;
        
			return startMediaWorkflowExecutionResponse;
        }
    }
}