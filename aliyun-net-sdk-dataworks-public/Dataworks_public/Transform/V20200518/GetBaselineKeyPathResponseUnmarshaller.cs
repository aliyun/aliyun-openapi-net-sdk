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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetBaselineKeyPathResponseUnmarshaller
    {
        public static GetBaselineKeyPathResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBaselineKeyPathResponse getBaselineKeyPathResponse = new GetBaselineKeyPathResponse();

			getBaselineKeyPathResponse.HttpResponse = _ctx.HttpResponse;
			getBaselineKeyPathResponse.Success = _ctx.BooleanValue("GetBaselineKeyPath.Success");
			getBaselineKeyPathResponse.ErrorCode = _ctx.StringValue("GetBaselineKeyPath.ErrorCode");
			getBaselineKeyPathResponse.ErrorMessage = _ctx.StringValue("GetBaselineKeyPath.ErrorMessage");
			getBaselineKeyPathResponse.HttpStatusCode = _ctx.IntegerValue("GetBaselineKeyPath.HttpStatusCode");
			getBaselineKeyPathResponse.RequestId = _ctx.StringValue("GetBaselineKeyPath.RequestId");

			List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem> getBaselineKeyPathResponse_data = new List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem>();
			for (int i = 0; i < _ctx.Length("GetBaselineKeyPath.Data.Length"); i++) {
				GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem dataItem = new GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem();
				dataItem.InstanceId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].InstanceId");
				dataItem.ProjectId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].ProjectId");
				dataItem.NodeId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].NodeId");
				dataItem.NodeName = _ctx.StringValue("GetBaselineKeyPath.Data["+ i +"].NodeName");
				dataItem.Bizdate = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Bizdate");
				dataItem.InGroupId = _ctx.IntegerValue("GetBaselineKeyPath.Data["+ i +"].InGroupId");
				dataItem.Owner = _ctx.StringValue("GetBaselineKeyPath.Data["+ i +"].Owner");
				dataItem.PrgType = _ctx.IntegerValue("GetBaselineKeyPath.Data["+ i +"].PrgType");

				List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem> dataItem_runs = new List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem>();
				for (int j = 0; j < _ctx.Length("GetBaselineKeyPath.Data["+ i +"].Runs.Length"); j++) {
					GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem runsItem = new GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem();
					runsItem.AbsTime = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].AbsTime");
					runsItem.BeginCast = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginCast");
					runsItem.BeginRunningTime = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginRunningTime");
					runsItem.BeginWaitResTime = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginWaitResTime");
					runsItem.BeginWaitTimeTime = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginWaitTimeTime");
					runsItem.Bizdate = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].Bizdate");
					runsItem.CycTime = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].CycTime");
					runsItem.EndCast = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].EndCast");
					runsItem.FinishTime = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].FinishTime");
					runsItem.InGroupId = _ctx.IntegerValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].InGroupId");
					runsItem.InstanceId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].InstanceId");
					runsItem.NodeId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].NodeId");
					runsItem.NodeName = _ctx.StringValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].NodeName");
					runsItem.Owner = _ctx.StringValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].Owner");
					runsItem.ProjectId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].ProjectId");
					runsItem.Status = _ctx.StringValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].Status");

					dataItem_runs.Add(runsItem);
				}
				dataItem.Runs = dataItem_runs;

				List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem> dataItem_topics = new List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem>();
				for (int j = 0; j < _ctx.Length("GetBaselineKeyPath.Data["+ i +"].Topics.Length"); j++) {
					GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem topicsItem = new GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem();
					topicsItem.InstanceId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].InstanceId");
					topicsItem.TopicId = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].TopicId");
					topicsItem.TopicName = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].TopicName");
					topicsItem.AddTime = _ctx.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].AddTime");

					dataItem_topics.Add(topicsItem);
				}
				dataItem.Topics = dataItem_topics;

				getBaselineKeyPathResponse_data.Add(dataItem);
			}
			getBaselineKeyPathResponse.Data = getBaselineKeyPathResponse_data;
        
			return getBaselineKeyPathResponse;
        }
    }
}
