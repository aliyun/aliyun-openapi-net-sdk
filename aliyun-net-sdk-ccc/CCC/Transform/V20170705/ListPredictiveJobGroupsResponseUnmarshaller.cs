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
    public class ListPredictiveJobGroupsResponseUnmarshaller
    {
        public static ListPredictiveJobGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPredictiveJobGroupsResponse listPredictiveJobGroupsResponse = new ListPredictiveJobGroupsResponse();

			listPredictiveJobGroupsResponse.HttpResponse = context.HttpResponse;
			listPredictiveJobGroupsResponse.RequestId = context.StringValue("ListPredictiveJobGroups.RequestId");
			listPredictiveJobGroupsResponse.Success = context.BooleanValue("ListPredictiveJobGroups.Success");
			listPredictiveJobGroupsResponse.Code = context.StringValue("ListPredictiveJobGroups.Code");
			listPredictiveJobGroupsResponse.Message = context.StringValue("ListPredictiveJobGroups.Message");
			listPredictiveJobGroupsResponse.HttpStatusCode = context.IntegerValue("ListPredictiveJobGroups.HttpStatusCode");

			ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups jobGroups = new ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups();
			jobGroups.TotalCount = context.IntegerValue("ListPredictiveJobGroups.JobGroups.TotalCount");
			jobGroups.PageNumber = context.IntegerValue("ListPredictiveJobGroups.JobGroups.PageNumber");
			jobGroups.PageSize = context.IntegerValue("ListPredictiveJobGroups.JobGroups.PageSize");

			List<ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup> jobGroups_list = new List<ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup>();
			for (int i = 0; i < context.Length("ListPredictiveJobGroups.JobGroups.List.Length"); i++) {
				ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup jobGroup = new ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup();
				jobGroup.JobGroupId = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].JobGroupId");
				jobGroup.InstanceId = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].InstanceId");
				jobGroup.SkillGroupId = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].SkillGroupId");
				jobGroup.SkillGroupName = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].SkillGroupName");
				jobGroup.TaskType = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].TaskType");
				jobGroup.OccupancyRate = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].OccupancyRate");
				jobGroup.StartTime = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].StartTime");
				jobGroup.EndTime = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].EndTime");
				jobGroup.Name = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Name");
				jobGroup.Description = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Description");
				jobGroup.CreationTime = context.LongValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].CreationTime");

				ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Strategy strategy = new ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Strategy();
				strategy.StrategyId = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.StrategyId");
				strategy.StartTime = context.LongValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.StartTime");
				strategy.EndTime = context.LongValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.EndTime");
				strategy.MaxAttemptsPerDay = context.IntegerValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.MaxAttemptsPerDay");
				strategy.MinAttemptInterval = context.IntegerValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.MinAttemptInterval");

				List<ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Strategy.ListPredictiveJobGroups_TimeFrame> strategy_workingTime = new List<ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Strategy.ListPredictiveJobGroups_TimeFrame>();
				for (int j = 0; j < context.Length("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime.Length"); j++) {
					ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Strategy.ListPredictiveJobGroups_TimeFrame timeFrame = new ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Strategy.ListPredictiveJobGroups_TimeFrame();
					timeFrame.BeginTime = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].BeginTime");
					timeFrame.EndTime = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Strategy.WorkingTime["+ j +"].EndTime");

					strategy_workingTime.Add(timeFrame);
				}
				strategy.WorkingTime = strategy_workingTime;
				jobGroup.Strategy = strategy;

				ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Progress progress = new ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Progress();
				progress.TotalJobs = context.IntegerValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.TotalJobs");
				progress.Status = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.Status");
				progress.TotalNotAnswered = context.IntegerValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.TotalNotAnswered");
				progress.TotalCompleted = context.IntegerValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.TotalCompleted");
				progress.StartTime = context.LongValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.StartTime");
				progress.Duration = context.IntegerValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.Duration");

				List<ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Progress.ListPredictiveJobGroups_KeyValuePair> progress_categories = new List<ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Progress.ListPredictiveJobGroups_KeyValuePair>();
				for (int j = 0; j < context.Length("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.Categories.Length"); j++) {
					ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Progress.ListPredictiveJobGroups_KeyValuePair keyValuePair = new ListPredictiveJobGroupsResponse.ListPredictiveJobGroups_JobGroups.ListPredictiveJobGroups_JobGroup.ListPredictiveJobGroups_Progress.ListPredictiveJobGroups_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.Categories["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListPredictiveJobGroups.JobGroups.List["+ i +"].Progress.Categories["+ j +"]._Value");

					progress_categories.Add(keyValuePair);
				}
				progress.Categories = progress_categories;
				jobGroup.Progress = progress;

				jobGroups_list.Add(jobGroup);
			}
			jobGroups.List = jobGroups_list;
			listPredictiveJobGroupsResponse.JobGroups = jobGroups;
        
			return listPredictiveJobGroupsResponse;
        }
    }
}
