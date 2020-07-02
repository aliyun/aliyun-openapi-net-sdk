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
        public static GetBaselineKeyPathResponse Unmarshall(UnmarshallerContext context)
        {
			GetBaselineKeyPathResponse getBaselineKeyPathResponse = new GetBaselineKeyPathResponse();

			getBaselineKeyPathResponse.HttpResponse = context.HttpResponse;
			getBaselineKeyPathResponse.Success = context.BooleanValue("GetBaselineKeyPath.Success");
			getBaselineKeyPathResponse.ErrorCode = context.StringValue("GetBaselineKeyPath.ErrorCode");
			getBaselineKeyPathResponse.ErrorMessage = context.StringValue("GetBaselineKeyPath.ErrorMessage");
			getBaselineKeyPathResponse.HttpStatusCode = context.IntegerValue("GetBaselineKeyPath.HttpStatusCode");
			getBaselineKeyPathResponse.RequestId = context.StringValue("GetBaselineKeyPath.RequestId");

			List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem> getBaselineKeyPathResponse_data = new List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem>();
			for (int i = 0; i < context.Length("GetBaselineKeyPath.Data.Length"); i++) {
				GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem dataItem = new GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem();
				dataItem.InstanceId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].InstanceId");
				dataItem.ProjectId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].ProjectId");
				dataItem.NodeId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].NodeId");
				dataItem.NodeName = context.StringValue("GetBaselineKeyPath.Data["+ i +"].NodeName");
				dataItem.Bizdate = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Bizdate");
				dataItem.InGroupId = context.IntegerValue("GetBaselineKeyPath.Data["+ i +"].InGroupId");
				dataItem.Owner = context.StringValue("GetBaselineKeyPath.Data["+ i +"].Owner");
				dataItem.PrgType = context.IntegerValue("GetBaselineKeyPath.Data["+ i +"].PrgType");

				List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem> dataItem_runs = new List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem>();
				for (int j = 0; j < context.Length("GetBaselineKeyPath.Data["+ i +"].Runs.Length"); j++) {
					GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem runsItem = new GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_RunsItem();
					runsItem.AbsTime = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].AbsTime");
					runsItem.BeginCast = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginCast");
					runsItem.BeginRunningTime = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginRunningTime");
					runsItem.BeginWaitResTime = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginWaitResTime");
					runsItem.BeginWaitTimeTime = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].BeginWaitTimeTime");
					runsItem.Bizdate = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].Bizdate");
					runsItem.CycTime = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].CycTime");
					runsItem.EndCast = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].EndCast");
					runsItem.FinishTime = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].FinishTime");
					runsItem.InGroupId = context.IntegerValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].InGroupId");
					runsItem.InstanceId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].InstanceId");
					runsItem.NodeId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].NodeId");
					runsItem.NodeName = context.StringValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].NodeName");
					runsItem.Owner = context.StringValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].Owner");
					runsItem.ProjectId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].ProjectId");
					runsItem.Status = context.StringValue("GetBaselineKeyPath.Data["+ i +"].Runs["+ j +"].Status");

					dataItem_runs.Add(runsItem);
				}
				dataItem.Runs = dataItem_runs;

				List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem> dataItem_topics = new List<GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem>();
				for (int j = 0; j < context.Length("GetBaselineKeyPath.Data["+ i +"].Topics.Length"); j++) {
					GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem topicsItem = new GetBaselineKeyPathResponse.GetBaselineKeyPath_DataItem.GetBaselineKeyPath_TopicsItem();
					topicsItem.InstanceId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].InstanceId");
					topicsItem.TopicId = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].TopicId");
					topicsItem.TopicName = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].TopicName");
					topicsItem.AddTime = context.LongValue("GetBaselineKeyPath.Data["+ i +"].Topics["+ j +"].AddTime");

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
