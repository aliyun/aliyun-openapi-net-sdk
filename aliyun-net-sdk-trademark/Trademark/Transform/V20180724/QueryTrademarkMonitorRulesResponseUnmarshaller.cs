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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryTrademarkMonitorRulesResponseUnmarshaller
    {
        public static QueryTrademarkMonitorRulesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTrademarkMonitorRulesResponse queryTrademarkMonitorRulesResponse = new QueryTrademarkMonitorRulesResponse();

			queryTrademarkMonitorRulesResponse.HttpResponse = context.HttpResponse;
			queryTrademarkMonitorRulesResponse.RequestId = context.StringValue("QueryTrademarkMonitorRules.RequestId");
			queryTrademarkMonitorRulesResponse.TotalItemNum = context.IntegerValue("QueryTrademarkMonitorRules.TotalItemNum");
			queryTrademarkMonitorRulesResponse.CurrentPageNum = context.IntegerValue("QueryTrademarkMonitorRules.CurrentPageNum");
			queryTrademarkMonitorRulesResponse.PageSize = context.IntegerValue("QueryTrademarkMonitorRules.PageSize");
			queryTrademarkMonitorRulesResponse.TotalPageNum = context.IntegerValue("QueryTrademarkMonitorRules.TotalPageNum");
			queryTrademarkMonitorRulesResponse.PrePage = context.BooleanValue("QueryTrademarkMonitorRules.PrePage");
			queryTrademarkMonitorRulesResponse.NextPage = context.BooleanValue("QueryTrademarkMonitorRules.NextPage");

			List<QueryTrademarkMonitorRulesResponse.QueryTrademarkMonitorRules_TmMonitorRule> queryTrademarkMonitorRulesResponse_data = new List<QueryTrademarkMonitorRulesResponse.QueryTrademarkMonitorRules_TmMonitorRule>();
			for (int i = 0; i < context.Length("QueryTrademarkMonitorRules.Data.Length"); i++) {
				QueryTrademarkMonitorRulesResponse.QueryTrademarkMonitorRules_TmMonitorRule tmMonitorRule = new QueryTrademarkMonitorRulesResponse.QueryTrademarkMonitorRules_TmMonitorRule();
				tmMonitorRule.Id = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].Id");
				tmMonitorRule.UserId = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].UserId");
				tmMonitorRule.RuleStatus = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].RuleStatus");
				tmMonitorRule.RuleSource = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].RuleSource");
				tmMonitorRule.RuleName = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].RuleName");
				tmMonitorRule.RuleType = context.IntegerValue("QueryTrademarkMonitorRules.Data["+ i +"].RuleType");
				tmMonitorRule.RuleKeyword = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].RuleKeyword");
				tmMonitorRule.RuleDetail = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].RuleDetail");
				tmMonitorRule.NotifyUpdate = context.IntegerValue("QueryTrademarkMonitorRules.Data["+ i +"].NotifyUpdate");
				tmMonitorRule.Version = context.IntegerValue("QueryTrademarkMonitorRules.Data["+ i +"].Version");
				tmMonitorRule.StartTime = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].StartTime");
				tmMonitorRule.EndTime = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].EndTime");
				tmMonitorRule.LastRunTime = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].LastRunTime");
				tmMonitorRule.LastFinishTime = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].LastFinishTime");
				tmMonitorRule.LastUpdateTime = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].LastUpdateTime");
				tmMonitorRule.Env = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].Env");
				tmMonitorRule.RuleExtend = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].RuleExtend");
				tmMonitorRule.CreateTime = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].CreateTime");
				tmMonitorRule.UpdateTime = context.StringValue("QueryTrademarkMonitorRules.Data["+ i +"].UpdateTime");

				queryTrademarkMonitorRulesResponse_data.Add(tmMonitorRule);
			}
			queryTrademarkMonitorRulesResponse.Data = queryTrademarkMonitorRulesResponse_data;
        
			return queryTrademarkMonitorRulesResponse;
        }
    }
}
