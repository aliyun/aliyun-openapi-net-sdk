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
        public static ListJobGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobGroupsResponse listJobGroupsResponse = new ListJobGroupsResponse();

			listJobGroupsResponse.HttpResponse = context.HttpResponse;
			listJobGroupsResponse.RequestId = context.StringValue("ListJobGroups.RequestId");
			listJobGroupsResponse.Success = context.BooleanValue("ListJobGroups.Success");
			listJobGroupsResponse.Code = context.StringValue("ListJobGroups.Code");
			listJobGroupsResponse.Message = context.StringValue("ListJobGroups.Message");
			listJobGroupsResponse.HttpStatusCode = context.IntegerValue("ListJobGroups.HttpStatusCode");

			ListJobGroupsResponse.ListJobGroups_JobGroups jobGroups = new ListJobGroupsResponse.ListJobGroups_JobGroups();
			jobGroups.TotalCount = context.IntegerValue("ListJobGroups.JobGroups.TotalCount");
			jobGroups.PageNumber = context.IntegerValue("ListJobGroups.JobGroups.PageNumber");
			jobGroups.PageSize = context.IntegerValue("ListJobGroups.JobGroups.PageSize");

			List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup> jobGroups_list = new List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup>();
			for (int i = 0; i < context.Length("ListJobGroups.JobGroups.List.Length"); i++) {
				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup jobGroup = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup();
				jobGroup.JobGroupId = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobGroupId");
				jobGroup.JobGroupName = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobGroupName");
				jobGroup.JobGroupDescription = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobGroupDescription");
				jobGroup.ScriptId = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].ScriptId");
				jobGroup.ScriptName = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].ScriptName");
				jobGroup.CreationTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].CreationTime");

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy strategy = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy();
				strategy.StartTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.StartTime");
				strategy.EndTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.EndTime");
				jobGroup.Strategy = strategy;

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress progress = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress();
				progress.TotalJobs = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalJobs");
				progress.Status = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Status");
				progress.TotalNotAnswered = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalNotAnswered");
				progress.TotalCompleted = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalCompleted");
				progress.StartTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].Progress.StartTime");
				progress.Duration = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Duration");
				jobGroup.Progress = progress;

				jobGroups_list.Add(jobGroup);
			}
			jobGroups.List = jobGroups_list;
			listJobGroupsResponse.JobGroups = jobGroups;
        
			return listJobGroupsResponse;
        }
    }
}
