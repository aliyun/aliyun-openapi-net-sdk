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
    public class DescribeIntentStatisticsResponseUnmarshaller
    {
        public static DescribeIntentStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIntentStatisticsResponse describeIntentStatisticsResponse = new DescribeIntentStatisticsResponse();

			describeIntentStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeIntentStatisticsResponse.RequestId = _ctx.StringValue("DescribeIntentStatistics.RequestId");
			describeIntentStatisticsResponse.Success = _ctx.BooleanValue("DescribeIntentStatistics.Success");
			describeIntentStatisticsResponse.Code = _ctx.StringValue("DescribeIntentStatistics.Code");
			describeIntentStatisticsResponse.Message = _ctx.StringValue("DescribeIntentStatistics.Message");
			describeIntentStatisticsResponse.HttpStatusCode = _ctx.IntegerValue("DescribeIntentStatistics.HttpStatusCode");
			describeIntentStatisticsResponse.InstanceId = _ctx.StringValue("DescribeIntentStatistics.InstanceId");
			describeIntentStatisticsResponse.GroupId = _ctx.StringValue("DescribeIntentStatistics.GroupId");
			describeIntentStatisticsResponse.ProcessIntentNum = _ctx.IntegerValue("DescribeIntentStatistics.ProcessIntentNum");
			describeIntentStatisticsResponse.GlobalIntentNum = _ctx.IntegerValue("DescribeIntentStatistics.GlobalIntentNum");

			List<DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem> describeIntentStatisticsResponse_processIntents = new List<DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem>();
			for (int i = 0; i < _ctx.Length("DescribeIntentStatistics.ProcessIntents.Length"); i++) {
				DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem intentStatisticsItem = new DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem();
				intentStatisticsItem.InstanceId = _ctx.StringValue("DescribeIntentStatistics.ProcessIntents["+ i +"].InstanceId");
				intentStatisticsItem.GroupId = _ctx.StringValue("DescribeIntentStatistics.ProcessIntents["+ i +"].GroupId");
				intentStatisticsItem.IntentId = _ctx.StringValue("DescribeIntentStatistics.ProcessIntents["+ i +"].IntentId");
				intentStatisticsItem.IntentName = _ctx.StringValue("DescribeIntentStatistics.ProcessIntents["+ i +"].IntentName");
				intentStatisticsItem.Type = _ctx.StringValue("DescribeIntentStatistics.ProcessIntents["+ i +"].Type");
				intentStatisticsItem.HitNum = _ctx.IntegerValue("DescribeIntentStatistics.ProcessIntents["+ i +"].HitNum");
				intentStatisticsItem.HitAfterNoAnswer = _ctx.IntegerValue("DescribeIntentStatistics.ProcessIntents["+ i +"].HitAfterNoAnswer");

				describeIntentStatisticsResponse_processIntents.Add(intentStatisticsItem);
			}
			describeIntentStatisticsResponse.ProcessIntents = describeIntentStatisticsResponse_processIntents;

			List<DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem> describeIntentStatisticsResponse_globalIntents = new List<DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem>();
			for (int i = 0; i < _ctx.Length("DescribeIntentStatistics.GlobalIntents.Length"); i++) {
				DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem intentStatisticsItem = new DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem();
				intentStatisticsItem.InstanceId = _ctx.StringValue("DescribeIntentStatistics.GlobalIntents["+ i +"].InstanceId");
				intentStatisticsItem.GroupId = _ctx.StringValue("DescribeIntentStatistics.GlobalIntents["+ i +"].GroupId");
				intentStatisticsItem.IntentId = _ctx.StringValue("DescribeIntentStatistics.GlobalIntents["+ i +"].IntentId");
				intentStatisticsItem.IntentName = _ctx.StringValue("DescribeIntentStatistics.GlobalIntents["+ i +"].IntentName");
				intentStatisticsItem.Type = _ctx.StringValue("DescribeIntentStatistics.GlobalIntents["+ i +"].Type");
				intentStatisticsItem.HitNum = _ctx.IntegerValue("DescribeIntentStatistics.GlobalIntents["+ i +"].HitNum");
				intentStatisticsItem.HitAfterNoAnswer = _ctx.IntegerValue("DescribeIntentStatistics.GlobalIntents["+ i +"].HitAfterNoAnswer");

				describeIntentStatisticsResponse_globalIntents.Add(intentStatisticsItem);
			}
			describeIntentStatisticsResponse.GlobalIntents = describeIntentStatisticsResponse_globalIntents;

			List<DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem1> describeIntentStatisticsResponse_intentsAfterNoAnswer = new List<DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem1>();
			for (int i = 0; i < _ctx.Length("DescribeIntentStatistics.IntentsAfterNoAnswer.Length"); i++) {
				DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem1 intentStatisticsItem1 = new DescribeIntentStatisticsResponse.DescribeIntentStatistics_IntentStatisticsItem1();
				intentStatisticsItem1.InstanceId = _ctx.StringValue("DescribeIntentStatistics.IntentsAfterNoAnswer["+ i +"].InstanceId");

				describeIntentStatisticsResponse_intentsAfterNoAnswer.Add(intentStatisticsItem1);
			}
			describeIntentStatisticsResponse.IntentsAfterNoAnswer = describeIntentStatisticsResponse_intentsAfterNoAnswer;
        
			return describeIntentStatisticsResponse;
        }
    }
}
