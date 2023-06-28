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
using Aliyun.Acs.ddosbgp.Model.V20180720;

namespace Aliyun.Acs.ddosbgp.Transform.V20180720
{
    public class QuerySchedruleOnDemandResponseUnmarshaller
    {
        public static QuerySchedruleOnDemandResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySchedruleOnDemandResponse querySchedruleOnDemandResponse = new QuerySchedruleOnDemandResponse();

			querySchedruleOnDemandResponse.HttpResponse = _ctx.HttpResponse;
			querySchedruleOnDemandResponse.RequestId = _ctx.StringValue("QuerySchedruleOnDemand.RequestId");
			querySchedruleOnDemandResponse.InstanceId = _ctx.StringValue("QuerySchedruleOnDemand.InstanceId");
			querySchedruleOnDemandResponse.UserId = _ctx.StringValue("QuerySchedruleOnDemand.UserId");

			List<QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Config> querySchedruleOnDemandResponse_ruleConfig = new List<QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Config>();
			for (int i = 0; i < _ctx.Length("QuerySchedruleOnDemand.RuleConfig.Length"); i++) {
				QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Config config = new QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Config();
				config.RuleSwitch = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleSwitch");
				config.RuleConditionMbps = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleConditionMbps");
				config.TimeZone = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].TimeZone");
				config.RuleAction = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleAction");
				config.RuleConditionKpps = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleConditionKpps");
				config.RuleUndoMode = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleUndoMode");
				config.RuleUndoBeginTime = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleUndoBeginTime");
				config.RuleConditionCnt = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleConditionCnt");
				config.RuleUndoEndTime = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleUndoEndTime");
				config.RuleName = _ctx.StringValue("QuerySchedruleOnDemand.RuleConfig["+ i +"].RuleName");

				querySchedruleOnDemandResponse_ruleConfig.Add(config);
			}
			querySchedruleOnDemandResponse.RuleConfig = querySchedruleOnDemandResponse_ruleConfig;

			List<QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Status> querySchedruleOnDemandResponse_ruleStatus = new List<QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Status>();
			for (int i = 0; i < _ctx.Length("QuerySchedruleOnDemand.RuleStatus.Length"); i++) {
				QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Status status = new QuerySchedruleOnDemandResponse.QuerySchedruleOnDemand_Status();
				status.RuleSchedStatus = _ctx.StringValue("QuerySchedruleOnDemand.RuleStatus["+ i +"].RuleSchedStatus");
				status.Net = _ctx.StringValue("QuerySchedruleOnDemand.RuleStatus["+ i +"].Net");

				querySchedruleOnDemandResponse_ruleStatus.Add(status);
			}
			querySchedruleOnDemandResponse.RuleStatus = querySchedruleOnDemandResponse_ruleStatus;
        
			return querySchedruleOnDemandResponse;
        }
    }
}
