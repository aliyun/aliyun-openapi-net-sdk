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
    public class QueryEdgeInstanceSceneRuleResponseUnmarshaller
    {
        public static QueryEdgeInstanceSceneRuleResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeInstanceSceneRuleResponse queryEdgeInstanceSceneRuleResponse = new QueryEdgeInstanceSceneRuleResponse();

			queryEdgeInstanceSceneRuleResponse.HttpResponse = context.HttpResponse;
			queryEdgeInstanceSceneRuleResponse.RequestId = context.StringValue("QueryEdgeInstanceSceneRule.RequestId");
			queryEdgeInstanceSceneRuleResponse.Success = context.BooleanValue("QueryEdgeInstanceSceneRule.Success");
			queryEdgeInstanceSceneRuleResponse.Code = context.StringValue("QueryEdgeInstanceSceneRule.Code");
			queryEdgeInstanceSceneRuleResponse.ErrorMessage = context.StringValue("QueryEdgeInstanceSceneRule.ErrorMessage");

			QueryEdgeInstanceSceneRuleResponse.QueryEdgeInstanceSceneRule_Data data = new QueryEdgeInstanceSceneRuleResponse.QueryEdgeInstanceSceneRule_Data();
			data.Total = context.IntegerValue("QueryEdgeInstanceSceneRule.Data.Total");
			data.PageSize = context.IntegerValue("QueryEdgeInstanceSceneRule.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QueryEdgeInstanceSceneRule.Data.CurrentPage");

			List<QueryEdgeInstanceSceneRuleResponse.QueryEdgeInstanceSceneRule_Data.QueryEdgeInstanceSceneRule_Rule> data_ruleList = new List<QueryEdgeInstanceSceneRuleResponse.QueryEdgeInstanceSceneRule_Data.QueryEdgeInstanceSceneRule_Rule>();
			for (int i = 0; i < context.Length("QueryEdgeInstanceSceneRule.Data.RuleList.Length"); i++) {
				QueryEdgeInstanceSceneRuleResponse.QueryEdgeInstanceSceneRule_Data.QueryEdgeInstanceSceneRule_Rule rule = new QueryEdgeInstanceSceneRuleResponse.QueryEdgeInstanceSceneRule_Data.QueryEdgeInstanceSceneRule_Rule();
				rule.RuleId = context.StringValue("QueryEdgeInstanceSceneRule.Data.RuleList["+ i +"].RuleId");
				rule.RuleName = context.StringValue("QueryEdgeInstanceSceneRule.Data.RuleList["+ i +"].RuleName");
				rule.GmtCreate = context.LongValue("QueryEdgeInstanceSceneRule.Data.RuleList["+ i +"].GmtCreate");
				rule.Status = context.IntegerValue("QueryEdgeInstanceSceneRule.Data.RuleList["+ i +"].Status");
				rule.IsExisted = context.IntegerValue("QueryEdgeInstanceSceneRule.Data.RuleList["+ i +"].IsExisted");

				data_ruleList.Add(rule);
			}
			data.RuleList = data_ruleList;
			queryEdgeInstanceSceneRuleResponse.Data = data;
        
			return queryEdgeInstanceSceneRuleResponse;
        }
    }
}
