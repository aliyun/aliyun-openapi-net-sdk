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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetCampaignResponseUnmarshaller
    {
        public static GetCampaignResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCampaignResponse getCampaignResponse = new GetCampaignResponse();

			getCampaignResponse.HttpResponse = _ctx.HttpResponse;
			getCampaignResponse.RequestId = _ctx.StringValue("GetCampaign.RequestId");
			getCampaignResponse.HttpStatusCode = _ctx.LongValue("GetCampaign.HttpStatusCode");
			getCampaignResponse.Code = _ctx.StringValue("GetCampaign.Code");
			getCampaignResponse.Success = _ctx.BooleanValue("GetCampaign.Success");

			GetCampaignResponse.GetCampaign_Data data = new GetCampaignResponse.GetCampaign_Data();
			data.ActualEndTime = _ctx.LongValue("GetCampaign.Data.ActualEndTime");
			data.ActualStartTime = _ctx.LongValue("GetCampaign.Data.ActualStartTime");
			data.CasesAborted = _ctx.LongValue("GetCampaign.Data.CasesAborted");
			data.CasesUncompleted = _ctx.LongValue("GetCampaign.Data.CasesUncompleted");
			data.CasesConnected = _ctx.LongValue("GetCampaign.Data.CasesConnected");
			data.MaxAttemptCount = _ctx.LongValue("GetCampaign.Data.MaxAttemptCount");
			data.MinAttemptInterval = _ctx.LongValue("GetCampaign.Data.MinAttemptInterval");
			data.Name = _ctx.StringValue("GetCampaign.Data.Name");
			data.PlanedEndTime = _ctx.LongValue("GetCampaign.Data.PlanedEndTime");
			data.PlanedStartTime = _ctx.LongValue("GetCampaign.Data.PlanedStartTime");
			data.QueueName = _ctx.StringValue("GetCampaign.Data.QueueName");
			data.TotalCases = _ctx.LongValue("GetCampaign.Data.TotalCases");
			data.State = _ctx.StringValue("GetCampaign.Data.State");
			data.CampaignId = _ctx.StringValue("GetCampaign.Data.CampaignId");
			data.StrategyType = _ctx.StringValue("GetCampaign.Data.StrategyType");
			data.StrategyParameters = _ctx.StringValue("GetCampaign.Data.StrategyParameters");
			data.QueueId = _ctx.StringValue("GetCampaign.Data.QueueId");
			data.Simulation = _ctx.BooleanValue("GetCampaign.Data.Simulation");
			data.SimulationParameters = _ctx.StringValue("GetCampaign.Data.SimulationParameters");
			data.CasesUncompletedAfterAttempted = _ctx.LongValue("GetCampaign.Data.CasesUncompletedAfterAttempted");
			getCampaignResponse.Data = data;
        
			return getCampaignResponse;
        }
    }
}
