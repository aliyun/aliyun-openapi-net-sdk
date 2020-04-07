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
				jobGroup.Id = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Id");
				jobGroup.Name = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Name");
				jobGroup.Description = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Description");
				jobGroup.ScenarioId = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].ScenarioId");
				jobGroup.JobFilePath = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].JobFilePath");
				jobGroup.CreationTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].CreationTime");

				List<string> jobGroup_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("ListJobGroups.JobGroups.List["+ i +"].CallingNumbers.Length"); j++) {
					jobGroup_callingNumbers.Add(context.StringValue("ListJobGroups.JobGroups.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				jobGroup.CallingNumbers = jobGroup_callingNumbers;

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy strategy = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy();
				strategy.Id = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Id");
				strategy.Name = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Name");
				strategy.Description = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Description");
				strategy.Type = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Type");
				strategy.StartTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.StartTime");
				strategy.EndTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.EndTime");
				strategy.RepeatBy = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.RepeatBy");
				strategy.MaxAttemptsPerDay = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.MaxAttemptsPerDay");
				strategy.MinAttemptInterval = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.MinAttemptInterval");
				strategy.Customized = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.Customized");
				strategy.RoutingStrategy = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.RoutingStrategy");
				strategy.FollowUpStrategy = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.FollowUpStrategy");
				strategy.IsTemplate = context.BooleanValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.IsTemplate");

				List<string> strategy_repeatDays = new List<string>();
				for (int j = 0; j < context.Length("ListJobGroups.JobGroups.List["+ i +"].Strategy.RepeatDays.Length"); j++) {
					strategy_repeatDays.Add(context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.RepeatDays["+ j +"]"));
				}
				strategy.RepeatDays = strategy_repeatDays;

				List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame> strategy_workingTime = new List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame>();
				for (int j = 0; j < context.Length("ListJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime.Length"); j++) {
					ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame timeFrame = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Strategy.ListJobGroups_TimeFrame();
					timeFrame.BeginTime = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].BeginTime");
					timeFrame.EndTime = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].EndTime");

					strategy_workingTime.Add(timeFrame);
				}
				strategy.WorkingTime = strategy_workingTime;
				jobGroup.Strategy = strategy;

				ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress progress = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress();
				progress.TotalJobs = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalJobs");
				progress.Status = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Status");
				progress.TotalNotAnswered = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalNotAnswered");
				progress.TotalCompleted = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.TotalCompleted");
				progress.StartTime = context.LongValue("ListJobGroups.JobGroups.List["+ i +"].Progress.StartTime");
				progress.Duration = context.IntegerValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Duration");

				List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair> progress_categories = new List<ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair>();
				for (int j = 0; j < context.Length("ListJobGroups.JobGroups.List["+ i +"].Progress.Categories.Length"); j++) {
					ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair keyValuePair = new ListJobGroupsResponse.ListJobGroups_JobGroups.ListJobGroups_JobGroup.ListJobGroups_Progress.ListJobGroups_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Categories["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListJobGroups.JobGroups.List["+ i +"].Progress.Categories["+ j +"].Value");

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
