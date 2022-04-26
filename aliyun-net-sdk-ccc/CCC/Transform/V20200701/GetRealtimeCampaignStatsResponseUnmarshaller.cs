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
    public class GetRealtimeCampaignStatsResponseUnmarshaller
    {
        public static GetRealtimeCampaignStatsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRealtimeCampaignStatsResponse getRealtimeCampaignStatsResponse = new GetRealtimeCampaignStatsResponse();

			getRealtimeCampaignStatsResponse.HttpResponse = _ctx.HttpResponse;
			getRealtimeCampaignStatsResponse.Code = _ctx.StringValue("GetRealtimeCampaignStats.Code");
			getRealtimeCampaignStatsResponse.HttpStatusCode = _ctx.IntegerValue("GetRealtimeCampaignStats.HttpStatusCode");
			getRealtimeCampaignStatsResponse.Message = _ctx.StringValue("GetRealtimeCampaignStats.Message");
			getRealtimeCampaignStatsResponse.RequestId = _ctx.StringValue("GetRealtimeCampaignStats.RequestId");

			GetRealtimeCampaignStatsResponse.GetRealtimeCampaignStats_Data data = new GetRealtimeCampaignStatsResponse.GetRealtimeCampaignStats_Data();
			data.LoggedInAgents = _ctx.LongValue("GetRealtimeCampaignStats.Data.LoggedInAgents");
			data.ReadyAgents = _ctx.LongValue("GetRealtimeCampaignStats.Data.ReadyAgents");
			data.BreakingAgents = _ctx.LongValue("GetRealtimeCampaignStats.Data.BreakingAgents");
			data.TalkingAgents = _ctx.LongValue("GetRealtimeCampaignStats.Data.TalkingAgents");
			data.WorkingAgents = _ctx.LongValue("GetRealtimeCampaignStats.Data.WorkingAgents");
			data.Caps = _ctx.LongValue("GetRealtimeCampaignStats.Data.Caps");
			data.TotalAgents = _ctx.LongValue("GetRealtimeCampaignStats.Data.TotalAgents");
			getRealtimeCampaignStatsResponse.Data = data;
        
			return getRealtimeCampaignStatsResponse;
        }
    }
}
