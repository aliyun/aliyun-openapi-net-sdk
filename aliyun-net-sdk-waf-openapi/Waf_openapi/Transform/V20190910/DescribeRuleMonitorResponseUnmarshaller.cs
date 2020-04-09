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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeRuleMonitorResponseUnmarshaller
    {
        public static DescribeRuleMonitorResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRuleMonitorResponse describeRuleMonitorResponse = new DescribeRuleMonitorResponse();

			describeRuleMonitorResponse.HttpResponse = context.HttpResponse;
			describeRuleMonitorResponse.RequestId = context.StringValue("DescribeRuleMonitor.RequestId");
			describeRuleMonitorResponse.TotalCount = context.IntegerValue("DescribeRuleMonitor.TotalCount");

			List<DescribeRuleMonitorResponse.DescribeRuleMonitor_Item> describeRuleMonitorResponse_ruleMonitors = new List<DescribeRuleMonitorResponse.DescribeRuleMonitor_Item>();
			for (int i = 0; i < context.Length("DescribeRuleMonitor.RuleMonitors.Length"); i++) {
				DescribeRuleMonitorResponse.DescribeRuleMonitor_Item item = new DescribeRuleMonitorResponse.DescribeRuleMonitor_Item();
				item.AntibotType = context.StringValue("DescribeRuleMonitor.RuleMonitors["+ i +"].AntibotType");
				item.Pv = context.LongValue("DescribeRuleMonitor.RuleMonitors["+ i +"].Pv");
				item.RuleId = context.StringValue("DescribeRuleMonitor.RuleMonitors["+ i +"].RuleId");
				item.Index = context.LongValue("DescribeRuleMonitor.RuleMonitors["+ i +"].Index");
				item.Domain = context.StringValue("DescribeRuleMonitor.RuleMonitors["+ i +"].Domain");
				item.AntibotWatch = context.StringValue("DescribeRuleMonitor.RuleMonitors["+ i +"].AntibotWatch");

				describeRuleMonitorResponse_ruleMonitors.Add(item);
			}
			describeRuleMonitorResponse.RuleMonitors = describeRuleMonitorResponse_ruleMonitors;
        
			return describeRuleMonitorResponse;
        }
    }
}
