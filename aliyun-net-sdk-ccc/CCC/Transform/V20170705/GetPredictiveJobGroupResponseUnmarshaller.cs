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
    public class GetPredictiveJobGroupResponseUnmarshaller
    {
        public static GetPredictiveJobGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPredictiveJobGroupResponse getPredictiveJobGroupResponse = new GetPredictiveJobGroupResponse();

			getPredictiveJobGroupResponse.HttpResponse = _ctx.HttpResponse;
			getPredictiveJobGroupResponse.HttpStatusCode = _ctx.IntegerValue("GetPredictiveJobGroup.HttpStatusCode");
			getPredictiveJobGroupResponse.Code = _ctx.StringValue("GetPredictiveJobGroup.Code");
			getPredictiveJobGroupResponse.Message = _ctx.StringValue("GetPredictiveJobGroup.Message");
			getPredictiveJobGroupResponse.RequestId = _ctx.StringValue("GetPredictiveJobGroup.RequestId");
			getPredictiveJobGroupResponse.Success = _ctx.BooleanValue("GetPredictiveJobGroup.Success");

			GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup jobGroup = new GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup();
			jobGroup.CreationTime = _ctx.LongValue("GetPredictiveJobGroup.JobGroup.CreationTime");
			jobGroup.JobGroupId = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.JobGroupId");
			jobGroup.Description = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Description");
			jobGroup.SkillGroupId = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.SkillGroupId");
			jobGroup.SkillGroupName = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.SkillGroupName");
			jobGroup.InstanceId = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.InstanceId");
			jobGroup.Name = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Name");
			jobGroup.Ratio = _ctx.LongValue("GetPredictiveJobGroup.JobGroup.Ratio");

			GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Progress progress = new GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Progress();
			progress.Status = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Progress.Status");
			progress.TotalNotAnswered = _ctx.IntegerValue("GetPredictiveJobGroup.JobGroup.Progress.TotalNotAnswered");
			progress.StartTime = _ctx.LongValue("GetPredictiveJobGroup.JobGroup.Progress.StartTime");
			progress.TotalJobs = _ctx.IntegerValue("GetPredictiveJobGroup.JobGroup.Progress.TotalJobs");
			progress.TotalCompleted = _ctx.IntegerValue("GetPredictiveJobGroup.JobGroup.Progress.TotalCompleted");
			progress.Duration = _ctx.IntegerValue("GetPredictiveJobGroup.JobGroup.Progress.Duration");

			List<GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Progress.GetPredictiveJobGroup_KeyValuePair> progress_categories = new List<GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Progress.GetPredictiveJobGroup_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("GetPredictiveJobGroup.JobGroup.Progress.Categories.Length"); i++) {
				GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Progress.GetPredictiveJobGroup_KeyValuePair keyValuePair = new GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Progress.GetPredictiveJobGroup_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Progress.Categories["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Progress.Categories["+ i +"].Value");

				progress_categories.Add(keyValuePair);
			}
			progress.Categories = progress_categories;
			jobGroup.Progress = progress;

			GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Strategy strategy = new GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Strategy();
			strategy.MinAttemptInterval = _ctx.IntegerValue("GetPredictiveJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.EndTime = _ctx.LongValue("GetPredictiveJobGroup.JobGroup.Strategy.EndTime");
			strategy.StartTime = _ctx.LongValue("GetPredictiveJobGroup.JobGroup.Strategy.StartTime");
			strategy.StrategyId = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Strategy.StrategyId");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("GetPredictiveJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");

			List<GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Strategy.GetPredictiveJobGroup_TimeFrame> strategy_workingTime = new List<GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Strategy.GetPredictiveJobGroup_TimeFrame>();
			for (int i = 0; i < _ctx.Length("GetPredictiveJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Strategy.GetPredictiveJobGroup_TimeFrame timeFrame = new GetPredictiveJobGroupResponse.GetPredictiveJobGroup_JobGroup.GetPredictiveJobGroup_Strategy.GetPredictiveJobGroup_TimeFrame();
				timeFrame.EndTime = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");
				timeFrame.BeginTime = _ctx.StringValue("GetPredictiveJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;
			getPredictiveJobGroupResponse.JobGroup = jobGroup;
        
			return getPredictiveJobGroupResponse;
        }
    }
}
