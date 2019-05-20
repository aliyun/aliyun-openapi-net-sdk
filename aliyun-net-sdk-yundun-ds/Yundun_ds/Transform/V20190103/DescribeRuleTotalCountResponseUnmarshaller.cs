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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeRuleTotalCountResponseUnmarshaller
    {
        public static DescribeRuleTotalCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRuleTotalCountResponse describeRuleTotalCountResponse = new DescribeRuleTotalCountResponse();

			describeRuleTotalCountResponse.HttpResponse = context.HttpResponse;
			describeRuleTotalCountResponse.RequestId = context.StringValue("DescribeRuleTotalCount.RequestId");

			DescribeRuleTotalCountResponse.DescribeRuleTotalCount_RuleCount ruleCount = new DescribeRuleTotalCountResponse.DescribeRuleTotalCount_RuleCount();
			ruleCount.TotalCount = context.LongValue("DescribeRuleTotalCount.RuleCount.TotalCount");

			List<DescribeRuleTotalCountResponse.DescribeRuleTotalCount_RuleCount.DescribeRuleTotalCount_CategoryCount> ruleCount_categoryCountList = new List<DescribeRuleTotalCountResponse.DescribeRuleTotalCount_RuleCount.DescribeRuleTotalCount_CategoryCount>();
			for (int i = 0; i < context.Length("DescribeRuleTotalCount.RuleCount.CategoryCountList.Length"); i++) {
				DescribeRuleTotalCountResponse.DescribeRuleTotalCount_RuleCount.DescribeRuleTotalCount_CategoryCount categoryCount = new DescribeRuleTotalCountResponse.DescribeRuleTotalCount_RuleCount.DescribeRuleTotalCount_CategoryCount();
				categoryCount.Name = context.StringValue("DescribeRuleTotalCount.RuleCount.CategoryCountList["+ i +"].Name");
				categoryCount.Count = context.StringValue("DescribeRuleTotalCount.RuleCount.CategoryCountList["+ i +"].Count");

				ruleCount_categoryCountList.Add(categoryCount);
			}
			ruleCount.CategoryCountList = ruleCount_categoryCountList;
			describeRuleTotalCountResponse.RuleCount = ruleCount;
        
			return describeRuleTotalCountResponse;
        }
    }
}
