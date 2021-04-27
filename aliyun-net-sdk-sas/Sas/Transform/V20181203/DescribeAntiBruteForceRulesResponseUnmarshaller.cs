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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAntiBruteForceRulesResponseUnmarshaller
    {
        public static DescribeAntiBruteForceRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAntiBruteForceRulesResponse describeAntiBruteForceRulesResponse = new DescribeAntiBruteForceRulesResponse();

			describeAntiBruteForceRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeAntiBruteForceRulesResponse.RequestId = _ctx.StringValue("DescribeAntiBruteForceRules.RequestId");

			DescribeAntiBruteForceRulesResponse.DescribeAntiBruteForceRules_PageInfo pageInfo = new DescribeAntiBruteForceRulesResponse.DescribeAntiBruteForceRules_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeAntiBruteForceRules.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeAntiBruteForceRules.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeAntiBruteForceRules.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeAntiBruteForceRules.PageInfo.CurrentPage");
			describeAntiBruteForceRulesResponse.PageInfo = pageInfo;

			List<DescribeAntiBruteForceRulesResponse.DescribeAntiBruteForceRules_AntiBruteForceRule> describeAntiBruteForceRulesResponse_rules = new List<DescribeAntiBruteForceRulesResponse.DescribeAntiBruteForceRules_AntiBruteForceRule>();
			for (int i = 0; i < _ctx.Length("DescribeAntiBruteForceRules.Rules.Length"); i++) {
				DescribeAntiBruteForceRulesResponse.DescribeAntiBruteForceRules_AntiBruteForceRule antiBruteForceRule = new DescribeAntiBruteForceRulesResponse.DescribeAntiBruteForceRules_AntiBruteForceRule();
				antiBruteForceRule.Id = _ctx.LongValue("DescribeAntiBruteForceRules.Rules["+ i +"].Id");
				antiBruteForceRule.DefaultRule = _ctx.BooleanValue("DescribeAntiBruteForceRules.Rules["+ i +"].DefaultRule");
				antiBruteForceRule.Name = _ctx.StringValue("DescribeAntiBruteForceRules.Rules["+ i +"].Name");
				antiBruteForceRule.Span = _ctx.IntegerValue("DescribeAntiBruteForceRules.Rules["+ i +"].Span");
				antiBruteForceRule.FailCount = _ctx.IntegerValue("DescribeAntiBruteForceRules.Rules["+ i +"].FailCount");
				antiBruteForceRule.ForbiddenTime = _ctx.IntegerValue("DescribeAntiBruteForceRules.Rules["+ i +"].ForbiddenTime");
				antiBruteForceRule.EnableSmartRule = _ctx.BooleanValue("DescribeAntiBruteForceRules.Rules["+ i +"].EnableSmartRule");
				antiBruteForceRule.MachineCount = _ctx.IntegerValue("DescribeAntiBruteForceRules.Rules["+ i +"].MachineCount");

				List<string> antiBruteForceRule_uuidList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAntiBruteForceRules.Rules["+ i +"].UuidList.Length"); j++) {
					antiBruteForceRule_uuidList.Add(_ctx.StringValue("DescribeAntiBruteForceRules.Rules["+ i +"].UuidList["+ j +"]"));
				}
				antiBruteForceRule.UuidList = antiBruteForceRule_uuidList;

				describeAntiBruteForceRulesResponse_rules.Add(antiBruteForceRule);
			}
			describeAntiBruteForceRulesResponse.Rules = describeAntiBruteForceRulesResponse_rules;
        
			return describeAntiBruteForceRulesResponse;
        }
    }
}
