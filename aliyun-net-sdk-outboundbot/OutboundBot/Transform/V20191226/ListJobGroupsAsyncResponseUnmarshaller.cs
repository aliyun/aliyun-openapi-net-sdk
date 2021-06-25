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
			listJobGroupsAsyncResponse.RequestId = _ctx.StringValue("ListJobGroupsAsync.RequestId");
			listJobGroupsAsyncResponse.Success = _ctx.BooleanValue("ListJobGroupsAsync.Success");
			listJobGroupsAsyncResponse.Code = _ctx.StringValue("ListJobGroupsAsync.Code");
			listJobGroupsAsyncResponse.Message = _ctx.StringValue("ListJobGroupsAsync.Message");
			listJobGroupsAsyncResponse.HttpStatusCode = _ctx.IntegerValue("ListJobGroupsAsync.HttpStatusCode");
			listJobGroupsAsyncResponse.TotalCount = _ctx.IntegerValue("ListJobGroupsAsync.TotalCount");
			listJobGroupsAsyncResponse.PageNumber = _ctx.IntegerValue("ListJobGroupsAsync.PageNumber");
			listJobGroupsAsyncResponse.PageSize = _ctx.IntegerValue("ListJobGroupsAsync.PageSize");
			listJobGroupsAsyncResponse.Vaild = _ctx.BooleanValue("ListJobGroupsAsync.Vaild");
			listJobGroupsAsyncResponse.Timeout = _ctx.BooleanValue("ListJobGroupsAsync.Timeout");

			List<ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup> listJobGroupsAsyncResponse_jobGroups = new List<ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup>();
			for (int i = 0; i < _ctx.Length("ListJobGroupsAsync.JobGroups.Length"); i++) {
				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup jobGroup = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup();
				jobGroup.JobGroupId = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobGroupId");
				jobGroup.JobGroupName = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobGroupName");
				jobGroup.JobGroupDescription = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobGroupDescription");
				jobGroup.ScriptId = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ScriptId");
				jobGroup.ScriptName = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ScriptName");
				jobGroup.CreationTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].CreationTime");
				jobGroup.Status = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].Status");
				jobGroup.JobDataParsingTaskId = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].JobDataParsingTaskId");
				jobGroup.ModifyTime = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ModifyTime");
				jobGroup.ScriptVersion = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ScriptVersion");

				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Strategy strategy = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Strategy();
				strategy.StartTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].Strategy.StartTime");
				strategy.EndTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].Strategy.EndTime");
				jobGroup.Strategy = strategy;

				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Progress progress = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_Progress();
				progress.TotalJobs = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.TotalJobs");
				progress.Status = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.Status");
				progress.TotalNotAnswered = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.TotalNotAnswered");
				progress.TotalCompleted = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.TotalCompleted");
				progress.StartTime = _ctx.LongValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.StartTime");
				progress.Duration = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.Duration");
				progress.ExecutingNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.ExecutingNum");
				progress.CancelledNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.CancelledNum");
				progress.Scheduling = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.Scheduling");
				progress.FailedNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.FailedNum");
				progress.PausedNum = _ctx.IntegerValue("ListJobGroupsAsync.JobGroups["+ i +"].Progress.PausedNum");
				jobGroup.Progress = progress;

				ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_ExportProgress exportProgress = new ListJobGroupsAsyncResponse.ListJobGroupsAsync_JobGroup.ListJobGroupsAsync_ExportProgress();
				exportProgress.FileHttpUrl = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ExportProgress.FileHttpUrl");
				exportProgress.Progress = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ExportProgress.Progress");
				exportProgress.Status = _ctx.StringValue("ListJobGroupsAsync.JobGroups["+ i +"].ExportProgress.Status");
				jobGroup.ExportProgress = exportProgress;

				listJobGroupsAsyncResponse_jobGroups.Add(jobGroup);
			}
			listJobGroupsAsyncResponse.JobGroups = listJobGroupsAsyncResponse_jobGroups;
        
			return listJobGroupsAsyncResponse;
        }
    }
}
