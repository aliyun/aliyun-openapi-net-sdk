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
    public class GetJobGroupResponseUnmarshaller
    {
        public static GetJobGroupResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobGroupResponse getJobGroupResponse = new GetJobGroupResponse();

			getJobGroupResponse.HttpResponse = context.HttpResponse;
			getJobGroupResponse.RequestId = context.StringValue("GetJobGroup.RequestId");
			getJobGroupResponse.Success = context.BooleanValue("GetJobGroup.Success");
			getJobGroupResponse.Code = context.StringValue("GetJobGroup.Code");
			getJobGroupResponse.Message = context.StringValue("GetJobGroup.Message");
			getJobGroupResponse.HttpStatusCode = context.IntegerValue("GetJobGroup.HttpStatusCode");

			GetJobGroupResponse.GetJobGroup_JobGroup jobGroup = new GetJobGroupResponse.GetJobGroup_JobGroup();
			jobGroup.Id = context.StringValue("GetJobGroup.JobGroup.Id");
			jobGroup.Name = context.StringValue("GetJobGroup.JobGroup.Name");
			jobGroup.Description = context.StringValue("GetJobGroup.JobGroup.Description");
			jobGroup.ScenarioId = context.StringValue("GetJobGroup.JobGroup.ScenarioId");
			jobGroup.JobFilePath = context.StringValue("GetJobGroup.JobGroup.JobFilePath");
			jobGroup.CreationTime = context.LongValue("GetJobGroup.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("GetJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(context.StringValue("GetJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy strategy = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy();
			strategy.Id = context.StringValue("GetJobGroup.JobGroup.Strategy.Id");
			strategy.Name = context.StringValue("GetJobGroup.JobGroup.Strategy.Name");
			strategy.Description = context.StringValue("GetJobGroup.JobGroup.Strategy.Description");
			strategy.Type = context.StringValue("GetJobGroup.JobGroup.Strategy.Type");
			strategy.StartTime = context.LongValue("GetJobGroup.JobGroup.Strategy.StartTime");
			strategy.EndTime = context.LongValue("GetJobGroup.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("GetJobGroup.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("GetJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("GetJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("GetJobGroup.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("GetJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("GetJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("GetJobGroup.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("GetJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("GetJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame> strategy_workingTime = new List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame>();
			for (int i = 0; i < context.Length("GetJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame timeFrame = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame();
				timeFrame.BeginTime = context.StringValue("GetJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("GetJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;

			GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress progress = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress();
			progress.TotalJobs = context.IntegerValue("GetJobGroup.JobGroup.Progress.TotalJobs");
			progress.Status = context.StringValue("GetJobGroup.JobGroup.Progress.Status");
			progress.TotalNotAnswered = context.IntegerValue("GetJobGroup.JobGroup.Progress.TotalNotAnswered");
			progress.TotalCompleted = context.IntegerValue("GetJobGroup.JobGroup.Progress.TotalCompleted");
			progress.StartTime = context.LongValue("GetJobGroup.JobGroup.Progress.StartTime");
			progress.Duration = context.IntegerValue("GetJobGroup.JobGroup.Progress.Duration");

			List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair> progress_categories = new List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair>();
			for (int i = 0; i < context.Length("GetJobGroup.JobGroup.Progress.Categories.Length"); i++) {
				GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair keyValuePair = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair();
				keyValuePair.Key = context.StringValue("GetJobGroup.JobGroup.Progress.Categories["+ i +"].Key");
				keyValuePair._Value = context.StringValue("GetJobGroup.JobGroup.Progress.Categories["+ i +"].Value");

				progress_categories.Add(keyValuePair);
			}
			progress.Categories = progress_categories;
			jobGroup.Progress = progress;
			getJobGroupResponse.JobGroup = jobGroup;
        
			return getJobGroupResponse;
        }
    }
}
