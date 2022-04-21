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
    public class CreateBatchJobsResponseUnmarshaller
    {
        public static CreateBatchJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateBatchJobsResponse createBatchJobsResponse = new CreateBatchJobsResponse();

			createBatchJobsResponse.HttpResponse = _ctx.HttpResponse;
			createBatchJobsResponse.HttpStatusCode = _ctx.IntegerValue("CreateBatchJobs.HttpStatusCode");
			createBatchJobsResponse.Code = _ctx.StringValue("CreateBatchJobs.Code");
			createBatchJobsResponse.Message = _ctx.StringValue("CreateBatchJobs.Message");
			createBatchJobsResponse.RequestId = _ctx.StringValue("CreateBatchJobs.RequestId");
			createBatchJobsResponse.Success = _ctx.BooleanValue("CreateBatchJobs.Success");

			CreateBatchJobsResponse.CreateBatchJobs_BatchJob batchJob = new CreateBatchJobsResponse.CreateBatchJobs_BatchJob();
			batchJob.CreationTime = _ctx.LongValue("CreateBatchJobs.BatchJob.CreationTime");
			batchJob.ScenarioId = _ctx.StringValue("CreateBatchJobs.BatchJob.ScenarioId");
			batchJob.JobGroupName = _ctx.StringValue("CreateBatchJobs.BatchJob.JobGroupName");
			batchJob.BatchJobId = _ctx.StringValue("CreateBatchJobs.BatchJob.BatchJobId");
			batchJob.JobFilePath = _ctx.StringValue("CreateBatchJobs.BatchJob.JobFilePath");
			batchJob.JobGroupDescription = _ctx.StringValue("CreateBatchJobs.BatchJob.JobGroupDescription");

			List<string> batchJob_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateBatchJobs.BatchJob.CallingNumbers.Length"); i++) {
				batchJob_callingNumbers.Add(_ctx.StringValue("CreateBatchJobs.BatchJob.CallingNumbers["+ i +"]"));
			}
			batchJob.CallingNumbers = batchJob_callingNumbers;

			CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy strategy = new CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy();
			strategy.Type = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.Type");
			strategy.StrategyName = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.StrategyName");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("CreateBatchJobs.BatchJob.Strategy.MaxAttemptsPerDay");
			strategy.FollowUpStrategy = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.FollowUpStrategy");
			strategy.EndTime = _ctx.LongValue("CreateBatchJobs.BatchJob.Strategy.EndTime");
			strategy.Customized = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.Customized");
			strategy.IsTemplate = _ctx.BooleanValue("CreateBatchJobs.BatchJob.Strategy.IsTemplate");
			strategy.StartTime = _ctx.LongValue("CreateBatchJobs.BatchJob.Strategy.StartTime");
			strategy.StrategyId = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.StrategyId");
			strategy.RoutingStrategy = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.RoutingStrategy");
			strategy.MinAttemptInterval = _ctx.IntegerValue("CreateBatchJobs.BatchJob.Strategy.MinAttemptInterval");
			strategy.StrategyDescription = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.StrategyDescription");
			strategy.RepeatBy = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.RepeatBy");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateBatchJobs.BatchJob.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame> strategy_workingTime = new List<CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame>();
			for (int i = 0; i < _ctx.Length("CreateBatchJobs.BatchJob.Strategy.WorkingTime.Length"); i++) {
				CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame timeFrame = new CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame();
				timeFrame.EndTime = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.WorkingTime["+ i +"].EndTime");
				timeFrame.BeginTime = _ctx.StringValue("CreateBatchJobs.BatchJob.Strategy.WorkingTime["+ i +"].BeginTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			batchJob.Strategy = strategy;
			createBatchJobsResponse.BatchJob = batchJob;
        
			return createBatchJobsResponse;
        }
    }
}
