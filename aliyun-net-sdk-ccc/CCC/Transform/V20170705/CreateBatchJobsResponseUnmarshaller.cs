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
        public static CreateBatchJobsResponse Unmarshall(UnmarshallerContext context)
        {
			CreateBatchJobsResponse createBatchJobsResponse = new CreateBatchJobsResponse();

			createBatchJobsResponse.HttpResponse = context.HttpResponse;
			createBatchJobsResponse.RequestId = context.StringValue("CreateBatchJobs.RequestId");
			createBatchJobsResponse.Success = context.BooleanValue("CreateBatchJobs.Success");
			createBatchJobsResponse.Code = context.StringValue("CreateBatchJobs.Code");
			createBatchJobsResponse.Message = context.StringValue("CreateBatchJobs.Message");
			createBatchJobsResponse.HttpStatusCode = context.IntegerValue("CreateBatchJobs.HttpStatusCode");

			CreateBatchJobsResponse.CreateBatchJobs_JobGroup jobGroup = new CreateBatchJobsResponse.CreateBatchJobs_JobGroup();
			jobGroup.JobGroupId = context.StringValue("CreateBatchJobs.JobGroup.JobGroupId");
			jobGroup.JobGroupName = context.StringValue("CreateBatchJobs.JobGroup.JobGroupName");
			jobGroup.JobGroupDescription = context.StringValue("CreateBatchJobs.JobGroup.JobGroupDescription");
			jobGroup.ScenarioId = context.StringValue("CreateBatchJobs.JobGroup.ScenarioId");
			jobGroup.JobFilePath = context.StringValue("CreateBatchJobs.JobGroup.JobFilePath");
			jobGroup.CreationTime = context.LongValue("CreateBatchJobs.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("CreateBatchJobs.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(context.StringValue("CreateBatchJobs.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy strategy = new CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy();
			strategy.StrategyId = context.StringValue("CreateBatchJobs.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("CreateBatchJobs.JobGroup.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("CreateBatchJobs.JobGroup.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("CreateBatchJobs.JobGroup.Strategy.Type");
			strategy.StartTime = context.LongValue("CreateBatchJobs.JobGroup.Strategy.StartTime");
			strategy.EndTime = context.LongValue("CreateBatchJobs.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("CreateBatchJobs.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("CreateBatchJobs.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("CreateBatchJobs.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("CreateBatchJobs.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("CreateBatchJobs.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("CreateBatchJobs.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("CreateBatchJobs.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("CreateBatchJobs.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("CreateBatchJobs.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame> strategy_workingTime = new List<CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame>();
			for (int i = 0; i < context.Length("CreateBatchJobs.JobGroup.Strategy.WorkingTime.Length"); i++) {
				CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame timeFrame = new CreateBatchJobsResponse.CreateBatchJobs_JobGroup.CreateBatchJobs_Strategy.CreateBatchJobs_TimeFrame();
				timeFrame.BeginTime = context.StringValue("CreateBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("CreateBatchJobs.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			createBatchJobsResponse.JobGroup = jobGroup;
        
			return createBatchJobsResponse;
        }
    }
}
