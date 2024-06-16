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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeCustomizeRuleResponseUnmarshaller
    {
        public static DescribeCustomizeRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomizeRuleResponse describeCustomizeRuleResponse = new DescribeCustomizeRuleResponse();

			describeCustomizeRuleResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomizeRuleResponse.Success = _ctx.BooleanValue("DescribeCustomizeRule.Success");
			describeCustomizeRuleResponse.Code = _ctx.IntegerValue("DescribeCustomizeRule.Code");
			describeCustomizeRuleResponse.Message = _ctx.StringValue("DescribeCustomizeRule.Message");
			describeCustomizeRuleResponse.RequestId = _ctx.StringValue("DescribeCustomizeRule.RequestId");

			DescribeCustomizeRuleResponse.DescribeCustomizeRule_Data data = new DescribeCustomizeRuleResponse.DescribeCustomizeRule_Data();
			data.Id = _ctx.LongValue("DescribeCustomizeRule.Data.Id");
			data.GmtCreate = _ctx.StringValue("DescribeCustomizeRule.Data.GmtCreate");
			data.GmtModified = _ctx.StringValue("DescribeCustomizeRule.Data.GmtModified");
			data.Aliuid = _ctx.LongValue("DescribeCustomizeRule.Data.Aliuid");
			data.RuleName = _ctx.StringValue("DescribeCustomizeRule.Data.RuleName");
			data.RuleDesc = _ctx.StringValue("DescribeCustomizeRule.Data.RuleDesc");
			data.RuleType = _ctx.StringValue("DescribeCustomizeRule.Data.RuleType");
			data.ThreatLevel = _ctx.StringValue("DescribeCustomizeRule.Data.ThreatLevel");
			data.AlertType = _ctx.StringValue("DescribeCustomizeRule.Data.AlertType");
			data.AlertTypeMds = _ctx.StringValue("DescribeCustomizeRule.Data.AlertTypeMds");
			data.LogType = _ctx.StringValue("DescribeCustomizeRule.Data.LogType");
			data.LogTypeMds = _ctx.StringValue("DescribeCustomizeRule.Data.LogTypeMds");
			data.LogSource = _ctx.StringValue("DescribeCustomizeRule.Data.LogSource");
			data.LogSourceMds = _ctx.StringValue("DescribeCustomizeRule.Data.LogSourceMds");
			data.RuleCondition = _ctx.StringValue("DescribeCustomizeRule.Data.RuleCondition");
			data.RuleGroup = _ctx.StringValue("DescribeCustomizeRule.Data.RuleGroup");
			data.RuleThreshold = _ctx.StringValue("DescribeCustomizeRule.Data.RuleThreshold");
			data.QueryCycle = _ctx.StringValue("DescribeCustomizeRule.Data.QueryCycle");
			data.EventTransferSwitch = _ctx.IntegerValue("DescribeCustomizeRule.Data.EventTransferSwitch");
			data.EventTransferType = _ctx.StringValue("DescribeCustomizeRule.Data.EventTransferType");
			data.EventTransferExt = _ctx.StringValue("DescribeCustomizeRule.Data.EventTransferExt");
			data.Status = _ctx.IntegerValue("DescribeCustomizeRule.Data.Status");
			describeCustomizeRuleResponse.Data = data;
        
			return describeCustomizeRuleResponse;
        }
    }
}
