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
    public class CreateBatchJobsResponseUnmarshaller
    {
        public static CreateBatchJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateBatchJobsResponse createBatchJobsResponse = new CreateBatchJobsResponse();

			createBatchJobsResponse.HttpResponse = _ctx.HttpResponse;
			createBatchJobsResponse.RequestId = _ctx.StringValue("CreateBatchJobs.RequestId");
			createBatchJobsResponse.Success = _ctx.BooleanValue("CreateBatchJobs.Success");
			createBatchJobsResponse.Code = _ctx.StringValue("CreateBatchJobs.Code");
			createBatchJobsResponse.Message = _ctx.StringValue("CreateBatchJobs.Message");
			createBatchJobsResponse.HttpStatusCode = _ctx.IntegerValue("CreateBatchJobs.HttpStatusCode");

			CreateBatchJobsResponse.CreateBatchJobs_JobGroup jobGroup = new CreateBatchJobsResponse.CreateBatchJobs_JobGroup();
			jobGroup.JobGroupId = _ctx.StringValue("CreateBatchJobs.JobGroup.JobGroupId");
			jobGroup.JobGroupName = _ctx.StringValue("CreateBatchJobs.JobGroup.JobGroupName");
			jobGroup.JobGroupDescription = _ctx.StringValue("CreateBatchJobs.JobGroup.JobGroupDescription");
			jobGroup.ScenarioId = _ctx.StringValue("CreateBatchJobs.JobGroup.ScenarioId");
			jobGroup.JobFilePath = _ctx.StringValue("CreateBatchJobs.JobGroup.JobFilePath");
			jobGroup.CreationTime = _ctx.LongValue("CreateBatchJobs.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateBatchJobs.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(_ctx.StringValue("CreateBatchJobs.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy strategy = new CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy();
			strategy.StrategyId = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.StrategyName");
			strategy.StrategyDescription = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.StrategyDescription");
			strategy.Type = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.Type");
			strategy.StartTime = _ctx.LongValue("CreateBatchJobs.JobGroup.Strategy.StartTime");
			strategy.EndTime = _ctx.LongValue("CreateBatchJobs.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("CreateBatchJobs.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("CreateBatchJobs.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("CreateBatchJobs.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateBatchJobs.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame> strategy_workingTime = new List<CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame>();
			for (int i = 0; i < _ctx.Length("CreateBatchJobs.JobGroup.Strategy.WorkingTime.Length"); i++) {
				CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame timeFrame = new CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("CreateBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			createBatchJobsResponse.JobGroup = jobGroup;
        
			return createBatchJobsResponse;
        }
    }
}
