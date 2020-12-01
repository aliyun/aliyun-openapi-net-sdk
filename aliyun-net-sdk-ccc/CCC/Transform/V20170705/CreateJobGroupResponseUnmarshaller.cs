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
    public class CreateJobGroupResponseUnmarshaller
    {
        public static CreateJobGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateJobGroupResponse createJobGroupResponse = new CreateJobGroupResponse();

			createJobGroupResponse.HttpResponse = _ctx.HttpResponse;
			createJobGroupResponse.RequestId = _ctx.StringValue("CreateJobGroup.RequestId");
			createJobGroupResponse.Success = _ctx.BooleanValue("CreateJobGroup.Success");
			createJobGroupResponse.Code = _ctx.StringValue("CreateJobGroup.Code");
			createJobGroupResponse.Message = _ctx.StringValue("CreateJobGroup.Message");
			createJobGroupResponse.HttpStatusCode = _ctx.IntegerValue("CreateJobGroup.HttpStatusCode");

			CreateJobGroupResponse.CreateJobGroup_JobGroup jobGroup = new CreateJobGroupResponse.CreateJobGroup_JobGroup();
			jobGroup.JobGroupId = _ctx.StringValue("CreateJobGroup.JobGroup.JobGroupId");
			jobGroup.JobGroupName = _ctx.StringValue("CreateJobGroup.JobGroup.JobGroupName");
			jobGroup.JobGroupDescription = _ctx.StringValue("CreateJobGroup.JobGroup.JobGroupDescription");
			jobGroup.ScenarioId = _ctx.StringValue("CreateJobGroup.JobGroup.ScenarioId");
			jobGroup.JobFilePath = _ctx.StringValue("CreateJobGroup.JobGroup.JobFilePath");
			jobGroup.CreationTime = _ctx.LongValue("CreateJobGroup.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(_ctx.StringValue("CreateJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy strategy = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy();
			strategy.StrategyId = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyName");
			strategy.StrategyDescription = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyDescription");
			strategy.Type = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.Type");
			strategy.StartTime = _ctx.LongValue("CreateJobGroup.JobGroup.Strategy.StartTime");
			strategy.EndTime = _ctx.LongValue("CreateJobGroup.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("CreateJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("CreateJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("CreateJobGroup.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("CreateJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame> strategy_workingTime = new List<CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame>();
			for (int i = 0; i < _ctx.Length("CreateJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame timeFrame = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame();
				timeFrame.From = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].From");
				timeFrame.To = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].To");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			createJobGroupResponse.JobGroup = jobGroup;
        
			return createJobGroupResponse;
        }
    }
}
