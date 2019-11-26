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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeAccessRulesResponseUnmarshaller
    {
        public static DescribeAccessRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccessRulesResponse describeAccessRulesResponse = new DescribeAccessRulesResponse();

			describeAccessRulesResponse.HttpResponse = context.HttpResponse;
			describeAccessRulesResponse.RequestId = context.StringValue("DescribeAccessRules.RequestId");
			describeAccessRulesResponse.TotalCount = context.IntegerValue("DescribeAccessRules.TotalCount");
			describeAccessRulesResponse.PageSize = context.IntegerValue("DescribeAccessRules.PageSize");
			describeAccessRulesResponse.PageNumber = context.IntegerValue("DescribeAccessRules.PageNumber");

			List<DescribeAccessRulesResponse.DescribeAccessRules_AccessRule> describeAccessRulesResponse_accessRules = new List<DescribeAccessRulesResponse.DescribeAccessRules_AccessRule>();
			for (int i = 0; i < context.Length("DescribeAccessRules.AccessRules.Length"); i++) {
				DescribeAccessRulesResponse.DescribeAccessRules_AccessRule accessRule = new DescribeAccessRulesResponse.DescribeAccessRules_AccessRule();
				accessRule.SourceCidrIp = context.StringValue("DescribeAccessRules.AccessRules["+ i +"].SourceCidrIp");
				accessRule.Priority = context.IntegerValue("DescribeAccessRules.AccessRules["+ i +"].Priority");
				accessRule.AccessRuleId = context.StringValue("DescribeAccessRules.AccessRules["+ i +"].AccessRuleId");
				accessRule.RWAccess = context.StringValue("DescribeAccessRules.AccessRules["+ i +"].RWAccess");
				accessRule.UserAccess = context.StringValue("DescribeAccessRules.AccessRules["+ i +"].UserAccess");

				describeAccessRulesResponse_accessRules.Add(accessRule);
			}
			describeAccessRulesResponse.AccessRules = describeAccessRulesResponse_accessRules;
        
			return describeAccessRulesResponse;
        }
    }
}
