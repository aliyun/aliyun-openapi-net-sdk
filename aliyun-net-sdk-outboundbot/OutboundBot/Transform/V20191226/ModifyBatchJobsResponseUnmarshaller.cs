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
    public class ModifyBatchJobsResponseUnmarshaller
    {
        public static ModifyBatchJobsResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyBatchJobsResponse modifyBatchJobsResponse = new ModifyBatchJobsResponse();

			modifyBatchJobsResponse.HttpResponse = context.HttpResponse;
			modifyBatchJobsResponse.RequestId = context.StringValue("ModifyBatchJobs.RequestId");
			modifyBatchJobsResponse.Success = context.BooleanValue("ModifyBatchJobs.Success");
			modifyBatchJobsResponse.Code = context.StringValue("ModifyBatchJobs.Code");
			modifyBatchJobsResponse.Message = context.StringValue("ModifyBatchJobs.Message");
			modifyBatchJobsResponse.HttpStatusCode = context.IntegerValue("ModifyBatchJobs.HttpStatusCode");

			ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup jobGroup = new ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup();
			jobGroup.JobGroupId = context.StringValue("ModifyBatchJobs.JobGroup.JobGroupId");
			jobGroup.JobGroupName = context.StringValue("ModifyBatchJobs.JobGroup.JobGroupName");
			jobGroup.JobGroupDescription = context.StringValue("ModifyBatchJobs.JobGroup.JobGroupDescription");
			jobGroup.ScenarioId = context.StringValue("ModifyBatchJobs.JobGroup.ScenarioId");
			jobGroup.JobFilePath = context.StringValue("ModifyBatchJobs.JobGroup.JobFilePath");
			jobGroup.CreationTime = context.LongValue("ModifyBatchJobs.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("ModifyBatchJobs.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(context.StringValue("ModifyBatchJobs.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy strategy = new ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy();
			strategy.StrategyId = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.Type");
			strategy.StartTime = context.LongValue("ModifyBatchJobs.JobGroup.Strategy.StartTime");
			strategy.EndTime = context.LongValue("ModifyBatchJobs.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("ModifyBatchJobs.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("ModifyBatchJobs.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("ModifyBatchJobs.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("ModifyBatchJobs.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("ModifyBatchJobs.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame> strategy_workingTime = new List<ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame>();
			for (int i = 0; i < context.Length("ModifyBatchJobs.JobGroup.Strategy.WorkingTime.Length"); i++) {
				ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame timeFrame = new ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame();
				timeFrame.BeginTime = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("ModifyBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			modifyBatchJobsResponse.JobGroup = jobGroup;
        
			return modifyBatchJobsResponse;
        }
    }
}
