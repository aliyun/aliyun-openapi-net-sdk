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
        public static ModifyBatchJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyBatchJobsResponse modifyBatchJobsResponse = new ModifyBatchJobsResponse();

			modifyBatchJobsResponse.HttpResponse = _ctx.HttpResponse;
			modifyBatchJobsResponse.Code = _ctx.StringValue("ModifyBatchJobs.Code");
			modifyBatchJobsResponse.HttpStatusCode = _ctx.IntegerValue("ModifyBatchJobs.HttpStatusCode");
			modifyBatchJobsResponse.Message = _ctx.StringValue("ModifyBatchJobs.Message");
			modifyBatchJobsResponse.RequestId = _ctx.StringValue("ModifyBatchJobs.RequestId");
			modifyBatchJobsResponse.Success = _ctx.BooleanValue("ModifyBatchJobs.Success");

			ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup jobGroup = new ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup();
			jobGroup.CreationTime = _ctx.LongValue("ModifyBatchJobs.JobGroup.CreationTime");
			jobGroup.JobFilePath = _ctx.StringValue("ModifyBatchJobs.JobGroup.JobFilePath");
			jobGroup.JobGroupDescription = _ctx.StringValue("ModifyBatchJobs.JobGroup.JobGroupDescription");
			jobGroup.JobGroupId = _ctx.StringValue("ModifyBatchJobs.JobGroup.JobGroupId");
			jobGroup.JobGroupName = _ctx.StringValue("ModifyBatchJobs.JobGroup.JobGroupName");
			jobGroup.ScenarioId = _ctx.StringValue("ModifyBatchJobs.JobGroup.ScenarioId");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyBatchJobs.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(_ctx.StringValue("ModifyBatchJobs.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy strategy = new ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy();
			strategy.Customized = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.Customized");
			strategy.EndTime = _ctx.LongValue("ModifyBatchJobs.JobGroup.Strategy.EndTime");
			strategy.FollowUpStrategy = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("ModifyBatchJobs.JobGroup.Strategy.IsTemplate");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("ModifyBatchJobs.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("ModifyBatchJobs.JobGroup.Strategy.MinAttemptInterval");
			strategy.RepeatBy = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.RepeatBy");
			strategy.RoutingStrategy = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.RoutingStrategy");
			strategy.StartTime = _ctx.LongValue("ModifyBatchJobs.JobGroup.Strategy.StartTime");
			strategy.StrategyDescription = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.StrategyDescription");
			strategy.StrategyId = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.StrategyName");
			strategy.Type = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.Type");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyBatchJobs.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame> strategy_workingTime = new List<ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame>();
			for (int i = 0; i < _ctx.Length("ModifyBatchJobs.JobGroup.Strategy.WorkingTime.Length"); i++) {
				ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame timeFrame = new ModifyBatchJobsResponse.ModifyBatchJobs_JobGroup.ModifyBatchJobs_Strategy.ModifyBatchJobs_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("ModifyBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			modifyBatchJobsResponse.JobGroup = jobGroup;
        
			return modifyBatchJobsResponse;
        }
    }
}
