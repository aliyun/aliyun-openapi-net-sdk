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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QuerySceneRuleResponseUnmarshaller
    {
        public static QuerySceneRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySceneRuleResponse querySceneRuleResponse = new QuerySceneRuleResponse();

			querySceneRuleResponse.HttpResponse = _ctx.HttpResponse;
			querySceneRuleResponse.RequestId = _ctx.StringValue("QuerySceneRule.RequestId");
			querySceneRuleResponse.Success = _ctx.BooleanValue("QuerySceneRule.Success");
			querySceneRuleResponse.Code = _ctx.StringValue("QuerySceneRule.Code");
			querySceneRuleResponse.ErrorMessage = _ctx.StringValue("QuerySceneRule.ErrorMessage");

			QuerySceneRuleResponse.QuerySceneRule_Data data = new QuerySceneRuleResponse.QuerySceneRule_Data();
			data.Total = _ctx.IntegerValue("QuerySceneRule.Data.Total");
			data.PageSize = _ctx.IntegerValue("QuerySceneRule.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QuerySceneRule.Data.CurrentPage");

			List<QuerySceneRuleResponse.QuerySceneRule_Data.QuerySceneRule_Rule> data_ruleList = new List<QuerySceneRuleResponse.QuerySceneRule_Data.QuerySceneRule_Rule>();
			for (int i = 0; i < _ctx.Length("QuerySceneRule.Data.RuleList.Length"); i++) {
				QuerySceneRuleResponse.QuerySceneRule_Data.QuerySceneRule_Rule rule = new QuerySceneRuleResponse.QuerySceneRule_Data.QuerySceneRule_Rule();
				rule.RuleId = _ctx.StringValue("QuerySceneRule.Data.RuleList["+ i +"].RuleId");
				rule.GmtCreate = _ctx.LongValue("QuerySceneRule.Data.RuleList["+ i +"].GmtCreate");
				rule.GmtModified = _ctx.LongValue("QuerySceneRule.Data.RuleList["+ i +"].GmtModified");
				rule.RuleName = _ctx.StringValue("QuerySceneRule.Data.RuleList["+ i +"].RuleName");
				rule.RuleDescription = _ctx.StringValue("QuerySceneRule.Data.RuleList["+ i +"].RuleDescription");
				rule.RuleStatus = _ctx.IntegerValue("QuerySceneRule.Data.RuleList["+ i +"].RuleStatus");

				data_ruleList.Add(rule);
			}
			data.RuleList = data_ruleList;
			querySceneRuleResponse.Data = data;
        
			return querySceneRuleResponse;
        }
    }
}
