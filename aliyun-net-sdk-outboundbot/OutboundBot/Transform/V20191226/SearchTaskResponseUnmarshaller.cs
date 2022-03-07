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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class SearchTaskResponseUnmarshaller
    {
        public static SearchTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchTaskResponse searchTaskResponse = new SearchTaskResponse();

			searchTaskResponse.HttpResponse = _ctx.HttpResponse;
			searchTaskResponse.HttpStatusCode = _ctx.IntegerValue("SearchTask.HttpStatusCode");
			searchTaskResponse.PageIndex = _ctx.IntegerValue("SearchTask.PageIndex");
			searchTaskResponse.RequestId = _ctx.StringValue("SearchTask.RequestId");
			searchTaskResponse.Success = _ctx.BooleanValue("SearchTask.Success");
			searchTaskResponse.Code = _ctx.StringValue("SearchTask.Code");
			searchTaskResponse.Message = _ctx.StringValue("SearchTask.Message");
			searchTaskResponse.PageSize = _ctx.IntegerValue("SearchTask.PageSize");
			searchTaskResponse.Total = _ctx.LongValue("SearchTask.Total");

			List<SearchTaskResponse.SearchTask_SearchTaskInfo> searchTaskResponse_searchTaskInfoList = new List<SearchTaskResponse.SearchTask_SearchTaskInfo>();
			for (int i = 0; i < _ctx.Length("SearchTask.SearchTaskInfoList.Length"); i++) {
				SearchTaskResponse.SearchTask_SearchTaskInfo searchTaskInfo = new SearchTaskResponse.SearchTask_SearchTaskInfo();
				searchTaskInfo.JobGroupName = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].JobGroupName");
				searchTaskInfo.UserId = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].UserId");
				searchTaskInfo.ActualTime = _ctx.LongValue("SearchTask.SearchTaskInfoList["+ i +"].ActualTime");
				searchTaskInfo.CalledNumber = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].CalledNumber");
				searchTaskInfo.TaskStatusString = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].TaskStatusString");
				searchTaskInfo.TaskStatusName = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].TaskStatusName");
				searchTaskInfo.JobStatus = _ctx.IntegerValue("SearchTask.SearchTaskInfoList["+ i +"].JobStatus");
				searchTaskInfo.DialException = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].DialException");
				searchTaskInfo.UserName = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].UserName");
				searchTaskInfo.CallDurationDisplay = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].CallDurationDisplay");
				searchTaskInfo.HasAnswered = _ctx.BooleanValue("SearchTask.SearchTaskInfoList["+ i +"].HasAnswered");
				searchTaskInfo.JobStatusName = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].JobStatusName");
				searchTaskInfo.CallDuration = _ctx.IntegerValue("SearchTask.SearchTaskInfoList["+ i +"].CallDuration");
				searchTaskInfo.TaskCreateTime = _ctx.LongValue("SearchTask.SearchTaskInfoList["+ i +"].TaskCreateTime");
				searchTaskInfo.JobStatusString = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].JobStatusString");
				searchTaskInfo.HasReachedEndOfFlow = _ctx.BooleanValue("SearchTask.SearchTaskInfoList["+ i +"].HasReachedEndOfFlow");
				searchTaskInfo.InstanceId = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].InstanceId");
				searchTaskInfo.HasHangUpByRejection = _ctx.BooleanValue("SearchTask.SearchTaskInfoList["+ i +"].HasHangUpByRejection");
				searchTaskInfo.TaskEndReason = _ctx.IntegerValue("SearchTask.SearchTaskInfoList["+ i +"].TaskEndReason");
				searchTaskInfo.JobGroupId = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].JobGroupId");
				searchTaskInfo.TaskStatus = _ctx.IntegerValue("SearchTask.SearchTaskInfoList["+ i +"].TaskStatus");
				searchTaskInfo.JobId = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].JobId");
				searchTaskInfo.RecordingDuration = _ctx.IntegerValue("SearchTask.SearchTaskInfoList["+ i +"].RecordingDuration");
				searchTaskInfo.TaskId = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].TaskId");
				searchTaskInfo.DialExceptionOld = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].DialExceptionOld");
				searchTaskInfo.HasLastPlaybackCompleted = _ctx.BooleanValue("SearchTask.SearchTaskInfoList["+ i +"].HasLastPlaybackCompleted");
				searchTaskInfo.ScriptName = _ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].ScriptName");

				List<string> searchTaskInfo_dialExceptionCodes = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchTask.SearchTaskInfoList["+ i +"].DialExceptionCodes.Length"); j++) {
					searchTaskInfo_dialExceptionCodes.Add(_ctx.StringValue("SearchTask.SearchTaskInfoList["+ i +"].DialExceptionCodes["+ j +"]"));
				}
				searchTaskInfo.DialExceptionCodes = searchTaskInfo_dialExceptionCodes;

				searchTaskResponse_searchTaskInfoList.Add(searchTaskInfo);
			}
			searchTaskResponse.SearchTaskInfoList = searchTaskResponse_searchTaskInfoList;
        
			return searchTaskResponse;
        }
    }
}
