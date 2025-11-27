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
    public class QueryMediaWorkflowExecutionListResponseUnmarshaller
    {
        public static QueryMediaWorkflowExecutionListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaWorkflowExecutionListResponse queryMediaWorkflowExecutionListResponse = new QueryMediaWorkflowExecutionListResponse();

			queryMediaWorkflowExecutionListResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaWorkflowExecutionListResponse.RequestId = _ctx.StringValue("QueryMediaWorkflowExecutionList.RequestId");

			List<string> queryMediaWorkflowExecutionListResponse_nonExistRunIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryMediaWorkflowExecutionList.NonExistRunIds.Length"); i++) {
				queryMediaWorkflowExecutionListResponse_nonExistRunIds.Add(_ctx.StringValue("QueryMediaWorkflowExecutionList.NonExistRunIds["+ i +"]"));
			}
			queryMediaWorkflowExecutionListResponse.NonExistRunIds = queryMediaWorkflowExecutionListResponse_nonExistRunIds;

			List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution> queryMediaWorkflowExecutionListResponse_mediaWorkflowExecutionList = new List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution>();
			for (int i = 0; i < _ctx.Length("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList.Length"); i++) {
				QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution mediaWorkflowExecution = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution();
				mediaWorkflowExecution.CreationTime = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].CreationTime");
				mediaWorkflowExecution.MediaWorkflowId = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].MediaWorkflowId");
				mediaWorkflowExecution.State = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].State");
				mediaWorkflowExecution.Name = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Name");
				mediaWorkflowExecution.MediaId = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].MediaId");
				mediaWorkflowExecution.RunId = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].RunId");

				QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input input = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input();
				input.UserData = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.UserData");

				QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input.QueryMediaWorkflowExecutionList_InputFile inputFile = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Input.QueryMediaWorkflowExecutionList_InputFile();
				inputFile._Object = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Object");
				inputFile.Location = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Location");
				inputFile.Bucket = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].Input.InputFile.Bucket");
				input.InputFile = inputFile;
				mediaWorkflowExecution.Input = input;

				List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity> mediaWorkflowExecution_activityList = new List<QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity>();
				for (int j = 0; j < _ctx.Length("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList.Length"); j++) {
					QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity activity = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity();
					activity.EndTime = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].EndTime");
					activity.Type = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Type");
					activity.StartTime = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].StartTime");
					activity.State = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].State");
					activity.JobId = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].JobId");
					activity.Code = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Code");
					activity.Message = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Message");
					activity.Name = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].Name");

					QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity.QueryMediaWorkflowExecutionList_MNSMessageResult mNSMessageResult = new QueryMediaWorkflowExecutionListResponse.QueryMediaWorkflowExecutionList_MediaWorkflowExecution.QueryMediaWorkflowExecutionList_Activity.QueryMediaWorkflowExecutionList_MNSMessageResult();
					mNSMessageResult.MessageId = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.MessageId");
					mNSMessageResult.ErrorMessage = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorMessage");
					mNSMessageResult.ErrorCode = _ctx.StringValue("QueryMediaWorkflowExecutionList.MediaWorkflowExecutionList["+ i +"].ActivityList["+ j +"].MNSMessageResult.ErrorCode");
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
