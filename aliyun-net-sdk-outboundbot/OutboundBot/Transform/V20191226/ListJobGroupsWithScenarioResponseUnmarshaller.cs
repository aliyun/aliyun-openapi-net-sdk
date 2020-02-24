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
    public class ListJobGroupsWithScenarioResponseUnmarshaller
    {
        public static ListJobGroupsWithScenarioResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobGroupsWithScenarioResponse listJobGroupsWithScenarioResponse = new ListJobGroupsWithScenarioResponse();

			listJobGroupsWithScenarioResponse.HttpResponse = context.HttpResponse;
			listJobGroupsWithScenarioResponse.RequestId = context.StringValue("ListJobGroupsWithScenario.RequestId");
			listJobGroupsWithScenarioResponse.Success = context.BooleanValue("ListJobGroupsWithScenario.Success");
			listJobGroupsWithScenarioResponse.Code = context.StringValue("ListJobGroupsWithScenario.Code");
			listJobGroupsWithScenarioResponse.Message = context.StringValue("ListJobGroupsWithScenario.Message");
			listJobGroupsWithScenarioResponse.HttpStatusCode = context.IntegerValue("ListJobGroupsWithScenario.HttpStatusCode");

			ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups jobGroups = new ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups();
			jobGroups.TotalCount = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.TotalCount");
			jobGroups.PageNumber = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.PageNumber");
			jobGroups.PageSize = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.PageSize");

			List<ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup> jobGroups_list = new List<ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup>();
			for (int i = 0; i < context.Length("ListJobGroupsWithScenario.JobGroups.List.Length"); i++) {
				ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup jobGroup = new ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup();
				jobGroup.JobGroupId = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].JobGroupId");
				jobGroup.JobGroupName = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].JobGroupName");
				jobGroup.ScenarioName = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].ScenarioName");
				jobGroup.JobGroupDescription = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].JobGroupDescription");
				jobGroup.ScenarioId = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].ScenarioId");
				jobGroup.JobFilePath = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].JobFilePath");
				jobGroup.CreationTime = context.LongValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].CreationTime");

				List<string> jobGroup_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("ListJobGroupsWithScenario.JobGroups.List["+ i +"].CallingNumbers.Length"); j++) {
					jobGroup_callingNumbers.Add(context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				jobGroup.CallingNumbers = jobGroup_callingNumbers;

				ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Strategy strategy = new ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Strategy();
				strategy.StrategyId = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.StrategyId");
				strategy.StrategyName = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.StrategyName");
				strategy.Description = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.Description");
				strategy.Type = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.Type");
				strategy.StartTime = context.LongValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.StartTime");
				strategy.EndTime = context.LongValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.EndTime");
				strategy.RepeatBy = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.RepeatBy");
				strategy.MaxAttemptsPerDay = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.MaxAttemptsPerDay");
				strategy.MinAttemptInterval = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.MinAttemptInterval");
				strategy.Customized = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.Customized");
				strategy.RoutingStrategy = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.RoutingStrategy");
				strategy.FollowUpStrategy = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.FollowUpStrategy");
				strategy.IsTemplate = context.BooleanValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.IsTemplate");

				List<string> strategy_repeatDays = new List<string>();
				for (int j = 0; j < context.Length("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.RepeatDays.Length"); j++) {
					strategy_repeatDays.Add(context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.RepeatDays["+ j +"]"));
				}
				strategy.RepeatDays = strategy_repeatDays;

				List<ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Strategy.ListJobGroupsWithScenario_TimeFrame> strategy_workingTime = new List<ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Strategy.ListJobGroupsWithScenario_TimeFrame>();
				for (int j = 0; j < context.Length("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.WorkingTime.Length"); j++) {
					ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Strategy.ListJobGroupsWithScenario_TimeFrame timeFrame = new ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Strategy.ListJobGroupsWithScenario_TimeFrame();
					timeFrame.BeginTime = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].BeginTime");
					timeFrame.EndTime = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].EndTime");

					strategy_workingTime.Add(timeFrame);
				}
				strategy.WorkingTime = strategy_workingTime;
				jobGroup.Strategy = strategy;

				ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Progress progress = new ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Progress();
				progress.TotalJobs = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.TotalJobs");
				progress.Status = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.Status");
				progress.TotalNotAnswered = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.TotalNotAnswered");
				progress.TotalCompleted = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.TotalCompleted");
				progress.StartTime = context.LongValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.StartTime");
				progress.Duration = context.IntegerValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.Duration");

				List<ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Progress.ListJobGroupsWithScenario_KeyValuePair> progress_categories = new List<ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Progress.ListJobGroupsWithScenario_KeyValuePair>();
				for (int j = 0; j < context.Length("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.Categories.Length"); j++) {
					ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Progress.ListJobGroupsWithScenario_KeyValuePair keyValuePair = new ListJobGroupsWithScenarioResponse.ListJobGroupsWithScenario_JobGroups.ListJobGroupsWithScenario_JobGroup.ListJobGroupsWithScenario_Progress.ListJobGroupsWithScenario_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.Categories["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListJobGroupsWithScenario.JobGroups.List["+ i +"].Progress.Categories["+ j +"].Value");

					progress_categories.Add(keyValuePair);
				}
				progress.Categories = progress_categories;
				jobGroup.Progress = progress;

				jobGroups_list.Add(jobGroup);
			}
			jobGroups.List = jobGroups_list;
			listJobGroupsWithScenarioResponse.JobGroups = jobGroups;
        
			return listJobGroupsWithScenarioResponse;
        }
    }
}
