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
    public class PostCustomizeRuleResponseUnmarshaller
    {
        public static PostCustomizeRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PostCustomizeRuleResponse postCustomizeRuleResponse = new PostCustomizeRuleResponse();

			postCustomizeRuleResponse.HttpResponse = _ctx.HttpResponse;
			postCustomizeRuleResponse.Success = _ctx.BooleanValue("PostCustomizeRule.Success");
			postCustomizeRuleResponse.Code = _ctx.IntegerValue("PostCustomizeRule.Code");
			postCustomizeRuleResponse.Message = _ctx.StringValue("PostCustomizeRule.Message");
			postCustomizeRuleResponse.RequestId = _ctx.StringValue("PostCustomizeRule.RequestId");

			PostCustomizeRuleResponse.PostCustomizeRule_Data data = new PostCustomizeRuleResponse.PostCustomizeRule_Data();
			data.Id = _ctx.LongValue("PostCustomizeRule.Data.Id");
			data.GmtCreate = _ctx.StringValue("PostCustomizeRule.Data.GmtCreate");
			data.GmtModified = _ctx.StringValue("PostCustomizeRule.Data.GmtModified");
			data.Aliuid = _ctx.LongValue("PostCustomizeRule.Data.Aliuid");
			data.RuleName = _ctx.StringValue("PostCustomizeRule.Data.RuleName");
			data.RuleDesc = _ctx.StringValue("PostCustomizeRule.Data.RuleDesc");
			data.RuleType = _ctx.StringValue("PostCustomizeRule.Data.RuleType");
			data.ThreatLevel = _ctx.StringValue("PostCustomizeRule.Data.ThreatLevel");
			data.AlertType = _ctx.StringValue("PostCustomizeRule.Data.AlertType");
			data.AlertTypeMds = _ctx.StringValue("PostCustomizeRule.Data.AlertTypeMds");
			data.LogType = _ctx.StringValue("PostCustomizeRule.Data.LogType");
			data.LogTypeMds = _ctx.StringValue("PostCustomizeRule.Data.LogTypeMds");
			data.LogSource = _ctx.StringValue("PostCustomizeRule.Data.LogSource");
			data.LogSourceMds = _ctx.StringValue("PostCustomizeRule.Data.LogSourceMds");
			data.RuleCondition = _ctx.StringValue("PostCustomizeRule.Data.RuleCondition");
			data.RuleGroup = _ctx.StringValue("PostCustomizeRule.Data.RuleGroup");
			data.RuleThreshold = _ctx.StringValue("PostCustomizeRule.Data.RuleThreshold");
			data.QueryCycle = _ctx.StringValue("PostCustomizeRule.Data.QueryCycle");
			data.EventTransferSwitch = _ctx.IntegerValue("PostCustomizeRule.Data.EventTransferSwitch");
			data.EventTransferType = _ctx.StringValue("PostCustomizeRule.Data.EventTransferType");
			data.EventTransferExt = _ctx.StringValue("PostCustomizeRule.Data.EventTransferExt");
			data.Status = _ctx.IntegerValue("PostCustomizeRule.Data.Status");
			postCustomizeRuleResponse.Data = data;
        
			return postCustomizeRuleResponse;
        }
    }
}
