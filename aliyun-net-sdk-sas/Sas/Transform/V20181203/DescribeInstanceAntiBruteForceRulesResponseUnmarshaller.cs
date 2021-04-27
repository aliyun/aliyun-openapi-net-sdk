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
    public class DescribeInstanceAntiBruteForceRulesResponseUnmarshaller
    {
        public static DescribeInstanceAntiBruteForceRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAntiBruteForceRulesResponse describeInstanceAntiBruteForceRulesResponse = new DescribeInstanceAntiBruteForceRulesResponse();

			describeInstanceAntiBruteForceRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAntiBruteForceRulesResponse.RequestId = _ctx.StringValue("DescribeInstanceAntiBruteForceRules.RequestId");

			DescribeInstanceAntiBruteForceRulesResponse.DescribeInstanceAntiBruteForceRules_PageInfo pageInfo = new DescribeInstanceAntiBruteForceRulesResponse.DescribeInstanceAntiBruteForceRules_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeInstanceAntiBruteForceRules.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeInstanceAntiBruteForceRules.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeInstanceAntiBruteForceRules.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeInstanceAntiBruteForceRules.PageInfo.CurrentPage");
			describeInstanceAntiBruteForceRulesResponse.PageInfo = pageInfo;

			List<DescribeInstanceAntiBruteForceRulesResponse.DescribeInstanceAntiBruteForceRules_InstanceAntiBruteForceRule> describeInstanceAntiBruteForceRulesResponse_rules = new List<DescribeInstanceAntiBruteForceRulesResponse.DescribeInstanceAntiBruteForceRules_InstanceAntiBruteForceRule>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAntiBruteForceRules.Rules.Length"); i++) {
				DescribeInstanceAntiBruteForceRulesResponse.DescribeInstanceAntiBruteForceRules_InstanceAntiBruteForceRule instanceAntiBruteForceRule = new DescribeInstanceAntiBruteForceRulesResponse.DescribeInstanceAntiBruteForceRules_InstanceAntiBruteForceRule();
				instanceAntiBruteForceRule.Id = _ctx.LongValue("DescribeInstanceAntiBruteForceRules.Rules["+ i +"].Id");
				instanceAntiBruteForceRule.Name = _ctx.StringValue("DescribeInstanceAntiBruteForceRules.Rules["+ i +"].Name");
				instanceAntiBruteForceRule.Uuid = _ctx.StringValue("DescribeInstanceAntiBruteForceRules.Rules["+ i +"].Uuid");

				describeInstanceAntiBruteForceRulesResponse_rules.Add(instanceAntiBruteForceRule);
			}
			describeInstanceAntiBruteForceRulesResponse.Rules = describeInstanceAntiBruteForceRulesResponse_rules;
        
			return describeInstanceAntiBruteForceRulesResponse;
        }
    }
}
