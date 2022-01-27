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
    public class GetSummaryInfoResponseUnmarshaller
    {
        public static GetSummaryInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSummaryInfoResponse getSummaryInfoResponse = new GetSummaryInfoResponse();

			getSummaryInfoResponse.HttpResponse = _ctx.HttpResponse;
			getSummaryInfoResponse.RequestId = _ctx.StringValue("GetSummaryInfo.RequestId");
			getSummaryInfoResponse.Success = _ctx.BooleanValue("GetSummaryInfo.Success");
			getSummaryInfoResponse.Code = _ctx.StringValue("GetSummaryInfo.Code");
			getSummaryInfoResponse.Message = _ctx.StringValue("GetSummaryInfo.Message");
			getSummaryInfoResponse.HttpStatusCode = _ctx.IntegerValue("GetSummaryInfo.HttpStatusCode");

			List<GetSummaryInfoResponse.GetSummaryInfo_AgentBotInstanceSummary> getSummaryInfoResponse_agentBotInstanceSummaryList = new List<GetSummaryInfoResponse.GetSummaryInfo_AgentBotInstanceSummary>();
			for (int i = 0; i < _ctx.Length("GetSummaryInfo.AgentBotInstanceSummaryList.Length"); i++) {
				GetSummaryInfoResponse.GetSummaryInfo_AgentBotInstanceSummary agentBotInstanceSummary = new GetSummaryInfoResponse.GetSummaryInfo_AgentBotInstanceSummary();
				agentBotInstanceSummary.TotalCallTime = _ctx.LongValue("GetSummaryInfo.AgentBotInstanceSummaryList["+ i +"].TotalCallTime");
				agentBotInstanceSummary.TotalCallCount = _ctx.LongValue("GetSummaryInfo.AgentBotInstanceSummaryList["+ i +"].TotalCallCount");
				agentBotInstanceSummary.UsedRecordingStorageSpace = _ctx.IntegerValue("GetSummaryInfo.AgentBotInstanceSummaryList["+ i +"].UsedRecordingStorageSpace");
				agentBotInstanceSummary.InstanceId = _ctx.StringValue("GetSummaryInfo.AgentBotInstanceSummaryList["+ i +"].InstanceId");

				getSummaryInfoResponse_agentBotInstanceSummaryList.Add(agentBotInstanceSummary);
			}
			getSummaryInfoResponse.AgentBotInstanceSummaryList = getSummaryInfoResponse_agentBotInstanceSummaryList;
        
			return getSummaryInfoResponse;
        }
    }
}
