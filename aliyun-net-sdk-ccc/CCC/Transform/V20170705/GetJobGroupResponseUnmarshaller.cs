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
    public class GetJobGroupResponseUnmarshaller
    {
        public static GetJobGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobGroupResponse getJobGroupResponse = new GetJobGroupResponse();

			getJobGroupResponse.HttpResponse = _ctx.HttpResponse;
			getJobGroupResponse.RequestId = _ctx.StringValue("GetJobGroup.RequestId");
			getJobGroupResponse.Success = _ctx.BooleanValue("GetJobGroup.Success");
			getJobGroupResponse.Code = _ctx.StringValue("GetJobGroup.Code");
			getJobGroupResponse.Message = _ctx.StringValue("GetJobGroup.Message");
			getJobGroupResponse.HttpStatusCode = _ctx.IntegerValue("GetJobGroup.HttpStatusCode");

			GetJobGroupResponse.GetJobGroup_JobGroup jobGroup = new GetJobGroupResponse.GetJobGroup_JobGroup();
			jobGroup.Id = _ctx.StringValue("GetJobGroup.JobGroup.Id");
			jobGroup.Name = _ctx.StringValue("GetJobGroup.JobGroup.Name");
			jobGroup.Description = _ctx.StringValue("GetJobGroup.JobGroup.Description");
			jobGroup.ScenarioId = _ctx.StringValue("GetJobGroup.JobGroup.ScenarioId");
			jobGroup.JobFilePath = _ctx.StringValue("GetJobGroup.JobGroup.JobFilePath");
			jobGroup.CreationTime = _ctx.LongValue("GetJobGroup.JobGroup.CreationTime");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("GetJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(_ctx.StringValue("GetJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy strategy = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy();
			strategy.Id = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.Id");
			strategy.Name = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.Name");
			strategy.Description = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.Description");
			strategy.Type = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.Type");
			strategy.StartTime = _ctx.LongValue("GetJobGroup.JobGroup.Strategy.StartTime");
			strategy.EndTime = _ctx.LongValue("GetJobGroup.JobGroup.Strategy.EndTime");
			strategy.RepeatBy = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("GetJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("GetJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.Customized = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.Customized");
			strategy.RoutingStrategy = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("GetJobGroup.JobGroup.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("GetJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("GetJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame> strategy_workingTime = new List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame>();
			for (int i = 0; i < _ctx.Length("GetJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame timeFrame = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Strategy.GetJobGroup_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("GetJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;

			GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress progress = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress();
			progress.TotalJobs = _ctx.IntegerValue("GetJobGroup.JobGroup.Progress.TotalJobs");
			progress.Status = _ctx.StringValue("GetJobGroup.JobGroup.Progress.Status");
			progress.TotalNotAnswered = _ctx.IntegerValue("GetJobGroup.JobGroup.Progress.TotalNotAnswered");
			progress.TotalCompleted = _ctx.IntegerValue("GetJobGroup.JobGroup.Progress.TotalCompleted");
			progress.StartTime = _ctx.LongValue("GetJobGroup.JobGroup.Progress.StartTime");
			progress.Duration = _ctx.IntegerValue("GetJobGroup.JobGroup.Progress.Duration");

			List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair> progress_categories = new List<GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("GetJobGroup.JobGroup.Progress.Categories.Length"); i++) {
				GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair keyValuePair = new GetJobGroupResponse.GetJobGroup_JobGroup.GetJobGroup_Progress.GetJobGroup_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("GetJobGroup.JobGroup.Progress.Categories["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("GetJobGroup.JobGroup.Progress.Categories["+ i +"].Value");

				progress_categories.Add(keyValuePair);
			}
			progress.Categories = progress_categories;
			jobGroup.Progress = progress;
			getJobGroupResponse.JobGroup = jobGroup;
        
			return getJobGroupResponse;
        }
    }
}
