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
    public class DescribeJobGroupResponseUnmarshaller
    {
        public static DescribeJobGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeJobGroupResponse describeJobGroupResponse = new DescribeJobGroupResponse();

			describeJobGroupResponse.HttpResponse = context.HttpResponse;
			describeJobGroupResponse.RequestId = context.StringValue("DescribeJobGroup.RequestId");
			describeJobGroupResponse.Success = context.BooleanValue("DescribeJobGroup.Success");
			describeJobGroupResponse.Code = context.StringValue("DescribeJobGroup.Code");
			describeJobGroupResponse.Message = context.StringValue("DescribeJobGroup.Message");
			describeJobGroupResponse.HttpStatusCode = context.IntegerValue("DescribeJobGroup.HttpStatusCode");

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup jobGroup = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup();
			jobGroup.JobGroupId = context.StringValue("DescribeJobGroup.JobGroup.JobGroupId");
			jobGroup.JobGroupName = context.StringValue("DescribeJobGroup.JobGroup.JobGroupName");
			jobGroup.JobGroupDescription = context.StringValue("DescribeJobGroup.JobGroup.JobGroupDescription");
			jobGroup.ScenarioId = context.StringValue("DescribeJobGroup.JobGroup.ScenarioId");
			jobGroup.ScriptId = context.StringValue("DescribeJobGroup.JobGroup.ScriptId");
			jobGroup.ScriptName = context.StringValue("DescribeJobGroup.JobGroup.ScriptName");
			jobGroup.JobFilePath = context.StringValue("DescribeJobGroup.JobGroup.JobFilePath");
			jobGroup.CreationTime = context.LongValue("DescribeJobGroup.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("DescribeJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(context.StringValue("DescribeJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy strategy = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy();
			strategy.StrategyId = context.StringValue("DescribeJobGroup.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("DescribeJobGroup.JobGroup.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("DescribeJobGroup.JobGroup.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("DescribeJobGroup.JobGroup.Strategy.Type");
			strategy.StartTime = context.LongValue("DescribeJobGroup.JobGroup.Strategy.StartTime");
			strategy.EndTime = context.LongValue("DescribeJobGroup.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("DescribeJobGroup.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("DescribeJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("DescribeJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("DescribeJobGroup.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("DescribeJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("DescribeJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("DescribeJobGroup.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("DescribeJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("DescribeJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame> strategy_workingTime = new List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame>();
			for (int i = 0; i < context.Length("DescribeJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame timeFrame = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame();
				timeFrame.BeginTime = context.StringValue("DescribeJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("DescribeJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress progress = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress();
			progress.TotalJobs = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.TotalJobs");
			progress.Status = context.StringValue("DescribeJobGroup.JobGroup.Progress.Status");
			progress.TotalNotAnswered = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.TotalNotAnswered");
			progress.TotalCompleted = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.TotalCompleted");
			progress.StartTime = context.LongValue("DescribeJobGroup.JobGroup.Progress.StartTime");
			progress.Duration = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.Duration");
			progress.Scheduling = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.Scheduling");
			progress.Executing = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.Executing");
			progress.Paused = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.Paused");
			progress.Failed = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.Failed");
			progress.Cancelled = context.IntegerValue("DescribeJobGroup.JobGroup.Progress.Cancelled");

			List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair> progress_categories = new List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair>();
			for (int i = 0; i < context.Length("DescribeJobGroup.JobGroup.Progress.Categories.Length"); i++) {
				DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair keyValuePair = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair();
				keyValuePair.Key = context.StringValue("DescribeJobGroup.JobGroup.Progress.Categories["+ i +"].Key");
				keyValuePair._Value = context.StringValue("DescribeJobGroup.JobGroup.Progress.Categories["+ i +"].Value");

				progress_categories.Add(keyValuePair);
			}
			progress.Categories = progress_categories;

			List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair> progress_briefs = new List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair>();
			for (int i = 0; i < context.Length("DescribeJobGroup.JobGroup.Progress.Briefs.Length"); i++) {
				DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair keyValuePair = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair();
				keyValuePair.Key = context.StringValue("DescribeJobGroup.JobGroup.Progress.Briefs["+ i +"].Key");
				keyValuePair._Value = context.StringValue("DescribeJobGroup.JobGroup.Progress.Briefs["+ i +"].Value");

				progress_briefs.Add(keyValuePair);
			}
			progress.Briefs = progress_briefs;
			jobGroup.Progress = progress;
			describeJobGroupResponse.JobGroup = jobGroup;
        
			return describeJobGroupResponse;
        }
    }
}
