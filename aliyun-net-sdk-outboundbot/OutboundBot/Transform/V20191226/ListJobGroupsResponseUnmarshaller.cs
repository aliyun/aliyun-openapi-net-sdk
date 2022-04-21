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
    public class ListJobGroupsResponseUnmarshaller
    {
        public static ListJobGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobGroupsResponse listJobGroupsResponse = new ListJobGroupsResponse();

			listJobGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listJobGroupsResponse.HttpStatusCode = _ctx.IntegerValue("ListJobGroups.HttpStatusCode");
			listJobGroupsResponse.RequestId = _ctx.StringValue("ListJobGroups.RequestId");
			listJobGroupsResponse.Success = _ctx.BooleanValue("ListJobGroups.Success");
			listJobGroupsResponse.Code = _ctx.StringValue("ListJobGroups.Code");
			listJobGroupsResponse.Message = _ctx.StringValue("ListJobGroups.Message");
			listJobGroupsResponse.AsyncTaskId = _ctx.StringValue("ListJobGroups.AsyncTaskId");

			ListJobGroupsResponse.ListJobGroups_JobGroups jobGroups = new ListJobGroupsResponse.ListJobGroups_JobGroups();
			jobGroups.PageNumber = _ctx.IntegerValue("ListJobGroups.JobGroups.PageNumber");
			jobGroups.PageSize = _ctx.IntegerValue("ListJobGroups.JobGroups.PageSize");
			jobGroups.TotalCount = _ctx.IntegerValue("ListJobGroups.JobGroups.TotalCount");

			List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup> jobGroups_list = new List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup>();
			for (int i = 0; i < _ctx.Length("ListJobGroups.JobGroups.List.Length"); i++) {
				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup jobGroup = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup();
				jobGroup.Status = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Status");
				jobGroup.JobGroupId = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobGroupId");
				jobGroup.CreationTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].CreationTime");
				jobGroup.JobGroupName = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobGroupName");
				jobGroup.TotalCallNum = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].TotalCallNum");
				jobGroup.ScriptId = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ScriptId");
				jobGroup.JobGroupDescription = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobGroupDescription");
				jobGroup.JobDataParsingTaskId = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobDataParsingTaskId");
				jobGroup.ScriptName = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ScriptName");
				jobGroup.ScriptVersion = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ScriptVersion");
				jobGroup.ModifyTime = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ModifyTime");

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress progress = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress();
				progress.TotalNotAnswered = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalNotAnswered");
				progress.Status = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Status");
				progress.StartTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].Progress.StartTime");
				progress.FailedNum = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.FailedNum");
				progress.PausedNum = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.PausedNum");
				progress.CancelledNum = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.CancelledNum");
				progress.TotalJobs = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalJobs");
				progress.TotalCompleted = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalCompleted");
				progress.Duration = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Duration");
				progress.ExecutingNum = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.ExecutingNum");
				progress.Scheduling = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Scheduling");
				jobGroup.Progress = progress;

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_ExportProgress exportProgress = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_ExportProgress();
				exportProgress.Status = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ExportProgress.Status");
				exportProgress.FileHttpUrl = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ExportProgress.FileHttpUrl");
				exportProgress.Progress = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ExportProgress.Progress");
				jobGroup.ExportProgress = exportProgress;

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy strategy = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy();
				strategy.EndTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.EndTime");
				strategy.StartTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.StartTime");
				jobGroup.Strategy = strategy;

				jobGroups_list.Add(jobGroup);
			}
			jobGroups.List = jobGroups_list;
			listJobGroupsResponse.JobGroups = jobGroups;
        
			return listJobGroupsResponse;
        }
    }
}
