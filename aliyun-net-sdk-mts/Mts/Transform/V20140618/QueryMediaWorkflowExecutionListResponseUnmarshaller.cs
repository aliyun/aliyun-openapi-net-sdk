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
    public class QueryMediaWorkflowExecutionListResponseUnmarshaller
    {
        public static QueryMediaWorkflowExecutionListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaWorkflowExecutionListResponse queryMediaWorkflowExecutionListResponse = new QueryMediaWorkflowExecutionListResponse();

			queryMediaWorkflowExecutionListResponse.HttpResponse = context.HttpResponse;
			queryMediaWorkflowExecutionListResponse.RequestId = context.StringValue("QueryMediaWorkflowExecutionList.RequestId");

			List<string> queryMediaWorkflowExecutionListResponse_nonExistRunIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaWorkflowExecutionList.NonExistRunIds.Length"); i++) {
				queryMediaWorkflowExecutionListResponse_nonExistRunIds.Add(context.StringValue("QueryMediaWorkflowExecutionList.NonExistRunIds["+ i +"]"));
			}
			queryMediaWorkflowExecutionListResponse.NonExistRunIds = queryMediaWorkflowExecutionListResponse_nonExistRunIds;

			List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution> queryMediaWorkflowExecutionListResponse_mediaWorkflowExecutionList = new List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution>();
			for (int i = 0; i < context.Length("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList.Length"); i++) {
				QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution mediaWorkflowExecution = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution();
				mediaWorkflowExecution.RunId = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].RunId");
				mediaWorkflowExecution.MediaWorkflowId = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].MediaWorkflowId");
				mediaWorkflowExecution.Name = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Name");
				mediaWorkflowExecution.State = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].State");
				mediaWorkflowExecution.MediaId = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].MediaId");
				mediaWorkflowExecution.CreationTime = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].CreationTime");

				QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input input = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input();
				input.UserData = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.UserData");

				QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input.QueryMediaWorkflowExecutionList_InputFile inputFile = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input.QueryMediaWorkflowExecutionList_InputFile();
				inputFile.Bucket = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Bucket");
				inputFile.Location = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Location");
				inputFile._Object = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Object");
				input.InputFile = inputFile;
				mediaWorkflowExecution.Input = input;

				List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity> mediaWorkflowExecution_activityList = new List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity>();
				for (int j = 0; j < context.Length("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList.Length"); j++) {
					QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity activity = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity();
					activity.Name = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Name");
					activity.Type = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Type");
					activity.JobId = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].JobId");
					activity.State = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].State");
					activity.Code = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Code");
					activity.Message = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Message");
					activity.StartTime = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].StartTime");
					activity.EndTime = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].EndTime");

					QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity.QueryMediaWorkflowExecutionList_MNSMessageResult mNSMessageResult = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity.QueryMediaWorkflowExecutionList_MNSMessageResult();
					mNSMessageResult.MessageId = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.MessageId");
					mNSMessageResult.ErrorMessage = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorMessage");
					mNSMessageResult.ErrorCode = context.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorCode");
					activity.MNSMessageResult = mNSMessageResult;

					mediaWorkflowExecution_activityList.Add(activity);
				}
				mediaWorkflowExecution.ActivityList = mediaWorkflowExecution_activityList;

				queryMediaWorkflowExecutionListResponse_mediaWorkflowExecutionList.Add(mediaWorkflowExecution);
			}
			queryMediaWorkflowExecutionListResponse.MediaWorkflowExecutionList = queryMediaWorkflowExecutionListResponse_mediaWorkflowExecutionList;
        
			return queryMediaWorkflowExecutionListResponse;
        }
    }
}