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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListMediaWorkflowExecutionsResponseUnmarshaller
    {
        public static ListMediaWorkflowExecutionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMediaWorkflowExecutionsResponse listMediaWorkflowExecutionsResponse = new ListMediaWorkflowExecutionsResponse();

			listMediaWorkflowExecutionsResponse.HttpResponse = _ctx.HttpResponse;
			listMediaWorkflowExecutionsResponse.RequestId = _ctx.StringValue("ListMediaWorkflowExecutions.RequestId");
			listMediaWorkflowExecutionsResponse.NextPageToken = _ctx.StringValue("ListMediaWorkflowExecutions.NextPageToken");

			List<ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution> listMediaWorkflowExecutionsResponse_mediaWorkflowExecutionList = new List<ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution>();
			for (int i = 0; i < _ctx.Length("ListMediaWorkflowExecutions.MediaWorkflowExecutionList.Length"); i++) {
				ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution mediaWorkflowExecution = new ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution();
				mediaWorkflowExecution.CreationTime = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].CreationTime");
				mediaWorkflowExecution.MediaWorkflowId = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].MediaWorkflowId");
				mediaWorkflowExecution.State = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].State");
				mediaWorkflowExecution.Name = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Name");
				mediaWorkflowExecution.MediaId = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].MediaId");
				mediaWorkflowExecution.RunId = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].RunId");

				ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Input input = new ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Input();
				input.UserData = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.UserData");

				ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Input.ListMediaWorkflowExecutions_InputFile inputFile = new ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Input.ListMediaWorkflowExecutions_InputFile();
				inputFile._Object = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Object");
				inputFile.Location = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Location");
				inputFile.Bucket = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Bucket");
				input.InputFile = inputFile;
				mediaWorkflowExecution.Input = input;

				List<ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Activity> mediaWorkflowExecution_activityList = new List<ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Activity>();
				for (int j = 0; j < _ctx.Length("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList.Length"); j++) {
					ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Activity activity = new ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Activity();
					activity.EndTime = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].EndTime");
					activity.Type = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Type");
					activity.StartTime = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].StartTime");
					activity.State = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].State");
					activity.JobId = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].JobId");
					activity.Code = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Code");
					activity.Message = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Message");
					activity.Name = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Name");

					ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Activity.ListMediaWorkflowExecutions_MNSMessageResult mNSMessageResult = new ListMediaWorkflowExecutionsResponse.ListMediaWorkflowExecutions_MediaWorkflowExecution.ListMediaWorkflowExecutions_Activity.ListMediaWorkflowExecutions_MNSMessageResult();
					mNSMessageResult.MessageId = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.MessageId");
					mNSMessageResult.ErrorMessage = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorMessage");
					mNSMessageResult.ErrorCode = _ctx.StringValue("ListMediaWorkflowExecutions.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorCode");
					activity.MNSMessageResult = mNSMessageResult;

					mediaWorkflowExecution_activityList.Add(activity);
				}
				mediaWorkflowExecution.ActivityList = mediaWorkflowExecution_activityList;

				listMediaWorkflowExecutionsResponse_mediaWorkflowExecutionList.Add(mediaWorkflowExecution);
			}
			listMediaWorkflowExecutionsResponse.MediaWorkflowExecutionList = listMediaWorkflowExecutionsResponse_mediaWorkflowExecutionList;
        
			return listMediaWorkflowExecutionsResponse;
        }
    }
}
