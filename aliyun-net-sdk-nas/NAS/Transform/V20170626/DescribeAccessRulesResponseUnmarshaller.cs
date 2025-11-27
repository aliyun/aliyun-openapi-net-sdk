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
        public static DescribeAccessRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccessRulesResponse describeAccessRulesResponse = new DescribeAccessRulesResponse();

			describeAccessRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeAccessRulesResponse.TotalCount = _ctx.IntegerValue("DescribeAccessRules.TotalCount");
			describeAccessRulesResponse.RequestId = _ctx.StringValue("DescribeAccessRules.RequestId");
			describeAccessRulesResponse.PageSize = _ctx.IntegerValue("DescribeAccessRules.PageSize");
			describeAccessRulesResponse.PageNumber = _ctx.IntegerValue("DescribeAccessRules.PageNumber");

			List<DescribeAccessRulesResponse.DescribeAccessRules_AccessRule> describeAccessRulesResponse_accessRules = new List<DescribeAccessRulesResponse.DescribeAccessRules_AccessRule>();
			for (int i = 0; i < _ctx.Length("DescribeAccessRules.AccessRules.Length"); i++) {
				DescribeAccessRulesResponse.DescribeAccessRules_AccessRule accessRule = new DescribeAccessRulesResponse.DescribeAccessRules_AccessRule();
				accessRule.AccessRuleId = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].AccessRuleId");
				accessRule.SourceCidrIp = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].SourceCidrIp");
				accessRule.Ipv6SourceCidrIp = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].Ipv6SourceCidrIp");
				accessRule.RWAccess = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].RWAccess");
				accessRule.UserAccess = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].UserAccess");
				accessRule.Priority = _ctx.IntegerValue("DescribeAccessRules.AccessRules["+ i +"].Priority");
				accessRule.FileSystemType = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].FileSystemType");
				accessRule.AccessGroupName = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].AccessGroupName");
				accessRule.RegionId = _ctx.StringValue("DescribeAccessRules.AccessRules["+ i +"].RegionId");

				describeAccessRulesResponse_accessRules.Add(accessRule);
			}
			describeAccessRulesResponse.AccessRules = describeAccessRulesResponse_accessRules;
        
			return describeAccessRulesResponse;
        }
    }
}
