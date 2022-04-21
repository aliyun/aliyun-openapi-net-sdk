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
    public class ListJobGroupsAsyncResponseUnmarshaller
    {
        public static ListJobGroupsAsyncResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobGroupsAsyncResponse listJobGroupsAsyncResponse = new ListJobGroupsAsyncResponse();

			listJobGroupsAsyncResponse.HttpResponse = _ctx.HttpResponse;
			listJobGroupsAsyncResponse.Timeout = _ctx.BooleanValue("ListJobGroupsAsync.Timeout");
			listJobGroupsAsyncResponse.HttpStatusCode = _ctx.IntegerValue("ListJobGroupsAsync.HttpStatusCode");
			listJobGroupsAsyncResponse.RequestId = _ctx.StringValue("ListJobGroupsAsync.RequestId");
			listJobGroupsAsyncResponse.Success = _ctx.BooleanValue("ListJobGroupsAsync.Success");
			listJobGroupsAsyncResponse.Vaild = _ctx.BooleanValue("ListJobGroupsAsync.Vaild");
			listJobGroupsAsyncResponse.Code = _ctx.StringValue("ListJobGroupsAsync.Code");
			listJobGroupsAsyncResponse.Message = _ctx.StringValue("ListJobGroupsAsync.Message");
			listJobGroupsAsyncResponse.PageSize = _ctx.IntegerValue("ListJobGroupsAsync.PageSize");
			listJobGroupsAsyncResponse.PageNumber = _ctx.IntegerValue("ListJobGroupsAsync.PageNumber");
			listJobGroupsAsyncResponse.TotalCount = _ctx.IntegerValue("ListJobGroupsAsync.TotalCount");

			List<ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup> listJobGroupsAsyncResponse_jobGroups = new List<ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup>();
			for (int i = 0; i < _ctx.Length("ListJobGroupsAsync.JobGroups.Length"); i++) {
				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup jobGroup = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup();
				jobGroup.Status = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].Status");
				jobGroup.CreationTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].CreationTime");
				jobGroup.JobGroupId = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobGroupId");
				jobGroup.JobGroupName = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobGroupName");
				jobGroup.TotalCallNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].TotalCallNum");
				jobGroup.ScriptId = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ScriptId");
				jobGroup.JobGroupDescription = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobGroupDescription");
				jobGroup.JobDataParsingTaskId = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobDataParsingTaskId");
				jobGroup.ScriptName = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ScriptName");
				jobGroup.ScriptVersion = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ScriptVersion");
				jobGroup.ModifyTime = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ModifyTime");

				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Strategy strategy = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Strategy();
				strategy.EndTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].Strategy.EndTime");
				strategy.StartTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].Strategy.StartTime");
				jobGroup.Strategy = strategy;

				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Progress progress = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Progress();
				progress.TotalNotAnswered = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.TotalNotAnswered");
				progress.Status = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.Status");
				progress.StartTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.StartTime");
				progress.FailedNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.FailedNum");
				progress.PausedNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.PausedNum");
				progress.CancelledNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.CancelledNum");
				progress.TotalCompleted = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.TotalCompleted");
				progress.TotalJobs = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.TotalJobs");
				progress.Duration = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.Duration");
				progress.Scheduling = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.Scheduling");
				progress.ExecutingNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.ExecutingNum");
				jobGroup.Progress = progress;

				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_ExportProgress exportProgress = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_ExportProgress();
				exportProgress.Status = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ExportProgress.Status");
				exportProgress.FileHttpUrl = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ExportProgress.FileHttpUrl");
				exportProgress.Progress = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ExportProgress.Progress");
				jobGroup.ExportProgress = exportProgress;

				listJobGroupsAsyncResponse_jobGroups.Add(jobGroup);
			}
			listJobGroupsAsyncResponse.JobGroups = listJobGroupsAsyncResponse_jobGroups;
        
			return listJobGroupsAsyncResponse;
        }
    }
}
