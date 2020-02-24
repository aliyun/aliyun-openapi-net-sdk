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
        public static CreateBatchJobsResponse Unmarshall(UnmarshallerContext context)
        {
			CreateBatchJobsResponse createBatchJobsResponse = new CreateBatchJobsResponse();

			createBatchJobsResponse.HttpResponse = context.HttpResponse;
			createBatchJobsResponse.RequestId = context.StringValue("CreateBatchJobs.RequestId");
			createBatchJobsResponse.Success = context.BooleanValue("CreateBatchJobs.Success");
			createBatchJobsResponse.Code = context.StringValue("CreateBatchJobs.Code");
			createBatchJobsResponse.Message = context.StringValue("CreateBatchJobs.Message");
			createBatchJobsResponse.HttpStatusCode = context.IntegerValue("CreateBatchJobs.HttpStatusCode");

			CreateBatchJobsResponse.CreateBatchJobs_BatchJob batchJob = new CreateBatchJobsResponse.CreateBatchJobs_BatchJob();
			batchJob.BatchJobId = context.StringValue("CreateBatchJobs.BatchJob.BatchJobId");
			batchJob.JobGroupName = context.StringValue("CreateBatchJobs.BatchJob.JobGroupName");
			batchJob.JobGroupDescription = context.StringValue("CreateBatchJobs.BatchJob.JobGroupDescription");
			batchJob.ScenarioId = context.StringValue("CreateBatchJobs.BatchJob.ScenarioId");
			batchJob.JobFilePath = context.StringValue("CreateBatchJobs.BatchJob.JobFilePath");
			batchJob.CreationTime = context.LongValue("CreateBatchJobs.BatchJob.CreationTime");

			List<string> batchJob_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("CreateBatchJobs.BatchJob.CallingNumbers.Length"); i++) {
				batchJob_callingNumbers.Add(context.StringValue("CreateBatchJobs.BatchJob.CallingNumbers["+ i +"]"));
			}
			batchJob.CallingNumbers = batchJob_callingNumbers;

			CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy strategy = new CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy();
			strategy.StrategyId = context.StringValue("CreateBatchJobs.BatchJob.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("CreateBatchJobs.BatchJob.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("CreateBatchJobs.BatchJob.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("CreateBatchJobs.BatchJob.Strategy.Type");
			strategy.StartTime = context.LongValue("CreateBatchJobs.BatchJob.Strategy.StartTime");
			strategy.EndTime = context.LongValue("CreateBatchJobs.BatchJob.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("CreateBatchJobs.BatchJob.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("CreateBatchJobs.BatchJob.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("CreateBatchJobs.BatchJob.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("CreateBatchJobs.BatchJob.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("CreateBatchJobs.BatchJob.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("CreateBatchJobs.BatchJob.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("CreateBatchJobs.BatchJob.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("CreateBatchJobs.BatchJob.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("CreateBatchJobs.BatchJob.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame> strategy_workingTime = new List<CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame>();
			for (int i = 0; i < context.Length("CreateBatchJobs.BatchJob.Strategy.WorkingTime.Length"); i++) {
				CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame timeFrame = new CreateBatchJobsResponse.CreateBatchJobs_BatchJob.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame();
				timeFrame.BeginTime = context.StringValue("CreateBatchJobs.BatchJob.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("CreateBatchJobs.BatchJob.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			batchJob.Strategy = strategy;
			createBatchJobsResponse.BatchJob = batchJob;
        
			return createBatchJobsResponse;
        }
    }
}
