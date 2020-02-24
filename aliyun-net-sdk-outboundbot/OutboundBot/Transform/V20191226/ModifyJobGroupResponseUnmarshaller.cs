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
    public class ModifyJobGroupResponseUnmarshaller
    {
        public static ModifyJobGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyJobGroupResponse modifyJobGroupResponse = new ModifyJobGroupResponse();

			modifyJobGroupResponse.HttpResponse = context.HttpResponse;
			modifyJobGroupResponse.RequestId = context.StringValue("ModifyJobGroup.RequestId");
			modifyJobGroupResponse.Success = context.BooleanValue("ModifyJobGroup.Success");
			modifyJobGroupResponse.Code = context.StringValue("ModifyJobGroup.Code");
			modifyJobGroupResponse.Message = context.StringValue("ModifyJobGroup.Message");
			modifyJobGroupResponse.HttpStatusCode = context.IntegerValue("ModifyJobGroup.HttpStatusCode");

			ModifyJobGroupResponse.ModifyJobGroup_JobGroup jobGroup = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup();
			jobGroup.JobGroupId = context.StringValue("ModifyJobGroup.JobGroup.JobGroupId");
			jobGroup.JobGroupName = context.StringValue("ModifyJobGroup.JobGroup.JobGroupName");
			jobGroup.JobGroupDescription = context.StringValue("ModifyJobGroup.JobGroup.JobGroupDescription");
			jobGroup.ScenarioId = context.StringValue("ModifyJobGroup.JobGroup.ScenarioId");
			jobGroup.JobFilePath = context.StringValue("ModifyJobGroup.JobGroup.JobFilePath");
			jobGroup.CreationTime = context.LongValue("ModifyJobGroup.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("ModifyJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(context.StringValue("ModifyJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy strategy = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy();
			strategy.StrategyId = context.StringValue("ModifyJobGroup.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("ModifyJobGroup.JobGroup.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("ModifyJobGroup.JobGroup.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("ModifyJobGroup.JobGroup.Strategy.Type");
			strategy.StartTime = context.LongValue("ModifyJobGroup.JobGroup.Strategy.StartTime");
			strategy.EndTime = context.LongValue("ModifyJobGroup.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("ModifyJobGroup.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("ModifyJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("ModifyJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("ModifyJobGroup.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("ModifyJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("ModifyJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("ModifyJobGroup.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("ModifyJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("ModifyJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame> strategy_workingTime = new List<ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame>();
			for (int i = 0; i < context.Length("ModifyJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame timeFrame = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame();
				timeFrame.BeginTime = context.StringValue("ModifyJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("ModifyJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			modifyJobGroupResponse.JobGroup = jobGroup;
        
			return modifyJobGroupResponse;
        }
    }
}
