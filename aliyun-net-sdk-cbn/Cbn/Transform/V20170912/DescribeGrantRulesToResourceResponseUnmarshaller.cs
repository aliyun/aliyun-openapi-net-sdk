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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeGrantRulesToResourceResponseUnmarshaller
    {
        public static DescribeGrantRulesToResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGrantRulesToResourceResponse describeGrantRulesToResourceResponse = new DescribeGrantRulesToResourceResponse();

			describeGrantRulesToResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeGrantRulesToResourceResponse.NextToken = _ctx.StringValue("DescribeGrantRulesToResource.NextToken");
			describeGrantRulesToResourceResponse.RequestId = _ctx.StringValue("DescribeGrantRulesToResource.RequestId");
			describeGrantRulesToResourceResponse.TotalCount = _ctx.IntegerValue("DescribeGrantRulesToResource.TotalCount");
			describeGrantRulesToResourceResponse.MaxResults = _ctx.IntegerValue("DescribeGrantRulesToResource.MaxResults");

			List<DescribeGrantRulesToResourceResponse.DescribeGrantRulesToResource_GrantRule> describeGrantRulesToResourceResponse_grantRules = new List<DescribeGrantRulesToResourceResponse.DescribeGrantRulesToResource_GrantRule>();
			for (int i = 0; i < _ctx.Length("DescribeGrantRulesToResource.GrantRules.Length"); i++) {
				DescribeGrantRulesToResourceResponse.DescribeGrantRulesToResource_GrantRule grantRule = new DescribeGrantRulesToResourceResponse.DescribeGrantRulesToResource_GrantRule();
				grantRule.CenOwnerId = _ctx.LongValue("DescribeGrantRulesToResource.GrantRules["+ i +"].CenOwnerId");
				grantRule.OrderType = _ctx.StringValue("DescribeGrantRulesToResource.GrantRules["+ i +"].OrderType");
				grantRule.CenId = _ctx.StringValue("DescribeGrantRulesToResource.GrantRules["+ i +"].CenId");

				describeGrantRulesToResourceResponse_grantRules.Add(grantRule);
			}
			describeGrantRulesToResourceResponse.GrantRules = describeGrantRulesToResourceResponse_grantRules;
        
			return describeGrantRulesToResourceResponse;
        }
    }
}
