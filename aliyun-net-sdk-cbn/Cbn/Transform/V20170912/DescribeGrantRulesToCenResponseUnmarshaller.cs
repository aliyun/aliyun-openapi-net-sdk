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
    public class DescribeGrantRulesToCenResponseUnmarshaller
    {
        public static DescribeGrantRulesToCenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGrantRulesToCenResponse describeGrantRulesToCenResponse = new DescribeGrantRulesToCenResponse();

			describeGrantRulesToCenResponse.HttpResponse = _ctx.HttpResponse;
			describeGrantRulesToCenResponse.RequestId = _ctx.StringValue("DescribeGrantRulesToCen.RequestId");

			List<DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_GrantRule> describeGrantRulesToCenResponse_grantRules = new List<DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_GrantRule>();
			for (int i = 0; i < _ctx.Length("DescribeGrantRulesToCen.GrantRules.Length"); i++) {
				DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_GrantRule grantRule = new DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_GrantRule();
				grantRule.CenId = _ctx.StringValue("DescribeGrantRulesToCen.GrantRules["+ i +"].CenId");
				grantRule.ChildInstanceRegionId = _ctx.StringValue("DescribeGrantRulesToCen.GrantRules["+ i +"].ChildInstanceRegionId");
				grantRule.ChildInstanceType = _ctx.StringValue("DescribeGrantRulesToCen.GrantRules["+ i +"].ChildInstanceType");
				grantRule.ChildInstanceId = _ctx.StringValue("DescribeGrantRulesToCen.GrantRules["+ i +"].ChildInstanceId");
				grantRule.ChildInstanceOwnerId = _ctx.LongValue("DescribeGrantRulesToCen.GrantRules["+ i +"].ChildInstanceOwnerId");

				describeGrantRulesToCenResponse_grantRules.Add(grantRule);
			}
			describeGrantRulesToCenResponse.GrantRules = describeGrantRulesToCenResponse_grantRules;
        
			return describeGrantRulesToCenResponse;
        }
    }
}
