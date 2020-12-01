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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListJobGroupsResponseUnmarshaller
    {
        public static ListJobGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobGroupsResponse listJobGroupsResponse = new ListJobGroupsResponse();

			listJobGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listJobGroupsResponse.RequestId = _ctx.StringValue("ListJobGroups.RequestId");
			listJobGroupsResponse.Success = _ctx.BooleanValue("ListJobGroups.Success");
			listJobGroupsResponse.Code = _ctx.StringValue("ListJobGroups.Code");
			listJobGroupsResponse.Message = _ctx.StringValue("ListJobGroups.Message");
			listJobGroupsResponse.HttpStatusCode = _ctx.IntegerValue("ListJobGroups.HttpStatusCode");

			ListJobGroupsResponse.ListJobGroups_JobGroups jobGroups = new ListJobGroupsResponse.ListJobGroups_JobGroups();
			jobGroups.TotalCount = _ctx.IntegerValue("ListJobGroups.JobGroups.TotalCount");
			jobGroups.PageNumber = _ctx.IntegerValue("ListJobGroups.JobGroups.PageNumber");
			jobGroups.PageSize = _ctx.IntegerValue("ListJobGroups.JobGroups.PageSize");

			List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup> jobGroups_list = new List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup>();
			for (int i = 0; i < _ctx.Length("ListJobGroups.JobGroups.List.Length"); i++) {
				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup jobGroup = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup();
				jobGroup.Id = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Id");
				jobGroup.Name = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Name");
				jobGroup.Description = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Description");
				jobGroup.ScenarioId = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].ScenarioId");
				jobGroup.JobFilePath = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobFilePath");
				jobGroup.CreationTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].CreationTime");

				List<string> jobGroup_callingNumbers = new List<string>();
				for (int j = 0; j < _ctx.Length("ListJobGroups.JobGroups.List["+ i +"].CallingNumbers.Length"); j++) {
					jobGroup_callingNumbers.Add(_ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				jobGroup.CallingNumbers = jobGroup_callingNumbers;

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy strategy = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy();
				strategy.Id = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Id");
				strategy.Name = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Name");
				strategy.Description = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Description");
				strategy.Type = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Type");
				strategy.StartTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.StartTime");
				strategy.EndTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.EndTime");
				strategy.RepeatBy = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.RepeatBy");
				strategy.MaxAttemptsPerDay = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.MaxAttemptsPerDay");
				strategy.MinAttemptInterval = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.MinAttemptInterval");
				strategy.Customized = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Customized");
				strategy.RoutingStrategy = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.RoutingStrategy");
				strategy.FollowUpStrategy = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.FollowUpStrategy");
				strategy.IsTemplate = _ctx.BooleanValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.IsTemplate");

				List<string> strategy_repeatDays = new List<string>();
				for (int j = 0; j < _ctx.Length("ListJobGroups.JobGroups.List["+ i +"].Strategy.RepeatDays.Length"); j++) {
					strategy_repeatDays.Add(_ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.RepeatDays["+ j +"]"));
				}
				strategy.RepeatDays = strategy_repeatDays;

				List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame> strategy_workingTime = new List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame>();
				for (int j = 0; j < _ctx.Length("ListJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime.Length"); j++) {
					ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame timeFrame = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame();
					timeFrame.BeginTime = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].BeginTime");
					timeFrame.EndTime = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].EndTime");

					strategy_workingTime.Add(timeFrame);
				}
				strategy.WorkingTime = strategy_workingTime;
				jobGroup.Strategy = strategy;

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress progress = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress();
				progress.TotalJobs = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalJobs");
				progress.Status = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Status");
				progress.TotalNotAnswered = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalNotAnswered");
				progress.TotalCompleted = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalCompleted");
				progress.StartTime = _ctx.LongValue("ListJobGroups.JobGroups.List["+ i +"].Progress.StartTime");
				progress.Duration = _ctx.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Duration");

				List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair> progress_categories = new List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("ListJobGroups.JobGroups.List["+ i +"].Progress.Categories.Length"); j++) {
					ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair keyValuePair = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Categories["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Categories["+ j +"].Value");

					progress_categories.Add(keyValuePair);
				}
				progress.Categories = progress_categories;
				jobGroup.Progress = progress;

				jobGroups_list.Add(jobGroup);
			}
			jobGroups.List = jobGroups_list;
			listJobGroupsResponse.JobGroups = jobGroups;
        
			return listJobGroupsResponse;
        }
    }
}
