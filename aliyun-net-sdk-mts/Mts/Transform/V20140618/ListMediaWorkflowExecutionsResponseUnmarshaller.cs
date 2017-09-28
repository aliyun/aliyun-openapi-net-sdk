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
    public class ListMediaWorkflowExecutionsResponseUnmarshaller
    {
        public static ListMediaWorkflowExecutionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListMediaWorkflowExecutionsResponse listMediaWorkflowExecutionsResponse = new ListMediaWorkflowExecutionsResponse();

			listMediaWorkflowExecutionsResponse.HttpResponse = context.HttpResponse;
			listMediaWorkflowExecutionsResponse.RequestId = context.StringValue("ListMediaWorkflowExecutions.RequestId");
			listMediaWorkflowExecutionsResponse.NextPageToken = context.StringValue("ListMediaWorkflowExecutions.NextPageToken");

			List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution> mediaWorkflowExecutionList = new List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution>();
			for (int i = 0; i < context.Length("ListMediaWorkflowExecutions.MediaWorkflowExecutionList.Length"); i++) {
				ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution mediaWorkflowExecution = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution();
				mediaWorkflowExecution.RunId = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].RunId");
				mediaWorkflowExecution.MediaWorkflowId = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].MediaWorkflowId");
				mediaWorkflowExecution.Name = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Name");
				mediaWorkflowExecution.State = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].State");
				mediaWorkflowExecution.MediaId = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].MediaId");
				mediaWorkflowExecution.CreationTime = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].CreationTime");

				ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_ input = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_();
				input.UserData = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.UserData");

				ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_.InputFile_ inputFile = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Input_.InputFile_();
				inputFile.Bucket = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Bucket");
				inputFile.Location = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Location");
				inputFile.Object = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Object");
				input.InputFile = inputFile;
				mediaWorkflowExecution.Input = input;

				List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity> activityList = new List<ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity>();
				for (int j = 0; j < context.Length("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList.Length"); j++) {
					ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity activity = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity();
					activity.Name = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Name");
					activity.Type = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Type");
					activity.JobId = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].JobId");
					activity.State = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].State");
					activity.Code = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Code");
					activity.Message = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Message");
					activity.StartTime = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].StartTime");
					activity.EndTime = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].EndTime");

					ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity.MNSMessageResult_ mNSMessageResult = new ListMediaWorkflowExecutionsResponse.MediaWorkflowExecution.Activity.MNSMessageResult_();
					mNSMessageResult.MessageId = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.MessageId");
					mNSMessageResult.ErrorMessage = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorMessage");
					mNSMessageResult.ErrorCode = context.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorCode");
					activity.MNSMessageResult = mNSMessageResult;

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