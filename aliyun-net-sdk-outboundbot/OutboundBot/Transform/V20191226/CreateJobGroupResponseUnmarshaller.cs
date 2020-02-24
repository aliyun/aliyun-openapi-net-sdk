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
    public class CreateJobGroupResponseUnmarshaller
    {
        public static CreateJobGroupResponse Unmarshall(UnmarshallerContext context)
        {
			CreateJobGroupResponse createJobGroupResponse = new CreateJobGroupResponse();

			createJobGroupResponse.HttpResponse = context.HttpResponse;
			createJobGroupResponse.RequestId = context.StringValue("CreateJobGroup.RequestId");
			createJobGroupResponse.Success = context.BooleanValue("CreateJobGroup.Success");
			createJobGroupResponse.Code = context.StringValue("CreateJobGroup.Code");
			createJobGroupResponse.Message = context.StringValue("CreateJobGroup.Message");
			createJobGroupResponse.HttpStatusCode = context.IntegerValue("CreateJobGroup.HttpStatusCode");

			CreateJobGroupResponse.CreateJobGroup_JobGroup jobGroup = new CreateJobGroupResponse.CreateJobGroup_JobGroup();
			jobGroup.JobGroupId = context.StringValue("CreateJobGroup.JobGroup.JobGroupId");
			jobGroup.JobGroupName = context.StringValue("CreateJobGroup.JobGroup.JobGroupName");
			jobGroup.JobGroupDescription = context.StringValue("CreateJobGroup.JobGroup.JobGroupDescription");
			jobGroup.ScenarioId = context.StringValue("CreateJobGroup.JobGroup.ScenarioId");
			jobGroup.JobFilePath = context.StringValue("CreateJobGroup.JobGroup.JobFilePath");
			jobGroup.CreationTime = context.LongValue("CreateJobGroup.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("CreateJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(context.StringValue("CreateJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy strategy = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy();
			strategy.StrategyId = context.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("CreateJobGroup.JobGroup.Strategy.Type");
			strategy.StartTime = context.LongValue("CreateJobGroup.JobGroup.Strategy.StartTime");
			strategy.EndTime = context.LongValue("CreateJobGroup.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("CreateJobGroup.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("CreateJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("CreateJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("CreateJobGroup.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("CreateJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("CreateJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("CreateJobGroup.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("CreateJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("CreateJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame> strategy_workingTime = new List<CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame>();
			for (int i = 0; i < context.Length("CreateJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame timeFrame = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame();
				timeFrame.BeginTime = context.StringValue("CreateJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("CreateJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			createJobGroupResponse.JobGroup = jobGroup;
        
			return createJobGroupResponse;
        }
    }
}
